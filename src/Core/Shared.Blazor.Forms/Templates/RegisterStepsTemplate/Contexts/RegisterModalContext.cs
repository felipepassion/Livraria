using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;

namespace Niu.Nutri.Shared.Blazor.Forms.Templates.RegisterStepsTemplate.Contexts
{
    public class ModalContext
    {
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
        public IEntityDTO Model { get; set; }
        public bool Initialized { get; set; }
        public Func<Task> RefreshHeaderLayoutContent { get; set; }
        public Func<Task> RefreshFooterLayoutContent { get; set; }
        public Func<Task> RefreshRightContainer { get; set; }
        public Func<Task> ResetRightContainer { get; set; }
        public Func<Task> RefreshListingContainer { get; set; }
        public StepsContext StepsContext { get; set; }
        public Action CloseModal { get; set; }
        public bool PreventCloseModalOnSubmit { get; set; } = false;
        public bool IsSubmiting { get; set; }
        public bool IsAutoSaving { get; set; }
    }
}
