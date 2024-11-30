using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Specifications {
	using Entities;
   public partial class ConversationSpecifications {
				public static Specification<Conversation> FromAvatarContains(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.FromAvatar.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> FromAvatarNotContains(string value) {
			return new DirectSpecification<Conversation>(p => !EF.Functions.Like(p.FromAvatar.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> FromAvatarStartsWith(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.FromAvatar.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Conversation> FromAvatarEqual(string value) {
			return new DirectSpecification<Conversation>(p => value.ToLower() == (p.FromAvatar.ToLower()));
		}
		public static Specification<Conversation> FromAvatarNotEqual(string value) {
			return new DirectSpecification<Conversation>(p => p.FromAvatar != value);
		}
		public static Specification<Conversation> FromAvatarIsNull() {
            return new DirectSpecification<Conversation>(p => p.FromAvatar == null);
        }
		public static Specification<Conversation> FromAvatarIsNotNull() {
            return new DirectSpecification<Conversation>(p => p.FromAvatar != null);
        }
		
					public static Specification<Conversation> FromNameContains(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.FromName.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> FromNameNotContains(string value) {
			return new DirectSpecification<Conversation>(p => !EF.Functions.Like(p.FromName.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> FromNameStartsWith(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.FromName.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Conversation> FromNameEqual(string value) {
			return new DirectSpecification<Conversation>(p => value.ToLower() == (p.FromName.ToLower()));
		}
		public static Specification<Conversation> FromNameNotEqual(string value) {
			return new DirectSpecification<Conversation>(p => p.FromName != value);
		}
		public static Specification<Conversation> FromNameIsNull() {
            return new DirectSpecification<Conversation>(p => p.FromName == null);
        }
		public static Specification<Conversation> FromNameIsNotNull() {
            return new DirectSpecification<Conversation>(p => p.FromName != null);
        }
		
					public static Specification<Conversation> MessagesCountContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.MessagesCount));
        }
		public static Specification<Conversation> MessagesCountNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.MessagesCount));
        }
		public static Specification<Conversation> MessagesCountEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.MessagesCount));
        }
        public static Specification<Conversation> MessagesCountGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MessagesCount >= value);
        }
        public static Specification<Conversation> MessagesCountLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MessagesCount <= value);
        }
        public static Specification<Conversation> MessagesCountNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MessagesCount != value);
        }
        public static Specification<Conversation> MessagesCountGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.MessagesCount > value);
        }
        public static Specification<Conversation> MessagesCountLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.MessagesCount < value);
        }
		
					public static Specification<Conversation> NotReadMessagesCountContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.NotReadMessagesCount.Value));
        }
		public static Specification<Conversation> NotReadMessagesCountNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.NotReadMessagesCount.Value));
        }
		public static Specification<Conversation> NotReadMessagesCountEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.NotReadMessagesCount.Value));
        }
        public static Specification<Conversation> NotReadMessagesCountGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.NotReadMessagesCount >= value);
        }
        public static Specification<Conversation> NotReadMessagesCountLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.NotReadMessagesCount <= value);
        }
        public static Specification<Conversation> NotReadMessagesCountNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.NotReadMessagesCount != value);
        }
        public static Specification<Conversation> NotReadMessagesCountGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.NotReadMessagesCount > value);
        }
        public static Specification<Conversation> NotReadMessagesCountLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.NotReadMessagesCount < value);
        }
		
					public static Specification<Conversation> FromIdContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.FromId));
        }
		public static Specification<Conversation> FromIdNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.FromId));
        }
		public static Specification<Conversation> FromIdEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.FromId));
        }
        public static Specification<Conversation> FromIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.FromId >= value);
        }
        public static Specification<Conversation> FromIdLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.FromId <= value);
        }
        public static Specification<Conversation> FromIdNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.FromId != value);
        }
        public static Specification<Conversation> FromIdGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.FromId > value);
        }
        public static Specification<Conversation> FromIdLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.FromId < value);
        }
		
					public static Specification<Conversation> ToIdContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.ToId));
        }
		public static Specification<Conversation> ToIdNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.ToId));
        }
		public static Specification<Conversation> ToIdEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.ToId));
        }
        public static Specification<Conversation> ToIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.ToId >= value);
        }
        public static Specification<Conversation> ToIdLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.ToId <= value);
        }
        public static Specification<Conversation> ToIdNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.ToId != value);
        }
        public static Specification<Conversation> ToIdGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.ToId > value);
        }
        public static Specification<Conversation> ToIdLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.ToId < value);
        }
		
				
					public static Specification<Conversation> CurrentStepContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.CurrentStep));
        }
		public static Specification<Conversation> CurrentStepNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.CurrentStep));
        }
		public static Specification<Conversation> CurrentStepEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.CurrentStep));
        }
        public static Specification<Conversation> CurrentStepGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.CurrentStep >= value);
        }
        public static Specification<Conversation> CurrentStepLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.CurrentStep <= value);
        }
        public static Specification<Conversation> CurrentStepNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.CurrentStep != value);
        }
        public static Specification<Conversation> CurrentStepGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.CurrentStep > value);
        }
        public static Specification<Conversation> CurrentStepLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.CurrentStep < value);
        }
		
					public static Specification<Conversation> MaxStepsContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.MaxSteps.Value));
        }
		public static Specification<Conversation> MaxStepsNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.MaxSteps.Value));
        }
		public static Specification<Conversation> MaxStepsEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.MaxSteps.Value));
        }
        public static Specification<Conversation> MaxStepsGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MaxSteps >= value);
        }
        public static Specification<Conversation> MaxStepsLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MaxSteps <= value);
        }
        public static Specification<Conversation> MaxStepsNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.MaxSteps != value);
        }
        public static Specification<Conversation> MaxStepsGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.MaxSteps > value);
        }
        public static Specification<Conversation> MaxStepsLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.MaxSteps < value);
        }
		
					public static Specification<Conversation> RegisterDoneEqual(bool value) {
			return new DirectSpecification<Conversation>(p => p.RegisterDone == value);
		}
		public static Specification<Conversation> RegisterDoneIsNull() {
            return new DirectSpecification<Conversation>(p => p.RegisterDone == null);
        }
		public static Specification<Conversation> RegisterDoneIsNotNull() {
            return new DirectSpecification<Conversation>(p => p.RegisterDone != null);
        }
		
					public static Specification<Conversation> ActiveEqual(bool value) {
			return new DirectSpecification<Conversation>(p => p.Active == value);
		}
		public static Specification<Conversation> ActiveIsNull() {
            return new DirectSpecification<Conversation>(p => p.Active == null);
        }
		public static Specification<Conversation> ActiveIsNotNull() {
            return new DirectSpecification<Conversation>(p => p.Active != null);
        }
		
					public static Specification<Conversation> ExternalIdContains(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> ExternalIdNotContains(string value) {
			return new DirectSpecification<Conversation>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Conversation> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Conversation>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Conversation> ExternalIdEqual(string value) {
			return new DirectSpecification<Conversation>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Conversation> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Conversation>(p => p.ExternalId != value);
		}
		public static Specification<Conversation> ExternalIdIsNull() {
            return new DirectSpecification<Conversation>(p => p.ExternalId == null);
        }
		public static Specification<Conversation> ExternalIdIsNotNull() {
            return new DirectSpecification<Conversation>(p => p.ExternalId != null);
        }
		
					public static Specification<Conversation> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Conversation> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Conversation> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Conversation> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.CreatedAt >= value);
        }
        public static Specification<Conversation> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.CreatedAt <= value);
        }
        public static Specification<Conversation> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.CreatedAt != value);
        }
        public static Specification<Conversation> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.CreatedAt > value);
        }
        public static Specification<Conversation> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.CreatedAt < value);
        }
		
					public static Specification<Conversation> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Conversation> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Conversation> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Conversation> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.UpdatedAt >= value);
        }
        public static Specification<Conversation> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.UpdatedAt <= value);
        }
        public static Specification<Conversation> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.UpdatedAt != value);
        }
        public static Specification<Conversation> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.UpdatedAt > value);
        }
        public static Specification<Conversation> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Conversation> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Conversation> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Conversation> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Conversation> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.DeletedAt >= value);
        }
        public static Specification<Conversation> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.DeletedAt <= value);
        }
        public static Specification<Conversation> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.DeletedAt != value);
        }
        public static Specification<Conversation> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.DeletedAt > value);
        }
        public static Specification<Conversation> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Conversation>(p => p.DeletedAt < value);
        }
		
					public static Specification<Conversation> IdContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => values.Contains(p.Id));
        }
		public static Specification<Conversation> IdNotContains(params int[] values) {
            return new DirectSpecification<Conversation>(p => !values.Contains(p.Id));
        }
		public static Specification<Conversation> IdEqual(params int[] values) {
			return new DirectSpecification<Conversation>(p => values.Contains(p.Id));
        }
        public static Specification<Conversation> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.Id >= value);
        }
        public static Specification<Conversation> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.Id <= value);
        }
        public static Specification<Conversation> IdNotEqual(int value) {
            return new DirectSpecification<Conversation>(p => p.Id != value);
        }
        public static Specification<Conversation> IdGreaterThan(int value) {
            return new DirectSpecification<Conversation>(p => p.Id > value);
        }
        public static Specification<Conversation> IdLessThan(int value) {
            return new DirectSpecification<Conversation>(p => p.Id < value);
        }
		
					public static Specification<Conversation> IsDeletedEqual(bool value) {
			return new DirectSpecification<Conversation>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class ChatAggSettingsSpecifications {
				public static Specification<ChatAggSettings> UserIdContains(params int[] values) {
            return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.UserId));
        }
		public static Specification<ChatAggSettings> UserIdNotContains(params int[] values) {
            return new DirectSpecification<ChatAggSettings>(p => !values.Contains(p.UserId));
        }
		public static Specification<ChatAggSettings> UserIdEqual(params int[] values) {
			return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.UserId));
        }
        public static Specification<ChatAggSettings> UserIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UserId >= value);
        }
        public static Specification<ChatAggSettings> UserIdLessThanOrEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UserId <= value);
        }
        public static Specification<ChatAggSettings> UserIdNotEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UserId != value);
        }
        public static Specification<ChatAggSettings> UserIdGreaterThan(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UserId > value);
        }
        public static Specification<ChatAggSettings> UserIdLessThan(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UserId < value);
        }
		
					public static Specification<ChatAggSettings> AutoSaveSettingsEnabledEqual(bool value) {
			return new DirectSpecification<ChatAggSettings>(p => p.AutoSaveSettingsEnabled == value);
		}
		
					public static Specification<ChatAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<ChatAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ChatAggSettings> ExternalIdNotContains(string value) {
			return new DirectSpecification<ChatAggSettings>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ChatAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ChatAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ChatAggSettings> ExternalIdEqual(string value) {
			return new DirectSpecification<ChatAggSettings>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<ChatAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ChatAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<ChatAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<ChatAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<ChatAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<ChatAggSettings>(p => p.ExternalId != null);
        }
		
					public static Specification<ChatAggSettings> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<ChatAggSettings> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<ChatAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ChatAggSettings> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<ChatAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<ChatAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<ChatAggSettings> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<ChatAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.CreatedAt < value);
        }
		
					public static Specification<ChatAggSettings> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<ChatAggSettings> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<ChatAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ChatAggSettings> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<ChatAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<ChatAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<ChatAggSettings> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<ChatAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.UpdatedAt < value);
        }
		
					public static Specification<ChatAggSettings> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<ChatAggSettings> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ChatAggSettings>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<ChatAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ChatAggSettings> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<ChatAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<ChatAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<ChatAggSettings> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<ChatAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ChatAggSettings>(p => p.DeletedAt < value);
        }
		
					public static Specification<ChatAggSettings> IdContains(params int[] values) {
            return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.Id));
        }
		public static Specification<ChatAggSettings> IdNotContains(params int[] values) {
            return new DirectSpecification<ChatAggSettings>(p => !values.Contains(p.Id));
        }
		public static Specification<ChatAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<ChatAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<ChatAggSettings> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.Id >= value);
        }
        public static Specification<ChatAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.Id <= value);
        }
        public static Specification<ChatAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.Id != value);
        }
        public static Specification<ChatAggSettings> IdGreaterThan(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.Id > value);
        }
        public static Specification<ChatAggSettings> IdLessThan(int value) {
            return new DirectSpecification<ChatAggSettings>(p => p.Id < value);
        }
		
					public static Specification<ChatAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<ChatAggSettings>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class ConversationMessageSpecifications {
				public static Specification<ConversationMessage> TextContains(string value) {
			return new DirectSpecification<ConversationMessage>(p => EF.Functions.Like(p.Text.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConversationMessage> TextNotContains(string value) {
			return new DirectSpecification<ConversationMessage>(p => !EF.Functions.Like(p.Text.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConversationMessage> TextStartsWith(string value) {
			return new DirectSpecification<ConversationMessage>(p => EF.Functions.Like(p.Text.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConversationMessage> TextEqual(string value) {
			return new DirectSpecification<ConversationMessage>(p => value.ToLower() == (p.Text.ToLower()));
		}
		public static Specification<ConversationMessage> TextNotEqual(string value) {
			return new DirectSpecification<ConversationMessage>(p => p.Text != value);
		}
		public static Specification<ConversationMessage> TextIsNull() {
            return new DirectSpecification<ConversationMessage>(p => p.Text == null);
        }
		public static Specification<ConversationMessage> TextIsNotNull() {
            return new DirectSpecification<ConversationMessage>(p => p.Text != null);
        }
		
					public static Specification<ConversationMessage> StatusEqual(params Niu.Nutri.Chat.Enumerations.MessageStatus[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.Status));
		}
		public static Specification<ConversationMessage> StatusNotEqual(Niu.Nutri.Chat.Enumerations.MessageStatus value) {
			return new DirectSpecification<ConversationMessage>(p => p.Status != value);
		}
	
					public static Specification<ConversationMessage> ConversationIdContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.ConversationId));
        }
		public static Specification<ConversationMessage> ConversationIdNotContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.ConversationId));
        }
		public static Specification<ConversationMessage> ConversationIdEqual(params int[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.ConversationId));
        }
        public static Specification<ConversationMessage> ConversationIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.ConversationId >= value);
        }
        public static Specification<ConversationMessage> ConversationIdLessThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.ConversationId <= value);
        }
        public static Specification<ConversationMessage> ConversationIdNotEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.ConversationId != value);
        }
        public static Specification<ConversationMessage> ConversationIdGreaterThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.ConversationId > value);
        }
        public static Specification<ConversationMessage> ConversationIdLessThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.ConversationId < value);
        }
		
					public static Specification<ConversationMessage> FromIdContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.FromId));
        }
		public static Specification<ConversationMessage> FromIdNotContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.FromId));
        }
		public static Specification<ConversationMessage> FromIdEqual(params int[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.FromId));
        }
        public static Specification<ConversationMessage> FromIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.FromId >= value);
        }
        public static Specification<ConversationMessage> FromIdLessThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.FromId <= value);
        }
        public static Specification<ConversationMessage> FromIdNotEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.FromId != value);
        }
        public static Specification<ConversationMessage> FromIdGreaterThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.FromId > value);
        }
        public static Specification<ConversationMessage> FromIdLessThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.FromId < value);
        }
		
					public static Specification<ConversationMessage> ExternalIdContains(string value) {
			return new DirectSpecification<ConversationMessage>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConversationMessage> ExternalIdNotContains(string value) {
			return new DirectSpecification<ConversationMessage>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<ConversationMessage> ExternalIdStartsWith(string value) {
			return new DirectSpecification<ConversationMessage>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<ConversationMessage> ExternalIdEqual(string value) {
			return new DirectSpecification<ConversationMessage>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<ConversationMessage> ExternalIdNotEqual(string value) {
			return new DirectSpecification<ConversationMessage>(p => p.ExternalId != value);
		}
		public static Specification<ConversationMessage> ExternalIdIsNull() {
            return new DirectSpecification<ConversationMessage>(p => p.ExternalId == null);
        }
		public static Specification<ConversationMessage> ExternalIdIsNotNull() {
            return new DirectSpecification<ConversationMessage>(p => p.ExternalId != null);
        }
		
					public static Specification<ConversationMessage> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<ConversationMessage> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<ConversationMessage> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<ConversationMessage> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.CreatedAt >= value);
        }
        public static Specification<ConversationMessage> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.CreatedAt <= value);
        }
        public static Specification<ConversationMessage> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.CreatedAt != value);
        }
        public static Specification<ConversationMessage> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.CreatedAt > value);
        }
        public static Specification<ConversationMessage> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.CreatedAt < value);
        }
		
					public static Specification<ConversationMessage> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<ConversationMessage> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<ConversationMessage> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<ConversationMessage> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.UpdatedAt >= value);
        }
        public static Specification<ConversationMessage> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.UpdatedAt <= value);
        }
        public static Specification<ConversationMessage> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.UpdatedAt != value);
        }
        public static Specification<ConversationMessage> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.UpdatedAt > value);
        }
        public static Specification<ConversationMessage> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.UpdatedAt < value);
        }
		
					public static Specification<ConversationMessage> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<ConversationMessage> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<ConversationMessage> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<ConversationMessage> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.DeletedAt >= value);
        }
        public static Specification<ConversationMessage> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.DeletedAt <= value);
        }
        public static Specification<ConversationMessage> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.DeletedAt != value);
        }
        public static Specification<ConversationMessage> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.DeletedAt > value);
        }
        public static Specification<ConversationMessage> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<ConversationMessage>(p => p.DeletedAt < value);
        }
		
					public static Specification<ConversationMessage> IdContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => values.Contains(p.Id));
        }
		public static Specification<ConversationMessage> IdNotContains(params int[] values) {
            return new DirectSpecification<ConversationMessage>(p => !values.Contains(p.Id));
        }
		public static Specification<ConversationMessage> IdEqual(params int[] values) {
			return new DirectSpecification<ConversationMessage>(p => values.Contains(p.Id));
        }
        public static Specification<ConversationMessage> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.Id >= value);
        }
        public static Specification<ConversationMessage> IdLessThanOrEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.Id <= value);
        }
        public static Specification<ConversationMessage> IdNotEqual(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.Id != value);
        }
        public static Specification<ConversationMessage> IdGreaterThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.Id > value);
        }
        public static Specification<ConversationMessage> IdLessThan(int value) {
            return new DirectSpecification<ConversationMessage>(p => p.Id < value);
        }
		
					public static Specification<ConversationMessage> IsDeletedEqual(bool value) {
			return new DirectSpecification<ConversationMessage>(p => p.IsDeleted == value);
		}
		
	   }
}
