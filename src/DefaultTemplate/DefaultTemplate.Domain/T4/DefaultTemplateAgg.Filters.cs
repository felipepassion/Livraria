using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.DefaultTemplate.Domain.Aggregates.DefaultTemplateAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class DefaultEntityFilters 
	{
	    public static Expression<Func<DefaultEntity, bool>> GetFilters(this DefaultEntityQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<DefaultEntity> GetFiltersSpecification(this DefaultEntityQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<DefaultEntity> filter = new DirectSpecification<DefaultEntity>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= DefaultEntitySpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= DefaultEntitySpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= DefaultEntitySpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= DefaultEntitySpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= DefaultEntitySpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CriadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
				}
				if (request.CriadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmContains(request.CriadoEmContains);
					else
						filter &= DefaultEntitySpecifications.CriadoEmContains(request.CriadoEmContains);
				}
				if (request.CriadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
					else
						filter &= DefaultEntitySpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
				}
				if (request.CriadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
				}
				if (request.CriadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
				}
				if (request.CriadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
				}
				if (request.CriadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
				}
				if (request.CriadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
				}
				if (request.CriadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
				}
				if (request.AtualizadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
				}
				if (request.AtualizadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
				}
				if (request.AtualizadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
				}
				if (request.AtualizadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
				}
				if (request.AtualizadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
				}
				if (request.AtualizadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
				}
				if (request.AtualizadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmContains(request.DeletadoEmContains);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmContains(request.DeletadoEmContains);
				}
				if (request.DeletadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
				}
				if (request.DeletadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
				}
				if (request.DeletadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
				}
				if (request.DeletadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
				}
				if (request.DeletadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
				}
				if (request.DeletadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= DefaultEntitySpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= DefaultEntitySpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.IdContains(request.IdContains);
					else
						filter &= DefaultEntitySpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= DefaultEntitySpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.DeletadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultEntitySpecifications.DeletadoEqual(request.DeletadoEqual.Value);
					else
						filter &= DefaultEntitySpecifications.DeletadoEqual(request.DeletadoEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class DefaultTemplateAggSettingsFilters 
	{
	    public static Expression<Func<DefaultTemplateAggSettings, bool>> GetFilters(this DefaultTemplateAggSettingsQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<DefaultTemplateAggSettings> GetFiltersSpecification(this DefaultTemplateAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<DefaultTemplateAggSettings> filter = new DirectSpecification<DefaultTemplateAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.UserIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
				}
				if (request.UserIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (request.UserIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
				}
				if (request.UserIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
				}
				if (request.UserIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
				}
				if (request.UserIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
				}
				if (request.UserIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
				}
				if (request.UserIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
				}
				if (request.UserIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
				}
				if (request.AutoSaveSettingsEnabledEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CriadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
				}
				if (request.CriadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmContains(request.CriadoEmContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmContains(request.CriadoEmContains);
				}
				if (request.CriadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
				}
				if (request.CriadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
				}
				if (request.CriadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
				}
				if (request.CriadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
				}
				if (request.CriadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
				}
				if (request.CriadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
				}
				if (request.CriadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
				}
				if (request.AtualizadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
				}
				if (request.AtualizadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
				}
				if (request.AtualizadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
				}
				if (request.AtualizadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
				}
				if (request.AtualizadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
				}
				if (request.AtualizadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
				}
				if (request.AtualizadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmContains(request.DeletadoEmContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmContains(request.DeletadoEmContains);
				}
				if (request.DeletadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
				}
				if (request.DeletadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
				}
				if (request.DeletadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
				}
				if (request.DeletadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
				}
				if (request.DeletadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
				}
				if (request.DeletadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.IdContains(request.IdContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.DeletadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= DefaultTemplateAggSettingsSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
					else
						filter &= DefaultTemplateAggSettingsSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
				}
			}
			return filter;
		}
	}
}

