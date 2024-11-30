    using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
using Niu.Nutri.CrossCutting.Infra.Log.Entries;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;

namespace Niu.Nutri.Migrations.Api
{
    public static class DbFunctionsInitializer
    {
        public static async Task SeedDbFunctions(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var logProvider = scope.ServiceProvider.GetRequiredService<ILogProvider>();

            try
            {
                logProvider.Write(new LogEntry("Starting Db Functions ------>", action: nameof(SeedDbFunctions)));
                var myRepo = scope.ServiceProvider.GetRequiredService<IAddressRepository>();
                await myRepo.ExecuteCommandAsync(@"CREATE OR REPLACE FUNCTION get_nearby_nest_latlng(
                            lat FLOAT,
                            lng FLOAT,
                            radius INT,
                            page INT,
                            size INT
                        )
                        RETURNS SETOF INTEGER AS $$
                        BEGIN
                            RETURN QUERY
                            WITH DistanceQuery AS (
                                SELECT
                                    n.""Id"",
                                    ACOS(
                                        SIN(PI() * lat / 180.0) * SIN(PI() * n.""Lat"" / 180.0) +
                                        COS(PI() * lat / 180.0) * COS(PI() * n.""Lat"" / 180.0) *
                                        COS(PI() * n.""Lng"" / 180.0 - PI() * lng / 180.0)
                                    ) * 6371 AS distance
                                FROM ""NestLatLng"" n
                                WHERE n.""IsDeleted"" = false
                            )
                            SELECT ""Id""
                            FROM DistanceQuery
                            WHERE distance < radius
                            ORDER BY distance
                            OFFSET page * size
                            FETCH NEXT size ROWS ONLY;
                        END;
                        $$ LANGUAGE plpgsql;");

                await myRepo.ExecuteCommandAsync(@"CREATE OR REPLACE FUNCTION get_count_nearby_nest_latlng(
                        lat FLOAT,
                        lng FLOAT,
                        radius INT
                    )
                    RETURNS BIGINT AS $$
                    DECLARE
                        count_result BIGINT;
                    BEGIN
                        SELECT count(1) INTO count_result FROM ""NestLatLng"" n
                        WHERE
                            n.""IsDeleted"" = false
                            AND
                            ACOS(
                                SIN(PI() * lat / 180.0) * SIN(PI() * n.""Lat"" / 180.0) +
                                COS(PI() * lat / 180.0) * COS(PI() * n.""Lat"" / 180.0) *
                                COS(PI() * n.""Lng"" / 180.0 - PI() * lng / 180.0)
                            ) * 6371 < radius;
                        RETURN count_result;
                    END;
                    $$ LANGUAGE plpgsql;");

                await myRepo.ExecuteCommandAsync(
                    @"CREATE OR REPLACE FUNCTION search_addresses_by_logradouro(
                        searchTerm TEXT DEFAULT NULL,
                        skip INT DEFAULT 0,
                        take INT DEFAULT 10
                    )
                    RETURNS TABLE (
                        cidade_localidade TEXT
                    ) AS $$
                    BEGIN
                        RETURN QUERY
                        EXECUTE format(
                            'SELECT ""Cidade_Localidade""
                             FROM public.""Address""
                             WHERE ""Cidade_Localidade"" ILIKE %L
                             GROUP BY ""Cidade_Localidade""
                             ORDER BY ""Cidade_Localidade"" ASC
                             OFFSET %s ROWS FETCH NEXT %s ROWS ONLY;',
                            '%' || searchTerm || '%', skip, take
                        );
                    END;
                    $$ LANGUAGE plpgsql;");

                await myRepo.ExecuteCommandAsync(
                    @"CREATE OR REPLACE FUNCTION search_addresses_by_bairro(
                        city TEXT,
                        searchTerm TEXT DEFAULT NULL,
                        skip INT DEFAULT 0,
                        take INT DEFAULT 10
                    )
                    RETURNS TABLE (
                        Bairro_Distrito TEXT
                    ) AS $$
                    BEGIN
                        RETURN QUERY
                        EXECUTE format(
                            'SELECT ""Bairro_Distrito""
                             FROM public.""Address""
                             WHERE ""Cidade_Localidade"" = %L AND (""Bairro_Distrito"" ILIKE %L)
                             GROUP BY ""Bairro_Distrito""
                             ORDER BY ""Bairro_Distrito"" ASC
                             OFFSET %s ROWS FETCH NEXT %s ROWS ONLY;',
                             city, '%' || searchTerm || '%', skip, take
                        );
                    END;
                    $$ LANGUAGE plpgsql;");
            }
            catch (Exception ex)
            {
                logProvider.WriteError(ex, new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry(
                    title: $"Error initializing administrators: {ex.Message}",
                    action: nameof(SeedDbFunctions),
                    exception: ex));
            }
            finally
            {
                logProvider.Write(new LogEntry("<------ Seed Db Functions Finished", action: nameof(SeedDbFunctions)));
            }
        }
    }
}
