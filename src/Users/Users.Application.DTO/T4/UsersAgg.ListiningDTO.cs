using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
    public partial class UserProfileAccessListiningDTO : SteppableEntityDTO
	{
              }
    public partial class UserCurrentAccessSelectedListiningDTO : EntityDTO
	{
              }
    public partial class UserContactNumberListiningDTO : EntityDTO
	{
            }
    public partial class UserProfileListListiningDTO : SteppableEntityDTO
	{
              }
    public partial class UserProfileListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList,DisplayName("Profile Name"),Title] public  string Description { get; set; }[DisplayOnList,DisplayName("Code"),Subtitle] public  string? Code { get; set; }[DisplayOnList] public  string? InitialPage { get; set; }[DisplayOnList,DisplayName("Private Profile?")] public  bool? IsPrivateProfile { get; set; }     }
    public partial class UsersAggSettingsListiningDTO : EntityDTO
	{
              }
 [H1("REGISTER USER AND PROFILE ACCESSES")]  [HideTitleOnHeader]  [H2("User Registration")]     public partial class UserListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList(2),Title] public  string Name { get; set; }[DisplayOnList(4)] public System.DateOnly? BirthDate { get; set; } [DisplayOnList(5)] public  Niu.Nutri.Users.Enumerations.GenderEnum? Gender { get; set; }[DisplayOnList(7),DisplayName("E-Mail")] public  string Contact_Email { get; set; }[DisplayOnList(8)] public  bool CanUpdatePassword { get; set; }     }
    public partial class UserContactListiningDTO : EntityDTO
	{
            }
}
namespace Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests 
{
	using Requests;
    public partial class SystemPanelSubItemListiningDTO : EntityDTO
	{
              }
    public partial class SystemPanelListiningDTO : EntityDTO
	{
              }
    public partial class SystemPanelGroupListiningDTO : EntityDTO
	{
         [DisplayOnList,DisplayName("Menus")] public List<Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelListiningDTO>? SubItems { get; set; } = new List<Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelListiningDTO>();     }
}
