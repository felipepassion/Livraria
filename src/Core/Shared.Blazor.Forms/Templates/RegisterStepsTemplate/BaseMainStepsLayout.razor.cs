using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects;
using Niu.Nutri.Shared.Blazor.Components.Modal;
using Niu.Nutri.Shared.Blazor.Forms.Contexts;
using Niu.Nutri.Shared.Blazor.Forms.Modal;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate;
using Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts;
using System.Net.Http.Json;
using System.Reflection;

namespace Niu.Nutri.Shared.Blazor.Components.Templates.RegisterStepsTemplate
{
    public class TestSubclass
    {
        public string Test { get; set; }
    }

    public class BaseStepsFormClass<ModelType, SettingsType, ValidatorType> : LayoutComponentBase, IComponent
        where ModelType : SteppableEntityDTO, new()
        where ValidatorType : BaseValidator<ModelType>
        where SettingsType : BaseAggregateSettingsDTO, new()
    {
        [CascadingParameter] public IValidator TValidator { get; set; }

        protected BaseMainStepsLayout<ModelType>? layout { get; set; }

        [Inject] IServiceProvider _provider { get; set; }

        protected SettingsType AutoSaveSettings { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] public IJSRuntime JSRuntime { get; set; }

        public EditContext EditContext { get; set; }

        [Inject] protected HttpClient _client { get; set; }

        ModelType _model;
        [Parameter] public ModelType Model { get { return _model ??= new ModelType { ExternalId = Guid.NewGuid().ToString(), Active = true }; } set { _model = value; } }

        [Parameter] public string Id { get; set; }

        [Parameter] public int Step { get; set; }

        public bool IsModal => Modal is IBaseFormModal;

        [Parameter] public Func<Task> PaginationLayoutRefresh { get; set; }

        public RenderFragment CurrentFragment { get; set; }

        [Parameter] public BaseRightContainer RightContainer { get; set; }

        public StepsContext Context { get; set; }

        [CascadingParameter] public IBaseFormPagina Modal { get; set; }
        [Parameter] public bool PushStepToModelStep { get; set; }

        public void OnFormChanged(Action paramChanged)
        {
            // Context.RightContaier.RefreshMe();
            // Context.UpdateHeaderAction();
            // UpdateHeader();
            layout?.RefreshHeader();
            //Task.Run(()=> { layout.RefreshHeader(); });
            //paramChanged();
            //() => { paramChanged(); this.StateHasChanged(); }
        }

        [Inject] public AutoSaveSettingsDTO AutoSaveInjected { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //if (!_initialized)
            //{
            //    _initialized = true;

            //    if (!string.IsNullOrWhiteSpace(Id))
            //        Model = await _client.OnInitializedAsync<ModelType>(this.Id);

            //    Id = Model.ExternalId;

            //    EditContext = new EditContext(Model);
            //    Model.MaxSteps = this.MaxSetpsCount;
            //    await ChangeStep(Step);
            //    if (Modal is CadastroModal modalAsCadastroModal)
            //    {
            //        modalAsCadastroModal.InitializeModel(this.Model, this.Context);
            //        //this.ModalContext?.HeaderLayoutContent?.RefreshMe(this.AutoSaveInjected);
            //    }
            //    this.StateHasChanged();
            //}

            //if (!_initialized)
            //{
            //    _initialized = true;

            //    if (!string.IsNullOrWhiteSpace(Id))
            //        Model = await _client.OnInitializedAsync<ModelType>(this.Id);

            //    EditContext = new EditContext(Model);
            //    Model.MaxSteps = this.MaxSetpsCount;
            //    await ChangeStep(Step);
            //    if (Modal is CadastroModal modalAsCadastroModal)
            //    {
            //        modalAsCadastroModal.InitializeModel(this.Model, this.Context);
            //        this.ModalContext?.HeaderLayoutContent?.RefreshMe(this.AutoSaveInjected);
            //    }
            //}

            await base.OnInitializedAsync();
        }

        bool _initialized = false;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender || (!_initialized && Id != null && Model.ExternalId != Id))
            {
                _initialized = true;

                if (firstRender)
                {
                    this.AutoSaveSettings = await _client.OnInitializedAsync<SettingsType>("") ?? new SettingsType();
                    this.AutoSaveInjected.OnUpdateEvent += UpdateAutoSaveConfig;
                    this.AutoSaveInjected.Enabled = AutoSaveSettings.AutoSaveSettingsEnabled;
                }

                if (!string.IsNullOrWhiteSpace(Id))
                    Model = await _client.OnInitializedAsync<ModelType>(Id);

                EditContext = new EditContext(Model);
                Model.MaxSteps = this.MaxSetpsCount;
                
                if (PushStepToModelStep)
                    this.Step = Model.CurrentStep;

                await ChangeStep(Step);

                if (Modal is not null)
                {
                    Modal.InitializeModel(this.Model, this.Context);
                    if (this.ModalContext?.RefreshHeaderLayoutContent != null)
                        await this.ModalContext.RefreshHeaderLayoutContent();
                }
                _initialized = false;

                await InvokeAsync(this.StateHasChanged);
            }

        }

        protected async Task OnSubmitFormInvalid(EditContext editContext)
        {
            this.ModalContext.IsSubmiting = false;
            this.ModalContext.IsAutoSaving = false;

            var messages = EditContext.GetValidationMessages().ToHashSet();
            this.Context.ErrorModal.PopupErrors(errors: messages.GroupBy(x => x).Select(x => x.Key).ToArray());
        }

        protected async Task SubmitForm()
        {
            await OnSubmitForm(this.EditContext);
        }

        protected async Task OnSubmitForm(EditContext editContext)
        {
            if (this.ModalContext.IsAutoSaving)
            {
                Thread.Sleep(200);
            }
            this.ModalContext.IsSubmiting = true;

            if (Model is ISteppableEntityDTO)
            {
                Model.ChangeStep(Step + 1);
            }

            var result = await _client.CreateAsync<ModelType>(this.Model);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (Step <= 1 && PaginationLayoutRefresh != null)
                    await this.PaginationLayoutRefresh();

                Model = await _client.OnInitializedAsync<ModelType>(Model.ExternalId);

                await ChangeStep(++Step);
            }
            else
            {
                this.Context.ErrorModal.PopUp(description: string.Join(@"\n", result.Errors));
                if (Model is ISteppableEntityDTO)
                {
                    (Model as ISteppableEntityDTO).CurrentStep = Step;
                }
            }
            this.ModalContext.IsSubmiting = false;
            this.ModalContext.IsAutoSaving = false;
            await InvokeAsync(this.StateHasChanged);
        }

        protected int MaxSetpsCount
        {
            get
            {
                int? _maxSteps = null;
                if (_maxSteps.HasValue)
                    return _maxSteps.Value;

                var myName = $"{new ModelType().GetMyTypeName()}";
                _maxSteps = Assembly.GetEntryAssembly()
                    .GetTypes()
                    .Count(t => t.Name.Substring(0, t.Name.Length - 1) == myName);

                return _maxSteps.Value;
            }
        }

        protected void Backward()
        {
            if (this.Step == 0)
            {
                if (this.IsModal) { (Modal as IBaseFormModal)?.Close(); return; }
                NavigateToListiningPage(); return;
            }
            ChangeStep(--Step);
            OnKeyboardDown();
            this.ModalContext.IsSubmiting = false;
            this.ModalContext.IsAutoSaving = false;
            this.StateHasChanged();
        }

        protected void OnKeyboardDown()
        {
            this.ModalContext?.RefreshRightContainer?.Invoke();
            this.ModalContext?.RefreshHeaderLayoutContent?.Invoke();
        }

        private IJSObjectReference? jsModule;

        void NavigateToListiningPage()
        {
            if (ModalContext?.PreventCloseModalOnSubmit == true)
                return;
            var splitted = NavigationManager.Uri.Split('/');
            var x = string.Join('/', splitted.SkipLast(splitted.LastOrDefault() == "cadastro" ? 1 : 2));
            NavigationManager.NavigateTo(x);
        }

        protected async Task ChangeStep(int step)
        {
            //try
            {
                if (this.ModalContext?.PreventCloseModalOnSubmit == true)
                    this.Step = step = 0;

                if (this.Step >= Model.MaxSteps && Model.MaxSteps > 0 && Context != null)
                {
                    await Finish();
                }
                else
                {
                    this.Context = new StepsContext
                        (this.Id, step, Model.MaxSteps, Model, Backward, ChangeStep, this.RightContainer, async () => { OnKeyboardDown(); },
                         this.PaginationLayoutRefresh, this.SubmitForm, this.RenderRegisterForm);

                    if (step < 0)
                    {
                        this.Step = 0;
                    }
                    else
                    {
                        if (Model is ISteppableEntityDTO model)
                        {
                            if (step >= model.CurrentStep)
                                model.ChangeStep(step);
                        }

                        this.CurrentFragment = GetCurrentStep(step, Model);
                        this.EditContext = new EditContext(Model);
                        SetValidator();
                    }

                    //(Modal as CadastroModal)?.UpdateStepContext(Context);
                }
                await InvokeAsync(this.StateHasChanged);
            }
        }

        async Task Finish()
        {
            if (IsModal)
            {
                if (this.ModalContext.CloseModal != null)
                    this.ModalContext.CloseModal();
                if (ModalContext.RefreshListingContainer != null)
                    await ModalContext.RefreshListingContainer();
                else
                    NavigateToListiningPage();
            }
            else
                NavigateToListiningPage();

            this._initialized = false;
            if (this.Context.OnFormSubmited != null)
                await this.Context.OnFormSubmited();
        }

        private RenderFragment GetCurrentStep(int step, object model)
        {
            var main = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t == this.GetType());

            var mainName = main.FullName.Split('.').SkipLast(2).Last() + (step + 1);

            var steps = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == mainName);

            if (steps != null)
            {
                Type type = null;

                if (step < 0)
                    step = 0;

                Step = step;
                type = steps;

                //var properties = type.GetProperties();

                return AddContent(model, type);
            }

            return null;
        }

        private void SetValidator()
        {
            string myName = $"{Model.GetType().Name.Replace("DTO", "")}Step{(Step + 1)}".ToString();
            string dtoName = $"{myName}DTO";
            var test = new { myName, dtoName, xx = typeof(ValidatorType) };

            var validatorType = AssemblyScanner
                .FindValidatorsInAssembly(Assembly.GetAssembly(typeof(ValidatorType)))
                .FirstOrDefault(x => x.ValidatorType.Name.Contains(myName))
                ?.ValidatorType;
            if (validatorType is null) throw new NullReferenceException($"{nameof(validatorType)} Não foi encontrado.");
            TValidator = _provider.GetRequiredService(validatorType) as IValidator;

            //var modelType = Assembly.GetAssembly(validatorType)
            //    .GetTypes()
            //    .FirstOrDefault(x => x.Name.Contains(dtoName));
        }

        private RenderFragment AddContent(object Model, Type type)
            => builder =>
            {
                builder.OpenComponent(1, type);
                builder.AddAttribute(2, "Model", Model);
                //builder.AddAttribute(3, "Context", Context);
                builder.CloseComponent();
            };

        public void RenderRegisterForm(Type type, string id = null, IEntityDTO args = null)
        {
            //Task.Run(async () =>
            //{
            //    var myName = type.Name.Replace("DTO", "");
            //    var t = (from type in Assembly.GetExecutingAssembly().GetTypes()
            //             where
            //             type.FullName?.Contains($".{myName}.Cadastro.Cadastro", StringComparison.InvariantCultureIgnoreCase) == true
            //             select type).LastOrDefault();
            //
            //    await this.Modal.Open(AddContent(t, id, args));
            //});
            //return AutoSaveSettings;
        }

        [CascadingParameter] ModalContext ModalContext { get; set; }
        private async void UpdateAutoSaveConfig()
        {
            var newVal = !AutoSaveInjected.Enabled;
            AutoSaveSettings.AutoSaveSettingsEnabled = newVal;

            var result = await _client.PostAsJsonAsync(AutoSaveSettings.GetRoute(), AutoSaveSettings);

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //AutoSaveSettings.AutoSaveSettings.AddError($"Erro ao habilitar o autosave: {result.ReasonPhrase}");
                AutoSaveSettings.AutoSaveSettingsEnabled = AutoSaveInjected.Enabled;
            }
            else
            {
                this.AutoSaveInjected.Enabled = newVal;
                this.ModalContext?.RefreshHeaderLayoutContent?.Invoke();
                this.StateHasChanged();
            }
        }
    }
}
