using Microsoft.AspNetCore.Components;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Shared.Blazor.Forms.Modal;
using Niu.Nutri.Shared.Blazor.Forms.RightContainer;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts;
using Niu.Nutri.Shared.Blazor.Sidebar.Contexts;

namespace Niu.Nutri.Shared.Blazor.Forms.Contexts
{
    public interface IBaseRightContainer : IComponent
    {
        Task RefreshMe();
        void InitializeMe(IEntityDTO model);
    }
    
    public abstract class BaseRightContainer : LayoutComponentBase, IBaseRightContainer
    {
        protected bool _initialized = false;

        public BaseRightContainer()
        {
        }

        [Parameter] public IBaseFormPagina Modal { get; set; }

        [CascadingParameter] protected ModalContext ModalContext { get; set; }

        protected GenericRightContainerContext RightContext { get; set; }

        public abstract Task RefreshMe();
        public virtual Task ResetMe()
        {
            return Task.CompletedTask;
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

            }
            if (ModalContext != null && ModalContext.RefreshRightContainer == null)
            {
                ModalContext.RefreshRightContainer += RefreshMe;
                ModalContext.ResetRightContainer += ResetMe;
            }
            return base.OnAfterRenderAsync(firstRender);
        }
        public virtual void InitializeMe(IEntityDTO model)
        {
            _initialized = true;
            if (ModalContext != null)
            {
            }
            //this.StateHasChanged();
        }

    }
}
