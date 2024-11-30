using Microsoft.AspNetCore.SignalR.Client;
using Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests;

namespace Niu.Nutri.Shared.Blazor.Sidebar.Contexts
{
    public class SidebarClientContext
    {
        HubConnection HubConnection;

        public SidebarClientContext(HubConnection hubConnection)
        {
            HubConnection = hubConnection;
        }

        public async Task Open(SystemPanelDTO panel)
        {
            await HubConnection.SendAsync("OpenSidebar", panel);
        }

        public async Task RefreshMenus()
        {
            await HubConnection.SendAsync("RefreshMenus");
        }

        public async Task Close()
        {
            await HubConnection.SendAsync("CloseSidebar");
        }

        public async Task RefreshElements(SystemPanelDTO panel)
        {
            await HubConnection.SendAsync("UpdateMenuItems", panel);
        }

        public async Task UpdateSubModel(SystemPanelSubItemDTO panel)
        {
            await HubConnection.SendAsync("UpdateSubModel", panel);
        }

        public async Task UpdateModel(SystemPanelDTO panel)
        {
            await HubConnection.SendAsync("UpdateModel", panel);
        }
    }
}
