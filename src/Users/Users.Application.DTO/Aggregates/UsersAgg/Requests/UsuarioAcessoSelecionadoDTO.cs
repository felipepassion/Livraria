
using Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests;
using Niu.Nutri.Users.Enumerations;
using System.Text.Json.Serialization;

namespace Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests
{
    public partial class UserCurrentAccessSelectedDTO
    {
        [JsonIgnore]
        public UserDTO? User { get; set; }
        public UserProfileDTO? UserProfile { get; set; }
        public SystemPanelSubItemDTO? SelectedPage { get; set; } = new SystemPanelSubItemDTO();
        public UserProfileAccessDTO? AccessOfThisPage { get; set; } = new UserProfileAccessDTO();
        public bool IsInitialized { get; set; }
        [JsonIgnore]
        public Func<Task>? RefreshHeaderUserInfos { get; set; }
        [JsonIgnore]
        public Func<Task>? RefreshFooterUserInfos { get; set; }
        public UserRole? MyCurrentRole => Enum.TryParse<UserRole>(this.UserProfile?.Code, out var val) ? val : null;
        public List<UserProfileListDTO>? AllMyAccesses { get; set; } = null!;
    }
}
