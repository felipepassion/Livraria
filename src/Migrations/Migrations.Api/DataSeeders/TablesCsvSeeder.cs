using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Seedwork;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.CrossCutting.Infra.Log.Entries;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Niu.Nutri.Migrations.Api.DataSeeders
{
    public static class TablesCsvSeeder
    {
        public async static Task SeedDatabase(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();
            var log = scope.ServiceProvider.GetRequiredService<ILogProvider>();
            if (!Convert.ToBoolean(configuration["SeedEnabled"])) return;

            var service = scope.ServiceProvider.GetRequiredService<ICargaTabelaRepository>();
            var fileLocation = configuration["Cargas_Localizacao"];

            var files = Directory.GetFiles(fileLocation);
            var result = files.Select(x => new CargaTabela { TableName = x.Split("\\").Last().Replace(".csv", "") });
            Stopwatch watchTotal = new Stopwatch();
            watchTotal.Start();

            log.Write(new LogEntry("Iniciando cargas", action: "Cargas", content: result));
            List<string> cargasDone = new List<string>();
            foreach (var item in result)
            {
                int i = 0;
                Stopwatch watch = new Stopwatch();
                try
                {
                    Type myRepo = FindClass(item.TableName);
                    if (myRepo == null) throw new Exception($"Tabela '{item.TableName}' não existe.");
                    var myRepoInstance = scope.ServiceProvider.GetRequiredService(myRepo);
                    var myEntityType = myRepoInstance.GetType().BaseType.GetGenericArguments()[0];

                    var myMapper = (from asm in AppDomain.CurrentDomain.GetAssemblies()
                                    from type in asm.GetTypes()
                                    where type.IsClass && type.Name.Equals($"{item.TableName}CsvMap", StringComparison.InvariantCultureIgnoreCase)
                                    select type).FirstOrDefault();

                    var unityOfWork = myRepoInstance.GetType()
                        .GetProperty("UnitOfWork", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty)
                        .GetValue(myRepoInstance) as IUnitOfWork;

                    var empty = myRepoInstance.GetType().GetMethod("IsEmpty").Invoke(myRepoInstance, null) as bool? == true;
                    item.IsInitialized = !empty;
                    if (item.IsInitialized)
                    {
                        log.Write(new LogEntry($"Tabela [{item.TableName}] já está carregada desde {(item.UpdatedAt ?? item.CreatedAt).Value.ToString("dd/MM/yyyy")}.", action: "Cargas"));
                        continue;
                    }
                    cargasDone.Add(item.TableName);
                    log.Write(new LogEntry($"Carga Iniciada [{item.TableName}]", action: "Cargas"));

                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HeaderValidated = null,
                        MissingFieldFound = (x) => { },
                        PrepareHeaderForMatch = (args) =>
                        {
                            //Prepare header & prop names so they match
                            var prepared = args.Header.ToLower();
                            return prepared;
                        },
                    };

                    var options = new TypeConverterOptions { Formats = new[] { "dd/MM/yyyy" } };
                    var myProps = myEntityType.FillFields();
                    using (var reader = new StreamReader(Path.Combine(fileLocation, $"{item.TableName}.csv")))
                    using (var csv = new CsvReader(reader, config))
                    {
                        csv.Context.TypeConverterOptionsCache.AddOptions<DateOnly>(options);
                        //csv.Context.TypeConverterOptionsCache.AddOptions<Enum>(new TypeConverterOptions { EnumIgnoreCase = true });
                        csv.Context.RegisterClassMap(myMapper);
                        var hasValue = item.Total.HasValue;
                        if (!hasValue) { item.Total = 0; }
                        watch.Start();
                        while (csv.Read())
                        {
                            if (!hasValue)
                                item.Total++;
                            try
                            {
                                var record = csv.GetRecord(myEntityType) as IEntity;
                                if (string.IsNullOrWhiteSpace(record.GetTitle())) continue;
                                log.Write(new LogEntry($"[{i++}] + Carga [{item.TableName}] [{record.GetTitlePropName()} - {record.GetTitle()}]", action: "Cargas", content: record));
                                record.ExternalId = Guid.NewGuid().ToString();
                                var createdAt = csv["CreatedAt"];
                                record.CreatedAt = string.IsNullOrWhiteSpace(createdAt) ? DateTime.Now : DateTime.Parse(createdAt);

                                foreach (var prop in record.GetPropertiesByWithAttribute<IgnoreCsvMap>())
                                {
                                    prop.SetValue(record, null);
                                }
                                myRepoInstance.GetType().GetMethod("Add").Invoke(myRepoInstance, new[] { record });
                            }
                            catch (Exception ex)
                            {
                                log.WriteError(ex, new LogEntry($"Erro ao inserir item [linha n°: {i}] [{item.TableName}]", action: "Cargas", content: item));
                            }
                        }
                        watch.Stop();
                    }

                    unityOfWork.CommitAsync().Wait();
                    item.IsInitialized = true;
                    item.UpdatedAt = DateTime.Now;
                    var response = await service.UnitOfWork.CommitAsync();
                    if (!response.Success)
                    {
                        throw response.Exception;
                    }
                }
                catch (Exception ex)
                {
                    log.WriteError(ex, new LogEntry($"Erro ao inserir carga [linha n°: {i}] [{item.TableName}]", action: "Cargas", content: item));
                }
                finally
                {
                    log.Write(new LogEntry($"Carga Finalizada [{item.TableName}] [total: [{i}] ({watch.Elapsed.TotalMilliseconds})", action: "Cargas", content: new { Qtd = i }));
                }
            }
            log.Write(new LogEntry($"Cargas Finalizadas [total: [{cargasDone.Count}] ({watchTotal.Elapsed.TotalMilliseconds})", action: "Cargas", content: cargasDone));
        }

        private static Type FindClass(string tableName)
        {
            return (from asm in AppDomain.CurrentDomain.GetAssemblies()
                    from type in asm.GetTypes()
                    where type.IsInterface && type.Name.Equals($"I{tableName}Repository", StringComparison.InvariantCultureIgnoreCase)
                    select type).FirstOrDefault();
        }
    }
}
