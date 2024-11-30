using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class ConversationFilters 
	{
	    public static Expression<Func<Conversation, bool>> GetFilters(this ConversationQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Conversation> GetFiltersSpecification(this ConversationQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Conversation> filter = new DirectSpecification<Conversation>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.FromAvatarEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromAvatarEqual(request.FromAvatarEqual);
					else
						filter &= ConversationSpecifications.FromAvatarEqual(request.FromAvatarEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromAvatarNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromAvatarNotEqual(request.FromAvatarNotEqual);
					else
						filter &= ConversationSpecifications.FromAvatarNotEqual(request.FromAvatarNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromAvatarNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromAvatarNotEqual(request.FromAvatarNotEqual);
					else
						filter &= ConversationSpecifications.FromAvatarNotEqual(request.FromAvatarNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromAvatarContains)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromAvatarContains(request.FromAvatarContains);
					else
						filter &= ConversationSpecifications.FromAvatarContains(request.FromAvatarContains);
				}
				if (!string.IsNullOrWhiteSpace(request.FromAvatarStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromAvatarStartsWith(request.FromAvatarStartsWith);
					else
						filter &= ConversationSpecifications.FromAvatarStartsWith(request.FromAvatarStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.FromNameEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromNameEqual(request.FromNameEqual);
					else
						filter &= ConversationSpecifications.FromNameEqual(request.FromNameEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromNameNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromNameNotEqual(request.FromNameNotEqual);
					else
						filter &= ConversationSpecifications.FromNameNotEqual(request.FromNameNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromNameNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromNameNotEqual(request.FromNameNotEqual);
					else
						filter &= ConversationSpecifications.FromNameNotEqual(request.FromNameNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.FromNameContains)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromNameContains(request.FromNameContains);
					else
						filter &= ConversationSpecifications.FromNameContains(request.FromNameContains);
				}
				if (!string.IsNullOrWhiteSpace(request.FromNameStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromNameStartsWith(request.FromNameStartsWith);
					else
						filter &= ConversationSpecifications.FromNameStartsWith(request.FromNameStartsWith);
				}
				if (request.MessagesCountEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountEqual(request.MessagesCountEqual.Value);
					else
						filter &= ConversationSpecifications.MessagesCountEqual(request.MessagesCountEqual.Value);
				}
				if (request.MessagesCountNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountNotEqual(request.MessagesCountNotEqual.Value);
					else
						filter &= ConversationSpecifications.MessagesCountNotEqual(request.MessagesCountNotEqual.Value);
				}
				if (request.MessagesCountContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountContains(request.MessagesCountContains);
					else
						filter &= ConversationSpecifications.MessagesCountContains(request.MessagesCountContains);
				}
				if (request.MessagesCountNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountNotContains(request.MessagesCountNotContains);
					else
						filter &= ConversationSpecifications.MessagesCountNotContains(request.MessagesCountNotContains);
				}
				if (request.MessagesCountSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountGreaterThanOrEqual(request.MessagesCountSince.Value);
					else
						filter &= ConversationSpecifications.MessagesCountGreaterThanOrEqual(request.MessagesCountSince.Value);
				}
				if (request.MessagesCountUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountLessThan(request.MessagesCountUntil.Value);
					else
						filter &= ConversationSpecifications.MessagesCountLessThan(request.MessagesCountUntil.Value);
				}
				if (request.MessagesCountNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountNotEqual(request.MessagesCountNotEqual.Value);
					else
						filter &= ConversationSpecifications.MessagesCountNotEqual(request.MessagesCountNotEqual.Value);
				}
				if (request.MessagesCountLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountLessThan(request.MessagesCountLessThan.Value);
					else
						filter &= ConversationSpecifications.MessagesCountLessThan(request.MessagesCountLessThan.Value);
				}
				if (request.MessagesCountGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountGreaterThan(request.MessagesCountGreaterThan.Value);
					else
						filter &= ConversationSpecifications.MessagesCountGreaterThan(request.MessagesCountGreaterThan.Value);
				}
				if (request.MessagesCountLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountLessThanOrEqual(request.MessagesCountLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.MessagesCountLessThanOrEqual(request.MessagesCountLessThanOrEqual.Value);
				}
				if (request.MessagesCountGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MessagesCountGreaterThanOrEqual(request.MessagesCountGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.MessagesCountGreaterThanOrEqual(request.MessagesCountGreaterThanOrEqual.Value);
				}
				if (request.NotReadMessagesCountEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountEqual(request.NotReadMessagesCountEqual.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountEqual(request.NotReadMessagesCountEqual.Value);
				}
				if (request.NotReadMessagesCountNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountNotEqual(request.NotReadMessagesCountNotEqual.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountNotEqual(request.NotReadMessagesCountNotEqual.Value);
				}
				if (request.NotReadMessagesCountContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountContains(request.NotReadMessagesCountContains);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountContains(request.NotReadMessagesCountContains);
				}
				if (request.NotReadMessagesCountNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountNotContains(request.NotReadMessagesCountNotContains);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountNotContains(request.NotReadMessagesCountNotContains);
				}
				if (request.NotReadMessagesCountSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountGreaterThanOrEqual(request.NotReadMessagesCountSince.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountGreaterThanOrEqual(request.NotReadMessagesCountSince.Value);
				}
				if (request.NotReadMessagesCountUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountLessThan(request.NotReadMessagesCountUntil.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountLessThan(request.NotReadMessagesCountUntil.Value);
				}
				if (request.NotReadMessagesCountNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountNotEqual(request.NotReadMessagesCountNotEqual.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountNotEqual(request.NotReadMessagesCountNotEqual.Value);
				}
				if (request.NotReadMessagesCountLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountLessThan(request.NotReadMessagesCountLessThan.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountLessThan(request.NotReadMessagesCountLessThan.Value);
				}
				if (request.NotReadMessagesCountGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountGreaterThan(request.NotReadMessagesCountGreaterThan.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountGreaterThan(request.NotReadMessagesCountGreaterThan.Value);
				}
				if (request.NotReadMessagesCountLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountLessThanOrEqual(request.NotReadMessagesCountLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountLessThanOrEqual(request.NotReadMessagesCountLessThanOrEqual.Value);
				}
				if (request.NotReadMessagesCountGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.NotReadMessagesCountGreaterThanOrEqual(request.NotReadMessagesCountGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.NotReadMessagesCountGreaterThanOrEqual(request.NotReadMessagesCountGreaterThanOrEqual.Value);
				}
				if (request.FromIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdEqual(request.FromIdEqual.Value);
					else
						filter &= ConversationSpecifications.FromIdEqual(request.FromIdEqual.Value);
				}
				if (request.FromIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
					else
						filter &= ConversationSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
				}
				if (request.FromIdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdContains(request.FromIdContains);
					else
						filter &= ConversationSpecifications.FromIdContains(request.FromIdContains);
				}
				if (request.FromIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdNotContains(request.FromIdNotContains);
					else
						filter &= ConversationSpecifications.FromIdNotContains(request.FromIdNotContains);
				}
				if (request.FromIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdGreaterThanOrEqual(request.FromIdSince.Value);
					else
						filter &= ConversationSpecifications.FromIdGreaterThanOrEqual(request.FromIdSince.Value);
				}
				if (request.FromIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdLessThan(request.FromIdUntil.Value);
					else
						filter &= ConversationSpecifications.FromIdLessThan(request.FromIdUntil.Value);
				}
				if (request.FromIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
					else
						filter &= ConversationSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
				}
				if (request.FromIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdLessThan(request.FromIdLessThan.Value);
					else
						filter &= ConversationSpecifications.FromIdLessThan(request.FromIdLessThan.Value);
				}
				if (request.FromIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdGreaterThan(request.FromIdGreaterThan.Value);
					else
						filter &= ConversationSpecifications.FromIdGreaterThan(request.FromIdGreaterThan.Value);
				}
				if (request.FromIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdLessThanOrEqual(request.FromIdLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.FromIdLessThanOrEqual(request.FromIdLessThanOrEqual.Value);
				}
				if (request.FromIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.FromIdGreaterThanOrEqual(request.FromIdGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.FromIdGreaterThanOrEqual(request.FromIdGreaterThanOrEqual.Value);
				}
				if (request.ToIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdEqual(request.ToIdEqual.Value);
					else
						filter &= ConversationSpecifications.ToIdEqual(request.ToIdEqual.Value);
				}
				if (request.ToIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdNotEqual(request.ToIdNotEqual.Value);
					else
						filter &= ConversationSpecifications.ToIdNotEqual(request.ToIdNotEqual.Value);
				}
				if (request.ToIdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdContains(request.ToIdContains);
					else
						filter &= ConversationSpecifications.ToIdContains(request.ToIdContains);
				}
				if (request.ToIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdNotContains(request.ToIdNotContains);
					else
						filter &= ConversationSpecifications.ToIdNotContains(request.ToIdNotContains);
				}
				if (request.ToIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdGreaterThanOrEqual(request.ToIdSince.Value);
					else
						filter &= ConversationSpecifications.ToIdGreaterThanOrEqual(request.ToIdSince.Value);
				}
				if (request.ToIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdLessThan(request.ToIdUntil.Value);
					else
						filter &= ConversationSpecifications.ToIdLessThan(request.ToIdUntil.Value);
				}
				if (request.ToIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdNotEqual(request.ToIdNotEqual.Value);
					else
						filter &= ConversationSpecifications.ToIdNotEqual(request.ToIdNotEqual.Value);
				}
				if (request.ToIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdLessThan(request.ToIdLessThan.Value);
					else
						filter &= ConversationSpecifications.ToIdLessThan(request.ToIdLessThan.Value);
				}
				if (request.ToIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdGreaterThan(request.ToIdGreaterThan.Value);
					else
						filter &= ConversationSpecifications.ToIdGreaterThan(request.ToIdGreaterThan.Value);
				}
				if (request.ToIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdLessThanOrEqual(request.ToIdLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.ToIdLessThanOrEqual(request.ToIdLessThanOrEqual.Value);
				}
				if (request.ToIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ToIdGreaterThanOrEqual(request.ToIdGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.ToIdGreaterThanOrEqual(request.ToIdGreaterThanOrEqual.Value);
				}
				if (request.CurrentStepEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
					else
						filter &= ConversationSpecifications.CurrentStepEqual(request.CurrentStepEqual.Value);
				}
				if (request.CurrentStepNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepNotEqual(request.CurrentStepNotEqual.Value);
					else
						filter &= ConversationSpecifications.CurrentStepNotEqual(request.CurrentStepNotEqual.Value);
				}
				if (request.CurrentStepContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepContains(request.CurrentStepContains);
					else
						filter &= ConversationSpecifications.CurrentStepContains(request.CurrentStepContains);
				}
				if (request.CurrentStepNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepNotContains(request.CurrentStepNotContains);
					else
						filter &= ConversationSpecifications.CurrentStepNotContains(request.CurrentStepNotContains);
				}
				if (request.CurrentStepSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepGreaterThanOrEqual(request.CurrentStepSince.Value);
					else
						filter &= ConversationSpecifications.CurrentStepGreaterThanOrEqual(request.CurrentStepSince.Value);
				}
				if (request.CurrentStepUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
					else
						filter &= ConversationSpecifications.CurrentStepLessThan(request.CurrentStepUntil.Value);
				}
				if (request.CurrentStepNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepNotEqual(request.CurrentStepNotEqual.Value);
					else
						filter &= ConversationSpecifications.CurrentStepNotEqual(request.CurrentStepNotEqual.Value);
				}
				if (request.CurrentStepLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepLessThan(request.CurrentStepLessThan.Value);
					else
						filter &= ConversationSpecifications.CurrentStepLessThan(request.CurrentStepLessThan.Value);
				}
				if (request.CurrentStepGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepGreaterThan(request.CurrentStepGreaterThan.Value);
					else
						filter &= ConversationSpecifications.CurrentStepGreaterThan(request.CurrentStepGreaterThan.Value);
				}
				if (request.CurrentStepLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepLessThanOrEqual(request.CurrentStepLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.CurrentStepLessThanOrEqual(request.CurrentStepLessThanOrEqual.Value);
				}
				if (request.CurrentStepGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CurrentStepGreaterThanOrEqual(request.CurrentStepGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.CurrentStepGreaterThanOrEqual(request.CurrentStepGreaterThanOrEqual.Value);
				}
				if (request.MaxStepsEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsEqual(request.MaxStepsEqual.Value);
					else
						filter &= ConversationSpecifications.MaxStepsEqual(request.MaxStepsEqual.Value);
				}
				if (request.MaxStepsNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsNotEqual(request.MaxStepsNotEqual.Value);
					else
						filter &= ConversationSpecifications.MaxStepsNotEqual(request.MaxStepsNotEqual.Value);
				}
				if (request.MaxStepsContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsContains(request.MaxStepsContains);
					else
						filter &= ConversationSpecifications.MaxStepsContains(request.MaxStepsContains);
				}
				if (request.MaxStepsNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsNotContains(request.MaxStepsNotContains);
					else
						filter &= ConversationSpecifications.MaxStepsNotContains(request.MaxStepsNotContains);
				}
				if (request.MaxStepsSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsGreaterThanOrEqual(request.MaxStepsSince.Value);
					else
						filter &= ConversationSpecifications.MaxStepsGreaterThanOrEqual(request.MaxStepsSince.Value);
				}
				if (request.MaxStepsUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsLessThan(request.MaxStepsUntil.Value);
					else
						filter &= ConversationSpecifications.MaxStepsLessThan(request.MaxStepsUntil.Value);
				}
				if (request.MaxStepsNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsNotEqual(request.MaxStepsNotEqual.Value);
					else
						filter &= ConversationSpecifications.MaxStepsNotEqual(request.MaxStepsNotEqual.Value);
				}
				if (request.MaxStepsLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsLessThan(request.MaxStepsLessThan.Value);
					else
						filter &= ConversationSpecifications.MaxStepsLessThan(request.MaxStepsLessThan.Value);
				}
				if (request.MaxStepsGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsGreaterThan(request.MaxStepsGreaterThan.Value);
					else
						filter &= ConversationSpecifications.MaxStepsGreaterThan(request.MaxStepsGreaterThan.Value);
				}
				if (request.MaxStepsLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsLessThanOrEqual(request.MaxStepsLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.MaxStepsLessThanOrEqual(request.MaxStepsLessThanOrEqual.Value);
				}
				if (request.MaxStepsGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.MaxStepsGreaterThanOrEqual(request.MaxStepsGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.MaxStepsGreaterThanOrEqual(request.MaxStepsGreaterThanOrEqual.Value);
				}
				if (request.RegisterDoneEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.RegisterDoneEqual(request.RegisterDoneEqual.Value);
					else
						filter &= ConversationSpecifications.RegisterDoneEqual(request.RegisterDoneEqual.Value);
				}
				if (request.ActiveEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ActiveEqual(request.ActiveEqual.Value);
					else
						filter &= ConversationSpecifications.ActiveEqual(request.ActiveEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ConversationSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConversationSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConversationSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ConversationSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ConversationSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ConversationSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= ConversationSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= ConversationSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ConversationSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ConversationSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= ConversationSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= ConversationSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= ConversationSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= ConversationSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ConversationSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= ConversationSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= ConversationSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ConversationSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ConversationSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ConversationSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= ConversationSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= ConversationSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ConversationSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= ConversationSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.IdContains(request.IdContains);
					else
						filter &= ConversationSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= ConversationSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ConversationSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class ChatAggSettingsFilters 
	{
	    public static Expression<Func<ChatAggSettings, bool>> GetFilters(this ChatAggSettingsQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<ChatAggSettings> GetFiltersSpecification(this ChatAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<ChatAggSettings> filter = new DirectSpecification<ChatAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.UserIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
				}
				if (request.UserIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= ChatAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (request.UserIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
					else
						filter &= ChatAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
				}
				if (request.UserIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
				}
				if (request.UserIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
				}
				if (request.UserIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
				}
				if (request.UserIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
				}
				if (request.UserIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
				}
				if (request.UserIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
				}
				if (request.AutoSaveSettingsEnabledEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ChatAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ChatAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ChatAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ChatAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ChatAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.IdContains(request.IdContains);
					else
						filter &= ChatAggSettingsSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= ChatAggSettingsSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ChatAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ChatAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class ConversationMessageFilters 
	{
	    public static Expression<Func<ConversationMessage, bool>> GetFilters(this ConversationMessageQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<ConversationMessage> GetFiltersSpecification(this ConversationMessageQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<ConversationMessage> filter = new DirectSpecification<ConversationMessage>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.TextEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.TextEqual(request.TextEqual);
					else
						filter &= ConversationMessageSpecifications.TextEqual(request.TextEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TextNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.TextNotEqual(request.TextNotEqual);
					else
						filter &= ConversationMessageSpecifications.TextNotEqual(request.TextNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TextNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.TextNotEqual(request.TextNotEqual);
					else
						filter &= ConversationMessageSpecifications.TextNotEqual(request.TextNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TextContains)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.TextContains(request.TextContains);
					else
						filter &= ConversationMessageSpecifications.TextContains(request.TextContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TextStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.TextStartsWith(request.TextStartsWith);
					else
						filter &= ConversationMessageSpecifications.TextStartsWith(request.TextStartsWith);
				}
				if (request.StatusEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.StatusEqual(request.StatusEqual.Value);
					else
						filter &= ConversationMessageSpecifications.StatusEqual(request.StatusEqual.Value);
				}
				if (request.ConversationIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdEqual(request.ConversationIdEqual.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdEqual(request.ConversationIdEqual.Value);
				}
				if (request.ConversationIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdNotEqual(request.ConversationIdNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdNotEqual(request.ConversationIdNotEqual.Value);
				}
				if (request.ConversationIdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdContains(request.ConversationIdContains);
					else
						filter &= ConversationMessageSpecifications.ConversationIdContains(request.ConversationIdContains);
				}
				if (request.ConversationIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdNotContains(request.ConversationIdNotContains);
					else
						filter &= ConversationMessageSpecifications.ConversationIdNotContains(request.ConversationIdNotContains);
				}
				if (request.ConversationIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdGreaterThanOrEqual(request.ConversationIdSince.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdGreaterThanOrEqual(request.ConversationIdSince.Value);
				}
				if (request.ConversationIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdLessThan(request.ConversationIdUntil.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdLessThan(request.ConversationIdUntil.Value);
				}
				if (request.ConversationIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdNotEqual(request.ConversationIdNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdNotEqual(request.ConversationIdNotEqual.Value);
				}
				if (request.ConversationIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdLessThan(request.ConversationIdLessThan.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdLessThan(request.ConversationIdLessThan.Value);
				}
				if (request.ConversationIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdGreaterThan(request.ConversationIdGreaterThan.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdGreaterThan(request.ConversationIdGreaterThan.Value);
				}
				if (request.ConversationIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdLessThanOrEqual(request.ConversationIdLessThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdLessThanOrEqual(request.ConversationIdLessThanOrEqual.Value);
				}
				if (request.ConversationIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ConversationIdGreaterThanOrEqual(request.ConversationIdGreaterThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.ConversationIdGreaterThanOrEqual(request.ConversationIdGreaterThanOrEqual.Value);
				}
				if (request.FromIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdEqual(request.FromIdEqual.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdEqual(request.FromIdEqual.Value);
				}
				if (request.FromIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
				}
				if (request.FromIdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdContains(request.FromIdContains);
					else
						filter &= ConversationMessageSpecifications.FromIdContains(request.FromIdContains);
				}
				if (request.FromIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdNotContains(request.FromIdNotContains);
					else
						filter &= ConversationMessageSpecifications.FromIdNotContains(request.FromIdNotContains);
				}
				if (request.FromIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdGreaterThanOrEqual(request.FromIdSince.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdGreaterThanOrEqual(request.FromIdSince.Value);
				}
				if (request.FromIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdLessThan(request.FromIdUntil.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdLessThan(request.FromIdUntil.Value);
				}
				if (request.FromIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdNotEqual(request.FromIdNotEqual.Value);
				}
				if (request.FromIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdLessThan(request.FromIdLessThan.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdLessThan(request.FromIdLessThan.Value);
				}
				if (request.FromIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdGreaterThan(request.FromIdGreaterThan.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdGreaterThan(request.FromIdGreaterThan.Value);
				}
				if (request.FromIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdLessThanOrEqual(request.FromIdLessThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdLessThanOrEqual(request.FromIdLessThanOrEqual.Value);
				}
				if (request.FromIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.FromIdGreaterThanOrEqual(request.FromIdGreaterThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.FromIdGreaterThanOrEqual(request.FromIdGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= ConversationMessageSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConversationMessageSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= ConversationMessageSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= ConversationMessageSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= ConversationMessageSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= ConversationMessageSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= ConversationMessageSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= ConversationMessageSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= ConversationMessageSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= ConversationMessageSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= ConversationMessageSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= ConversationMessageSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.IdContains(request.IdContains);
					else
						filter &= ConversationMessageSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= ConversationMessageSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= ConversationMessageSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= ConversationMessageSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
}

