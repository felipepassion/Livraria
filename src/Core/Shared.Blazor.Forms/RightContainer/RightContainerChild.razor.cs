using Microsoft.AspNetCore.Components;

namespace Niu.Nutri.Shared.Blazor.Forms.RightContainer
{
    public abstract class RightContainerChildBaseClass : LayoutComponentBase
    {
        public abstract Task OnGroupUpdated();

        public abstract Task OnFragmentUpdated();
    }
}
