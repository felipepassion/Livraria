using Microsoft.EntityFrameworkCore;
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities;
using Serilog;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Text;

namespace Niu.Nutri.Addresses.Infra.Data.Aggregates.AddressesAgg.Repositories
{
    public partial class AddressRepository
    {
        public async Task<List<Address>> SearchAddressesByLogradouroAsync(
            Expression<Func<Address, object>> groupBy,
            string? searchTerm,
            int? skip = 0,
            int? take = 10)
        {
            DbConnection oConn = null;
            try
            {
                IQueryable<Address> set = _ctx.Set<Address>();

                oConn = _ctx.Database.GetDbConnection();
                await oConn.OpenAsync();

                var command = oConn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM search_addresses_by_logradouro(@searchTerm, @skip, @take)";

                var searchTermParam = command.CreateParameter();
                searchTermParam.ParameterName = "@searchTerm";
                searchTermParam.DbType = DbType.String;
                searchTermParam.SourceColumnNullMapping = true;
                searchTermParam.Value = searchTerm ?? string.Empty;
                command.Parameters.Add(searchTermParam);

                var skipParam = command.CreateParameter();
                skipParam.ParameterName = "@skip";
                skipParam.DbType = DbType.Int32;
                skipParam.Value = skip;
                command.Parameters.Add(skipParam);

                var takeParam = command.CreateParameter();
                takeParam.ParameterName = "@take";
                takeParam.DbType = DbType.Int32;
                takeParam.Value = take;
                command.Parameters.Add(takeParam);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    var results = new List<Address>();

                    while (await reader.ReadAsync())
                    {
                        results.Add(new()
                        {
                            Cidade_Localidade = reader.GetString("Cidade_Localidade")
                        });
                    }


                    return results;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, $"Erro ao executar a função : {nameof(SearchAddressesByLogradouroAsync)} na classe : {nameof(AddressRepository)}");

                return null;

            }
            finally
            {
                if (oConn != null && oConn.State != ConnectionState.Closed)
                {
                    oConn.Close();
                }
            }
        }

        public async Task<List<Address>> SearchAddressesByBairroAsync(
            Expression<Func<Address, object>> groupBy,
            string city,
            string? searchTerm,
            int? skip = 0,
            int? take = 10)
        {
            DbConnection oConn = null;
            try
            {
                IQueryable<Address> set = _ctx.Set<Address>();

                oConn = _ctx.Database.GetDbConnection();
                await oConn.OpenAsync();

                var command = oConn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM search_addresses_by_bairro(@city, @searchTerm, @skip, @take)";

                var searchTermParam = command.CreateParameter();
                searchTermParam.ParameterName = "@searchTerm";
                searchTermParam.SourceColumnNullMapping = true;
                searchTermParam.DbType = DbType.String;
                searchTermParam.Value = searchTerm ?? string.Empty;
                command.Parameters.Add(searchTermParam);

                var cityParam = command.CreateParameter();
                cityParam.ParameterName = "@city";
                cityParam.SourceColumnNullMapping = false;
                cityParam.DbType = DbType.String;
                cityParam.Value = city;
                command.Parameters.Add(cityParam);

                var skipParam = command.CreateParameter();
                skipParam.ParameterName = "@skip";
                skipParam.DbType = DbType.Int32;
                skipParam.Value = skip;
                command.Parameters.Add(skipParam);

                var takeParam = command.CreateParameter();
                takeParam.ParameterName = "@take";
                takeParam.DbType = DbType.Int32;
                takeParam.Value = take;
                command.Parameters.Add(takeParam);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    var results = new List<Address>();

                    while (await reader.ReadAsync())
                    {
                        results.Add(new()
                        {
                            Bairro_Distrito = reader.GetString("bairro_distrito")
                        });
                    }


                    return results;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, $"Erro ao executar a função : {nameof(SearchAddressesByBairroAsync)} na classe : {nameof(AddressRepository)}");

                return null;

            }
            finally
            {
                if (oConn != null && oConn.State != ConnectionState.Closed)
                {
                    oConn.Close();
                }
            }
        }

    }
}
