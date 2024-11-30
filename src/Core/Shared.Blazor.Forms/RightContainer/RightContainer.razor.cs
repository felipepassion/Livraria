using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Shared.Blazor.Forms.Modal;

namespace Niu.Nutri.Shared.Blazor.Forms.RightContainer
{
    public class GenericRightContainerContext
    {
        private readonly IBaseFormPagina Modal;
        private readonly Func<Task> rightContainerUpdate;

        public void UpdateRightContainer() => rightContainerUpdate();

        public GenericRightContainerContext(Func<Task> RightContainerUpdate, IEntityDTO model, IBaseFormPagina modal)
        {
            //this.Model = model;
            Modal = modal;
            rightContainerUpdate = RightContainerUpdate;
            GroupRefreshActions = new Dictionary<string, Action>();
        }

        public async Task<bool> OnGroupClicked<T>(T model)
            where T : IEntityDTO, new()
        {
            if (IsMouseHoverPlusBtn) return false;
            if (IsSubItemClicked || GroupClickedId?.Equals(model.ExternalId) != true)
            {
                GroupClickedId = model.ExternalId;
                Modal.RenderFormContent(model);
                IsSubItemClicked = false;
                SubItemClickedId = null;
                IsGroupClicked = true;
                return true;
            }
            else
            {
                IsGroupClicked = !IsGroupClicked;
                return false;
            }
        }

        public async Task OnSubItemClicked<T>(string id, T model = default)
            where T : IEntityDTO, new()
        {
        }

        public async Task OnSubItemClicked<T>(T model, bool forceNavigation = false)
            where T : IEntityDTO, new()
        {
            await Task.Run(async () =>
            {
                if (IsMouseHoverPlusBtn && !forceNavigation) return;
                if (SubItemClickedId?.Equals(model.ExternalId) != true)
                {
                    SubItemClickedId = model.ExternalId;
                    await Modal.RenderFormContent(model);
                    IsGroupClicked = false;
                    IsSubItemClicked = true;
                }
                else
                {
                    IsSubItemClicked = !IsSubItemClicked;
                }
            });
        }

        public bool IsSubItemClicked { get; set; } = true;
        public bool IsGroupClicked { get; set; } = true;
        public string SubItemClickedId { get; set; }
        public string GroupClickedId { get; set; }
        //public IEntityDTO Model { get; set; }
        public string SubItemId { get; set; }

        public bool IsMouseHoverPlusBtn { get; set; }
        public bool IsMouseHoverTrashBtn { get; set; }
        public bool IsHoverAnyButton => IsMouseHoverPlusBtn || IsMouseHoverTrashBtn;

        public Dictionary<string, Action> GroupRefreshActions { get; set; } = new Dictionary<string, Action>();
    }
}
