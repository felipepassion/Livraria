using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts;
using System.Reflection;

namespace Niu.Nutri.Shared.Blazor.Forms.Modal
{
    public interface IBaseFormPagina
    {
        public object[] Args { get; set; }
        public RenderFragment ChildFragment { get; set; }
        public EventCallback<object[]> ArgsChanged { get; set; }
        ModalContext ModalContext { get; }
        Task RenderFormContent(IEntityDTO context);
        void InitializeModel(IEntityDTO model, StepsContext stepsContext);
    }

    public abstract class BaseFormPagina : LayoutComponentBase, IBaseFormPagina
    {
        [Parameter] public object[] Args { get; set; }
        [Parameter] public RenderFragment ChildFragment { get; set; }
        [Parameter] public EventCallback<object[]> ArgsChanged { get; set; }
        [Parameter] public string NextNavButtonText { get; set; }

        [Parameter] public bool HideNavigationButtons { get; set; }
        [Parameter] public bool HideHeaderButtons { get; set; }
        [Parameter] public EventCallback<bool> FormPreenchido { get; set; }

        bool contentInitialized = false;
        public bool EnableRightContainer => this.RightContainer != null;
        public StepsHeaderTitleContainer HeaderLayoutContent { get; set; }
        public StepsNextAndBackButtons NextAndBackButtonsContainer { get; set; }

        protected Dictionary<string, object> iconBtnFechar = new Dictionary<string, object>()
        {
            { "class", "icon-fechar-modal" }
        };
        public RenderFragment RightContainer { get; set; }

        protected string? _myId;
        [Parameter] public bool IsOpen { get; set; }
        protected bool isModalInitialized = false;
        protected string MyId { get { return (_myId ?? (_myId = Guid.NewGuid().ToString().Split('-').First())); } set { _myId = _myId ?? value; } }


        [Inject] protected IJSRuntime _js { get; set; }

        public ModalContext ModalContext { get; protected set; }

        public BaseFormPagina()
        {
            this.ModalContext = new ModalContext();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!isModalInitialized && ModalContext.Model != null)
            {
                isModalInitialized = true;
                OpenRegisterModal();
                this.HeaderLayoutContent?.RefreshMe();
                if (this.ModalContext.RefreshRightContainer != null)
                    await this.ModalContext.RefreshRightContainer();
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        public void RenderFormContent(Type fragmentType, Type rightContainerType, IEntityDTO context)
        {
            this.ChildFragment = null;
            Task.Run(this.StateHasChanged);
            var fragment = AddContent(fragmentType, context);

            RenderFragment rightFragment = null;
            if (rightContainerType != null)
                rightFragment = AddRightContent(rightContainerType, context, context.ExternalId);

            OpenWithRightContainer(fragment, rightFragment);
        }

        private RenderFragment AddContent(Type type, IEntityDTO model)
         => builder =>
         {
             builder.OpenComponent(0, type);
             //builder.AddAttribute(1, "Modal", this);
             builder.AddAttribute(3, "Id", model.ExternalId);
             //builder.AddAttribute(4, "Context", this.StepsContext);
             builder.CloseComponent();
         };

        public async Task RenderFormContent(IEntityDTO context)
        {
            this.ModalContext.Model = context;

            var types = (from type in Assembly.GetEntryAssembly()!.GetTypes()
                         where
                         type.FullName?.Contains($".{this.ModalContext.Model.GetMyTypeName()}.Cadastro", StringComparison.InvariantCultureIgnoreCase) == true
                         select type).ToArray();

            var t = (from type in Assembly.GetEntryAssembly().GetTypes()
                     where
                     type.FullName?.Contains($".{this.ModalContext.Model.GetMyTypeName()}.Cadastro", StringComparison.InvariantCultureIgnoreCase) == true
                     select type).LastOrDefault(x => x.FullName.EndsWith(".Cadastro.Cadastro"));

            this.ChildFragment = AddContent(t, this.ModalContext.Model);

            if (this.ModalContext.RefreshRightContainer != null)
                this.ModalContext.RefreshRightContainer();

            await InvokeAsync(this.StateHasChanged);
        }

        private RenderFragment AddRightContent(Type type, IEntityDTO model, string externalEntityId = null)
        => builder =>
        {
            builder.OpenComponent(0, type);
            builder.AddAttribute(1, "Modal", this);
            //builder.AddAttribute(2, "Model", model);
            builder.CloseComponent();
        };

        public void OpenRegisterModal()
        {
            var myTypeName = this.ModalContext.Model.GetMyTypeName();

            var types = (from type in Assembly.GetEntryAssembly().GetTypes()
                         where
                         type.FullName?.Contains($".{myTypeName}.Cadastro", StringComparison.InvariantCultureIgnoreCase) == true
                         select type).ToList();

            var rightContainerType = types.Where(x => x.FullName.EndsWith("RightContainer", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            if (rightContainerType != null)
                RightContainer = AddRightContent(rightContainerType, this.ModalContext.Model, this.ModalContext.Model.ExternalId);
            this.StateHasChanged();
        }

        public void OpenWithRightContainer(RenderFragment body, RenderFragment rightContainer)
        {
            this.ChildFragment = body;
            this.RightContainer = rightContainer;
            isModalInitialized = false;
            IsOpen = true;
            this.StateHasChanged();
        }
        public virtual void InitializeModel(IEntityDTO model, StepsContext stepsContext)
        {
            this.ModalContext.Model = model;
            stepsContext.CadastroModal = this;
            UpdateStepContext(stepsContext);
        }

        public void UpdateStepContext(StepsContext context)
        {
            InvokeAsync(this.StateHasChanged);

            this.ModalContext.StepsContext = context;
            this.HeaderLayoutContent?.RefreshMe();
            this.NextAndBackButtonsContainer?.RefreshMe();
        }
    }
}