using Niu.Nutri.Shared.Blazor.Sidebar.Menu;

namespace Niu.Nutri.Shared.Blazor.Sidebar.Contexts
{
    public class SidebarContext
    {
        public NavMenu Sidebar { get; set; }
        public bool isSubMenuActive { get; set; }
    }
}
