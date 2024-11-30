
dotnet ef migrations add 2024_11_21_12_59_32 -c ApplicationDbContext -p ..\..\..\Users.Identity
dotnet ef migrations add 2024_11_21_12_59_32 -c UsersAggcontext -p ..\..\..\Users\Users.Infra.Data
dotnet ef migrations add 2024_11_21_12_59_32 -c DefaultTemplateAggcontext -p ..\..\..\DefaultTemplate\DefaultTemplate.Infra.Data
dotnet ef migrations add 2024_11_21_12_59_32 -c ChatAggcontext -p ..\..\..\Chat\Chat.Infra.Data
dotnet ef migrations add 2024_11_21_12_59_32 -c SystemSettingsAggcontext -p ..\..\..\SystemSettings\SystemSettings.Infra.Data
dotnet ef migrations add 2024_11_21_12_59_32 -c AddressesAggcontext -p ..\..\..\Addresses\Addresses.Infra.Data
dotnet ef migrations add 2024_11_21_12_59_32 -c LivrariaAggcontext -p ..\..\..\Livraria\Livraria.Infra.Data
