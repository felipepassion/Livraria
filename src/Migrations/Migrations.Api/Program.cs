using Microsoft.AspNetCore.DataProtection;
using Niu.Nutri.Migrations.Api;
using Niu.Nutri.Migrations.Api.DataSeeders;
using Schedulings.Domain.Tests;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataProtection().SetApplicationName("SharedCookieApp");

builder.Services.AddAuthentication("Identity.Application")
    .AddCookie("Identity.Application", options =>
    {
        options.Cookie.Name = ".AspNet.SharedCookie";
    });

builder.Services.InjectDependencies(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Migrate();
app.OnAppInitialized();

await app.SeedAdministratorUser();
await app.CriarMenus(builder.Services);
await app.CriarPerfisDeUsuario(builder.Services);
await app.CriarSeedUsers(builder.Services);
await app.SeedDatabase();
await app.SeedDbFunctions();


app.Run();