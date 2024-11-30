using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects;
using Syncfusion.Blazor;

namespace Niu.Nutri.Shared.Blazor.Forms.IoC
{
    public static class IoCFactory
    {
        public static void ConfigureSyncfusion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<AutoSaveSettingsDTO>();
            services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc3ODA0NkAzMjMzMmUzMDJlMzBFcjMvdFBxcjdQMFB0WUV5VmI0ZW5xRVFhZVJPcHQ3ZStCdllEL3AxRTNzPQ==");
        }
    }
}
