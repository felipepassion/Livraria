using Microsoft.AspNetCore.Components.Forms;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;

namespace Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts
{
    public class ModalContext
    {
        string? _modalTitle;
        public string? ModalTitle { get { return _modalTitle; } set { _modalTitle = value; this.StepsContext?.CadastroModal?.RefreshMe(); } }
        public string ModalId { get; set; }
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
        public ISteppableEntityDTO Model { get; set; }
        public bool Initialized { get; set; }
        public StepsContext StepsContext { get; set; }
        public Action CloseModal { get; set; }
        public bool PreventCloseModalOnSubmit { get; set; } = false;
        public bool IsSubmiting { get; set; }
        public bool IsAutoSaving { get; set; }
        public Func<EditContext, Task>? OnFormSubmited { get; set; }

    }
}
