using Niu.Nutri.Core.Api.Middlewares;

namespace Niu.Nutri.Livraria.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthorization();

            builder.Services.InjectDependencies(builder.Configuration);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("_myAllowSpecificOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod()
                               .SetIsOriginAllowed((x) => true);
                    });
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseCors("_myAllowSpecificOrigins");

            app.UseForwardedHeaders();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            app.OnAppInitialized();
            app.UseMiddleware<ErrorHandlingMiddleware>();

            app.Run();
        }
    }
}

