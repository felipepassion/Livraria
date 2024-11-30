using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components.Forms;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using Niu.Nutri.Shared.Blazor.Components.Modal;
using Niu.Nutri.Shared.Blazor.Components.Templates.RegisterStepsTemplate;
using Niu.Nutri.Shared.Blazor.Forms.Modal;

namespace Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts
{
    public class StepsContext
    {
        public Func<int, Task> ChangeStep { get; set; }
        public Action<Type, string, IEntityDTO> RenderForm { get; set; }
        public Func<Task> UpdateHeaderAction { get; set; }
        public Func<Task> PaginationLayoutRefresh { get; }
        public EditContext EditContext { get; }
        public FormFluentValidator Validator { get; set; }
        public bool Initialized { get; set; }
        public IBaseFormPagina CadastroModal { get; set; }
        public WarningModal ErrorModal { get; set; }
        public Func<EditContext, Task> OnFormSubmited { get; set; }

        public Func<Task> SubmitForm { get; set; }

        public StepsContext(
            string myId,
            int step,
            int maxSetpsCount,
            IEntityDTO model,
            Action backward,
            Func<int, Task> changeStep,
            Func<Task> updateHeaderAction,
            Func<Task> paginationLayoutRefresh,
            Func<Task> submitForm,
            Func<EditContext, Task>? onFormSubmited,
            Action<Type, string, IEntityDTO> renderForm)
        {
            MyId = MyId;
            CurrentStep = step;
            MaxSteps = maxSetpsCount;
            Model = model;
            Backward = backward;
            ChangeStep = changeStep;
            UpdateHeaderAction = updateHeaderAction;
            PaginationLayoutRefresh = paginationLayoutRefresh;
            SubmitForm = submitForm;
            RenderForm = renderForm;
            OnFormSubmited = onFormSubmited;
        }

        public string MyId { get; set; }
        public int CurrentStep { get; set; }
        public int MaxSteps { get; set; }
        public IEntityDTO Model { get; set; }
        public string CurrentUrl { get; set; }
        public Action Backward { get; set; }
        public Action Forward { get; set; }
        public TestSubclass Subclass { get; set; } = new TestSubclass();
        public async Task<ValidationResult> ValidateModel() => await Validator.Validator.ValidateAsync(new ValidationContext<object>(Model));
        public async Task<bool> ValidateModel2() => await Validator.ValidateAsync();
    }
}
