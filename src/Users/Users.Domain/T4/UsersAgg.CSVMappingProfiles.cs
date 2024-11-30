
using CsvHelper.Configuration;
namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UserProfileAccessCsvMap : ClassMap<UserProfileAccess>
	{
		public UserProfileAccessCsvMap()
		{
			Map(x=>x.Description).Name("Description");Map(x=>x.UserProfileId).Name("UserProfileId");Map(x=>x.SystemPanelSubItemId).Name("SystemPanelSubItemId");Map(x=>x.SystemPanelId).Name("SystemPanelId");Map(x=>x.SystemPanelGroupId).Name("SystemPanelGroupId");Map(x=>x.IsSubItem).Name("IsSubItem");Map(x=>x.ParentId).Name("ParentId");Map(x=>x.IsDirectLink).Name("IsDirectLink");Map(x=>x.CanInsert).Name("CanInsert");Map(x=>x.CanUpdate).Name("CanUpdate");Map(x=>x.CanList).Name("CanList");Map(x=>x.CanDelete).Name("CanDelete");
		}
	}
	public partial class UserCurrentAccessSelectedCsvMap : ClassMap<UserCurrentAccessSelected>
	{
		public UserCurrentAccessSelectedCsvMap()
		{
			Map(x=>x.UserProfileId).Name("UserProfileId");
		}
	}
	public partial class UserProfileListCsvMap : ClassMap<UserProfileList>
	{
		public UserProfileListCsvMap()
		{
			Map(x=>x.UserId).Name("UserId");Map(x=>x.UserProfiles).Name("UserProfiles");
		}
	}
	public partial class UserProfileCsvMap : ClassMap<UserProfile>
	{
		public UserProfileCsvMap()
		{
			Map(x=>x.Description).Name("Description");Map(x=>x.Code).Name("Code");Map(x=>x.InitialPage).Name("InitialPage");Map(x=>x.IsPrivateProfile).Name("IsPrivateProfile");Map(x=>x.Accesses).Name("Accesses");Map(x=>x.ShowSideBar).Name("ShowSideBar");
		}
	}
	public partial class UsersAggSettingsCsvMap : ClassMap<UsersAggSettings>
	{
		public UsersAggSettingsCsvMap()
		{
			Map(x=>x.UserId).Name("UserId");
		}
	}
	public partial class UserCsvMap : ClassMap<User>
	{
		public UserCsvMap()
		{
			Map(x=>x.Name).Name("Name");Map(x=>x.BirthDate).Name("BirthDate");Map(x=>x.Gender).Name("Gender");Map(x=>x.NeedResetPassword).Name("NeedResetPassword");Map(x=>x.ProfilePicture).Name("ProfilePicture");Map(x=>x.NeedSendOnboardingMail).Name("NeedSendOnboardingMail");Map(x=>x.Document).Name("Document");Map(x=>x.Contact.Contacts).Name("Contact_Contacts");Map(x=>x.Contact.Email).Name("Contact_Email");Map(x=>x.UserName).Name("UserName");Map(x=>x.Password).Name("Password");Map(x=>x.CanUpdatePassword).Name("CanUpdatePassword");Map(x=>x.SelectedAccess.UserProfileId).Name("SelectedAccess_UserProfileId");Map(x=>x.Accesses).Name("Accesses");
		}
	}
}
