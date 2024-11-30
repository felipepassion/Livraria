﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;

namespace Niu.Nutri.Shared.Blazor.Forms.Modal
{
    public interface IBaseModal
    {
        public Action? OnCloseModal { get; set; }
        Task Open();
        Task Open(params object[] args);
        Task Open<T>(RenderFragment fragment, params object[] args) where T : IEntityDTO;
        void Close();
        void Close(bool invokeCallback = false);
        bool IsOpen { get; set; }
        object[] Args { get; set; }
        EventCallback<object[]> ArgsChanged { get; set; }
        public RenderFragment ChildFragment { get; set; }
    }

    public abstract class BaseModal : LayoutComponentBase, IBaseModal
    {
        [Parameter] public RenderFragment ChildFragment { get; set; }
        [Parameter] public object[] Args { get; set; }
        [Parameter] public EventCallback<object[]> ArgsChanged { get; set; }

        [Parameter] public Action? OnCloseModal { get; set; }
        [Parameter] public bool IsOpen { get; set; }

        [Inject] protected IJSRuntime _js { get; set; }

        protected string? _myId;
        protected bool isModalInitialized = false;
        protected string MyId { get { return (_myId ?? (_myId = Guid.NewGuid().ToString().Split('-').First())); } set { _myId = _myId ?? value; } }

        public BaseModal()
        {
            
        }

        async protected Task HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Escape" || e.Key == "Esc")
            {
                // Sua lógica para o evento 'Esc' aqui
                Close();
            }
        }

        public virtual async Task Open()
        {
            await Open(null);
        }

        public virtual async Task Open(params object[] args)
        {
            if (args != null)
            {
                this.Args = args;
                await ArgsChanged.InvokeAsync(Args);
            }
            isModalInitialized = false;
            IsOpen = true;

            this.StateHasChanged();
        }

        public virtual async Task Open<T>(RenderFragment fragment, params object[] args)
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
            IsOpen = false;
            this.ChildFragment = null;
            this.StateHasChanged();
            _js.InvokeVoidAsync("closeModal", MyId);

            if (invokeCallback && OnCloseModal != null) OnCloseModal();
        }
    }
}