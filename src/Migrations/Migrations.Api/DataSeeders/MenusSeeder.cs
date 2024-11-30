using Niu.Nutri.Core.Domain.Seedwork;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
using Niu.Nutri.SystemSettings.Domain.Tests.Components;
using Niu.Nutri.Users.Enumerations;

namespace Niu.Nutri.Migrations.Api.DataSeeders
{
    public static class SidebarMenusCargas
    {
        //protected ISystemPanelRepository _systemPanelRepository;
        //protected ISystemPanelGroupRepository _systemPanelGroupRepository;
        //protected ISystemPanelSubItemRepository _systemPanelSubItemRepository;
        //protected IConfiguration _configuration;

        //public SidebarMenusCargas(IConfiguration configuration,
        //    ISystemPanelGroupRepository systemPanelGroupRepository,
        //    ISystemPanelRepository systemPanelRepository,
        //    ISystemPanelSubItemRepository systemPanelSubItemRepository)
        //        : base()
        //{
        //    _configuration = configuration;
        //    _systemPanelRepository = systemPanelRepository;
        //    _systemPanelGroupRepository = systemPanelGroupRepository;
        //    _systemPanelSubItemRepository = systemPanelSubItemRepository;
        //}

        public static async Task CriarMenus(this WebApplication app, IServiceCollection serviceProvider)
        {
            try
            {
                await CreateAdmNiuNutriMenu(UserProfileTypes.SUPPORT, "Supervisor", SupportMenus.CreateSupervisorMenus(), serviceProvider.BuildServiceProvider());
                await CreateAdmNiuNutriMenu(UserProfileTypes.USER, "Supervisor", new List<SystemPanelSubItem>(), serviceProvider.BuildServiceProvider());
            }
            catch (Exception ex)
            {
                // Considerar logar a exce��o aqui.
                throw;
            }
        }

        private static async Task<SystemPanelSubItem> CreateAdmNiuNutriMenu(string code, string componentName, List<SystemPanelSubItem> subMenus, IServiceProvider serviceProvider)
        {
            var _systemPanelRepository = serviceProvider.GetRequiredService<ISystemPanelRepository>();
            var _systemPanelGroupRepository = serviceProvider.GetRequiredService<ISystemPanelGroupRepository>();
            var _systemPanelSubItemRepository = serviceProvider.GetRequiredService<ISystemPanelSubItemRepository>();

            var menusGroup = await FindOrCreateMenusGroup(code, _systemPanelGroupRepository);

            var name = Enum.Parse<UserRole>(code).ToFriendlyString() + " " + "Assemblies";

            var panel = await _systemPanelRepository.FindAsync(x => x.Code == code);

            if (panel == null)
            {
                panel = new SystemPanel
                {
                    CurrentStep = 1,
                    Description = name,
                    Code = code,
                    Icon = "/imgs/menus/2-adm/sidebar-closed/1-menu-instituicoes/1-menu-instituicoes-Niu.Nutri.svg",
                    SubItems = new List<SystemPanelSubItem>
                    {
                        new SystemPanelSubItem
                        {
                            Url = "Assemblies",
                            Description = "Search Tools",
                            LinkDireto = true
                        }
                    }
                };

                menusGroup.SubItems.Add(panel);
            }
            if (!panel.SubItems.Any(x => x.Description == componentName))
            {
                int pos = 0;
                panel.SubItems.Add(new SystemPanelSubItem
                {
                    Description = componentName,
                    LinkDireto = false,
                    Position = pos++
                });
            }
            await SaveChanges(_systemPanelGroupRepository.UnitOfWork);
            await SaveChanges(_systemPanelRepository.UnitOfWork);

            var componentPanel = await _systemPanelSubItemRepository.FindAsync(x => x.Description == componentName && x.SystemPanelId == panel.Id);
            if (componentPanel.SubItems == null || componentPanel.SubItems.Count == 0)
            {
                componentPanel.SubItems = new List<SystemPanelSubItem>();
                int pos = 0;
                subMenus.ForEach(x =>
                {
                    x.SystemPanelId = panel.Id;
                    x.SystemPanelSubItemId = componentPanel.Id;
                    x.Position = pos++;
                });

                _systemPanelSubItemRepository.AddRange(subMenus);
                await SaveChanges(_systemPanelSubItemRepository.UnitOfWork);
            }

            return componentPanel;
        }

        private static async Task<SystemPanelGroup> FindOrCreateMenusGroup(string code, ISystemPanelGroupRepository _systemPanelGroupRepository)
        {
            var menusGroup = await _systemPanelGroupRepository.FindAsync(x => x.Code.ToLower() == code.ToLower());
            if (menusGroup == null)
            {
                menusGroup = new SystemPanelGroup
                {
                    Description = $"Panel {Enum.Parse<UserRole>(code).ToFriendlyString()}",
                    Code = code,
                    IsPrivate = false,
                    Active = true,
                    SubItems = new List<SystemPanel>()
                };

                _systemPanelGroupRepository.Add(menusGroup);
            }

            return menusGroup;
        }

        private static async Task SaveChanges(IUnitOfWork unitOfWork)
        {
            try
            {
                var response = await unitOfWork.CommitAsync();
                if (!response.Success)
                    throw new Exception("response.Success.Should().BeTrue()");
                if (response.Errors.Any())
                    throw new Exception("response.Errors.Should().BeEmpty();");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SystemPanelSubItem CreateSystemPanelSubItem(string description)
        {
            return new SystemPanelSubItem
            {
                Description = description,
                Url = description,
                IsSubItem = true
            };
        }
    }
}

