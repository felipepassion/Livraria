
using Niu.Nutri.Core.Api.Middlewares;
using Niu.Nutri.SystemSettings.Api;

namespace SystemSettingss.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthorization();

            builder.Services.InjectDependencies(builder.Configuration);

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            app.OnAppInitialized();
            app.UseMiddleware<ErrorHandlingMiddleware>();

            app.Run();
        }
    }
}

