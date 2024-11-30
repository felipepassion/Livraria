using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Core.Application.DTO.Seedwork;

namespace Niu.Nutri.Users.Identity.Infra.IoC
{
    public partial class IoCFactory
    {
        #region Constructor

        private static IoCFactory _current;
        public static IoCFactory Current { get { return _current ??= new IoCFactory(); } }

        #endregion

        public void Configure(IConfiguration configuration, IServiceCollection services)
        {
            ConfigureDatabase(services, configuration);
            ConfigureMappings();
        }

        void ConfigureMappings() { MapperFactory.Setup(this.GetType().Namespace!.Replace("Infra.IoC", "")); }

        static void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            //services.addauthentication(identityconstants.applicationscheme)
            //    .addidentitycookies();


            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddSignInManager<SignInManager<ApplicationUser>>()
                .AddRoles<IdentityRole<int>>()
                .AddUserManager<UserManager<ApplicationUser>>()
                .AddRoleManager<RoleManager<IdentityRole<int>>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddApiEndpoints()
                .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);
        }
    }
}