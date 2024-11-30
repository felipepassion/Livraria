using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts;
using Niu.Nutri.WebApp.Client.Pages.Templates.RegisterStepsTemplate;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Niu.Nutri.Shared.Blazor.Forms.Modal
{
    public interface IBaseFormPagina
    {
        public string MyId { get; }
        public Func<EditContext, Task>? OnFormSubmited { get; set; }
        public object[][] Args { get; set; }
        public RenderFragment ChildFragment { get; set; }
        public EventCallback<object[]> ArgsChanged { get; set; }
        ModalContext ModalContext { get; }
        Task RenderFormContent(IEntityDTO context);
        void InitializeModel(IEntityDTO model, StepsContext stepsContext);
        public Task RefreshMe();
    }

    public abstract class BaseFormPagina : LayoutComponentBase, IBaseFormPagina
    {
        [Parameter] public Func<EditContext, Task>? OnFormSubmited { get; set; }
        [Parameter] public string? Style { get; set; }
        [Parameter] public object[][] Args { get; set; }
        [Parameter] public RenderFragment ChildFragment { get; set; }
        [Parameter] public EventCallback<object[]> ArgsChanged { get; set; }
        [Parameter] public string NextNavButtonText { get; set; }
        public StepsNextAndBackButtons NextAndBackButtonsContainer { get; set; }

        [Parameter] public bool HideNavigationButtons { get; set; }
        [Parameter] public EventCallback<bool> FormPreenchido { get; set; }

        protected Dictionary<string, object> iconBtnFechar = new Dictionary<string, object>()
        {
            { "class", "icon-fechar-modal" }
        };

        protected string? _myId;
        [Parameter] public bool IsOpen { get; set; }
        protected bool isModalInitialized = false;
        public string MyId { get { return (_myId ?? (_myId = Guid.NewGuid().ToString().Split('-').First())); } set { _myId = _myId ?? value; } }


        [Inject] protected IJSRuntime _js { get; set; }

        public ModalContext ModalContext { get; protected set; }

        public BaseFormPagina()
        {
            this.ModalContext = new ModalContext();
        }

        public async Task RefreshMe()
        {
            await this.InvokeAsync(this.StateHasChanged);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isModalInitialized && ModalContext.Model != null)
            {
                isModalInitialized = true;
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        private RenderFragment AddContent(Type type, IEntityDTO model)
         => builder =>
         {
             builder.OpenComponent(0, type);
             //builder.AddAttribute(1, "Modal", this);
             builder.AddAttribute(3, "Id", model.ExternalId);
             builder.AddAttribute(4, "Modal", this);
             if (Args != null)
             {
                 for (int i = 5; i < Args?.Count(); i++)
                 {
                     builder.AddAttribute(4, Args[i][0]!.ToString()!, Args[i][1]);
                 }
             }
             //builder.AddAttribute(4, "Context", this.StepsContext);
             builder.CloseComponent();
         };

        public async Task RenderFormContent(IEntityDTO context)
        {
            this.ModalContext.Model = context as ISteppableEntityDTO;

            var t = (from type in Assembly.GetEntryAssembly()!.GetTypes()
                     where
                     type.FullName?.Contains($".{this.ModalContext.Model.GetMyTypeName()}.Cadastro", StringComparison.InvariantCultureIgnoreCase) == true
                     select type).LastOrDefault(x => x.FullName.EndsWith(".Cadastro.Cadastro"));

            this.ChildFragment = AddContent(t, this.ModalContext.Model);

            await InvokeAsync(this.StateHasChanged);
        }

        public virtual void InitializeModel(IEntityDTO model, StepsContext stepsContext)
        {
            this.ModalContext.Model = model as ISteppableEntityDTO;
            stepsContext.CadastroModal = this;
            stepsContext.Initialized = true;
            UpdateStepContext(stepsContext);
        }

        public async Task UpdateStepContext(StepsContext context)
        {
            this.ModalContext.StepsContext = context;
            await this.NextAndBackButtonsContainer?.RefreshMe();
            await InvokeAsync(this.StateHasChanged);
        }
    }
}