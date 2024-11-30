using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.JSInterop;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Shared.Blazor.Forms.Modal;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts;

namespace Niu.Nutri.Shared.Blazor.Components.Modal
{
    public interface IBaseFormModal : IBaseFormPagina
    {
        public Action? OnCloseModal { get; set; }
        Task Open();
        Task Open(params object[][] args);
        Task Open<T>(RenderFragment fragment, params object[][] args) where T : IEntityDTO;
        void Close();
        void Close(bool invokeCallback = false);
        bool IsOpen { get; }
    }

    public abstract class BaseFormModal : BaseFormPagina, IBaseFormModal
    {
        [Parameter] public Action? OnCloseModal { get; set; }
        [Parameter] public bool HideHeader { get; set; }

        public BaseFormModal()
        {
            this.ModalContext = new ModalContext();
            this.ModalContext.CloseModal += this.Close;
            this.ModalContext.ModalId = this.MyId;
        }

        async protected Task HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Escape" || e.Key == "Esc")
            {
                // Sua lógica para o evento 'Esc' aqui
                Close();
            }
        }
        bool moved = false;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isModalInitialized && base.IsOpen)
            {
                this.ModalContext = new ModalContext();
                this.ModalContext.CloseModal += this.Close;
                this.ModalContext.OnFormSubmited = this.OnFormSubmited;
                this.ModalContext.ModalId = this.MyId;

                isModalInitialized = true;
            }
            else if (!moved && isModalInitialized)
            {
                moved = true;
                await _js.InvokeVoidAsync("moveModalToTop", MyId);
                this.StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        public virtual async Task Open()
        {
            await Open(Args);
        }

        public virtual async Task Open(params object[][] args)
        {
            if (args != null)
            {
                this.Args = args;
                await ArgsChanged.InvokeAsync(Args);
            }
            isModalInitialized = false;
            base.IsOpen = true;

            this.StateHasChanged();
        }

        public virtual async Task Open<T>(RenderFragment fragment, params object[][] args)
            where T : IEntityDTO
        {
            this.ChildFragment = fragment;
            await this.Open(args);
        }

        public virtual void Close()
        {
            this.StateHasChanged();
            Close(false);
        }

        public void Close(bool invokeCallback = false)
        {
            isModalInitialized = false;
            base.IsOpen = false;
            this.ChildFragment = null;
            this.StateHasChanged();
            _js.InvokeVoidAsync("closeModal", MyId);

            if (invokeCallback && OnCloseModal != null) OnCloseModal();
        }
    }
}