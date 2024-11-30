using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities;

namespace Niu.Nutri.SystemSettings.Domain.Tests.Components
{
    public static class SupportMenus
    {
        public static List<SystemPanelSubItem> CreateSupervisorMenus()
        {
            return new List<SystemPanelSubItem>()
                                        {
                                            new SystemPanelSubItem
                                            {
                                                Url=$"/Assemblies",
                                                Description="Assemblies",
                                                Position = 0
                                            }
                                        };
        }
    }
}
