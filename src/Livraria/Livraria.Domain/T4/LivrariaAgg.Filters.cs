using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class LivrariaAggSettingsFilters 
	{
	    public static Expression<Func<LivrariaAggSettings, bool>> GetFilters(this LivrariaAggSettingsQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<LivrariaAggSettings> GetFiltersSpecification(this LivrariaAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<LivrariaAggSettings> filter = new DirectSpecification<LivrariaAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.UserIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
				}
				if (request.UserIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (request.UserIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
				}
				if (request.UserIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
				}
				if (request.UserIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
				}
				if (request.UserIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
				}
				if (request.UserIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
				}
				if (request.UserIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
				}
				if (request.UserIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
				}
				if (request.AutoSaveSettingsEnabledEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= LivrariaAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= LivrariaAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= LivrariaAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= LivrariaAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= LivrariaAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.IdContains(request.IdContains);
					else
						filter &= LivrariaAggSettingsSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= LivrariaAggSettingsSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivrariaAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= LivrariaAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class Livro_AutorFilters 
	{
	    public static Expression<Func<Livro_Autor, bool>> GetFilters(this Livro_AutorQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Livro_Autor> GetFiltersSpecification(this Livro_AutorQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Livro_Autor> filter = new DirectSpecification<Livro_Autor>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.Livro_CodlEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlEqual(request.Livro_CodlEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlEqual(request.Livro_CodlEqual.Value);
				}
				if (request.Livro_CodlNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
				}
				if (request.Livro_CodlContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlContains(request.Livro_CodlContains);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlContains(request.Livro_CodlContains);
				}
				if (request.Livro_CodlNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlNotContains(request.Livro_CodlNotContains);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlNotContains(request.Livro_CodlNotContains);
				}
				if (request.Livro_CodlSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlSince.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlSince.Value);
				}
				if (request.Livro_CodlUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlLessThan(request.Livro_CodlUntil.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlLessThan(request.Livro_CodlUntil.Value);
				}
				if (request.Livro_CodlNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
				}
				if (request.Livro_CodlLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlLessThan(request.Livro_CodlLessThan.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlLessThan(request.Livro_CodlLessThan.Value);
				}
				if (request.Livro_CodlGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlGreaterThan(request.Livro_CodlGreaterThan.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlGreaterThan(request.Livro_CodlGreaterThan.Value);
				}
				if (request.Livro_CodlLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlLessThanOrEqual(request.Livro_CodlLessThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlLessThanOrEqual(request.Livro_CodlLessThanOrEqual.Value);
				}
				if (request.Livro_CodlGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlGreaterThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlGreaterThanOrEqual.Value);
				}
				if (request.Autor_CodAutEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutEqual(request.Autor_CodAutEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutEqual(request.Autor_CodAutEqual.Value);
				}
				if (request.Autor_CodAutNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutNotEqual(request.Autor_CodAutNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutNotEqual(request.Autor_CodAutNotEqual.Value);
				}
				if (request.Autor_CodAutContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutContains(request.Autor_CodAutContains);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutContains(request.Autor_CodAutContains);
				}
				if (request.Autor_CodAutNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutNotContains(request.Autor_CodAutNotContains);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutNotContains(request.Autor_CodAutNotContains);
				}
				if (request.Autor_CodAutSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutGreaterThanOrEqual(request.Autor_CodAutSince.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutGreaterThanOrEqual(request.Autor_CodAutSince.Value);
				}
				if (request.Autor_CodAutUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutLessThan(request.Autor_CodAutUntil.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutLessThan(request.Autor_CodAutUntil.Value);
				}
				if (request.Autor_CodAutNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutNotEqual(request.Autor_CodAutNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutNotEqual(request.Autor_CodAutNotEqual.Value);
				}
				if (request.Autor_CodAutLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutLessThan(request.Autor_CodAutLessThan.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutLessThan(request.Autor_CodAutLessThan.Value);
				}
				if (request.Autor_CodAutGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutGreaterThan(request.Autor_CodAutGreaterThan.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutGreaterThan(request.Autor_CodAutGreaterThan.Value);
				}
				if (request.Autor_CodAutLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutLessThanOrEqual(request.Autor_CodAutLessThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutLessThanOrEqual(request.Autor_CodAutLessThanOrEqual.Value);
				}
				if (request.Autor_CodAutGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.Autor_CodAutGreaterThanOrEqual(request.Autor_CodAutGreaterThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.Autor_CodAutGreaterThanOrEqual(request.Autor_CodAutGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= Livro_AutorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= Livro_AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= Livro_AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= Livro_AutorSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= Livro_AutorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= Livro_AutorSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= Livro_AutorSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= Livro_AutorSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= Livro_AutorSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= Livro_AutorSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= Livro_AutorSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.IdContains(request.IdContains);
					else
						filter &= Livro_AutorSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= Livro_AutorSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AutorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= Livro_AutorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class AutorFilters 
	{
	    public static Expression<Func<Autor, bool>> GetFilters(this AutorQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Autor> GetFiltersSpecification(this AutorQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Autor> filter = new DirectSpecification<Autor>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CodAuEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuEqual(request.CodAuEqual.Value);
					else
						filter &= AutorSpecifications.CodAuEqual(request.CodAuEqual.Value);
				}
				if (request.CodAuNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuNotEqual(request.CodAuNotEqual.Value);
					else
						filter &= AutorSpecifications.CodAuNotEqual(request.CodAuNotEqual.Value);
				}
				if (request.CodAuContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuContains(request.CodAuContains);
					else
						filter &= AutorSpecifications.CodAuContains(request.CodAuContains);
				}
				if (request.CodAuNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuNotContains(request.CodAuNotContains);
					else
						filter &= AutorSpecifications.CodAuNotContains(request.CodAuNotContains);
				}
				if (request.CodAuSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuGreaterThanOrEqual(request.CodAuSince.Value);
					else
						filter &= AutorSpecifications.CodAuGreaterThanOrEqual(request.CodAuSince.Value);
				}
				if (request.CodAuUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuLessThan(request.CodAuUntil.Value);
					else
						filter &= AutorSpecifications.CodAuLessThan(request.CodAuUntil.Value);
				}
				if (request.CodAuNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuNotEqual(request.CodAuNotEqual.Value);
					else
						filter &= AutorSpecifications.CodAuNotEqual(request.CodAuNotEqual.Value);
				}
				if (request.CodAuLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuLessThan(request.CodAuLessThan.Value);
					else
						filter &= AutorSpecifications.CodAuLessThan(request.CodAuLessThan.Value);
				}
				if (request.CodAuGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuGreaterThan(request.CodAuGreaterThan.Value);
					else
						filter &= AutorSpecifications.CodAuGreaterThan(request.CodAuGreaterThan.Value);
				}
				if (request.CodAuLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuLessThanOrEqual(request.CodAuLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CodAuLessThanOrEqual(request.CodAuLessThanOrEqual.Value);
				}
				if (request.CodAuGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CodAuGreaterThanOrEqual(request.CodAuGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CodAuGreaterThanOrEqual(request.CodAuGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.NomeEqual(request.NomeEqual);
					else
						filter &= AutorSpecifications.NomeEqual(request.NomeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= AutorSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.NomeNotEqual(request.NomeNotEqual);
					else
						filter &= AutorSpecifications.NomeNotEqual(request.NomeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeContains)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.NomeContains(request.NomeContains);
					else
						filter &= AutorSpecifications.NomeContains(request.NomeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.NomeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.NomeStartsWith(request.NomeStartsWith);
					else
						filter &= AutorSpecifications.NomeStartsWith(request.NomeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AutorSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AutorSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AutorSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AutorSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AutorSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= AutorSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= AutorSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AutorSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= AutorSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= AutorSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AutorSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= AutorSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= AutorSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= AutorSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= AutorSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AutorSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= AutorSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= AutorSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AutorSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AutorSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= AutorSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= AutorSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AutorSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= AutorSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdContains(request.IdContains);
					else
						filter &= AutorSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= AutorSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AutorSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class AssuntoFilters 
	{
	    public static Expression<Func<Assunto, bool>> GetFilters(this AssuntoQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Assunto> GetFiltersSpecification(this AssuntoQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Assunto> filter = new DirectSpecification<Assunto>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.CodAsEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsEqual(request.CodAsEqual.Value);
					else
						filter &= AssuntoSpecifications.CodAsEqual(request.CodAsEqual.Value);
				}
				if (request.CodAsNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsNotEqual(request.CodAsNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CodAsNotEqual(request.CodAsNotEqual.Value);
				}
				if (request.CodAsContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsContains(request.CodAsContains);
					else
						filter &= AssuntoSpecifications.CodAsContains(request.CodAsContains);
				}
				if (request.CodAsNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsNotContains(request.CodAsNotContains);
					else
						filter &= AssuntoSpecifications.CodAsNotContains(request.CodAsNotContains);
				}
				if (request.CodAsSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsGreaterThanOrEqual(request.CodAsSince.Value);
					else
						filter &= AssuntoSpecifications.CodAsGreaterThanOrEqual(request.CodAsSince.Value);
				}
				if (request.CodAsUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsLessThan(request.CodAsUntil.Value);
					else
						filter &= AssuntoSpecifications.CodAsLessThan(request.CodAsUntil.Value);
				}
				if (request.CodAsNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsNotEqual(request.CodAsNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CodAsNotEqual(request.CodAsNotEqual.Value);
				}
				if (request.CodAsLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsLessThan(request.CodAsLessThan.Value);
					else
						filter &= AssuntoSpecifications.CodAsLessThan(request.CodAsLessThan.Value);
				}
				if (request.CodAsGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsGreaterThan(request.CodAsGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.CodAsGreaterThan(request.CodAsGreaterThan.Value);
				}
				if (request.CodAsLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsLessThanOrEqual(request.CodAsLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CodAsLessThanOrEqual(request.CodAsLessThanOrEqual.Value);
				}
				if (request.CodAsGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CodAsGreaterThanOrEqual(request.CodAsGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CodAsGreaterThanOrEqual(request.CodAsGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DescricaoEqual(request.DescricaoEqual);
					else
						filter &= AssuntoSpecifications.DescricaoEqual(request.DescricaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
					else
						filter &= AssuntoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
					else
						filter &= AssuntoSpecifications.DescricaoNotEqual(request.DescricaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoContains)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DescricaoContains(request.DescricaoContains);
					else
						filter &= AssuntoSpecifications.DescricaoContains(request.DescricaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.DescricaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DescricaoStartsWith(request.DescricaoStartsWith);
					else
						filter &= AssuntoSpecifications.DescricaoStartsWith(request.DescricaoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AssuntoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AssuntoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AssuntoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= AssuntoSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= AssuntoSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= AssuntoSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= AssuntoSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= AssuntoSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= AssuntoSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AssuntoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= AssuntoSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdContains(request.IdContains);
					else
						filter &= AssuntoSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= AssuntoSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AssuntoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class Livro_AssuntoFilters 
	{
	    public static Expression<Func<Livro_Assunto, bool>> GetFilters(this Livro_AssuntoQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Livro_Assunto> GetFiltersSpecification(this Livro_AssuntoQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Livro_Assunto> filter = new DirectSpecification<Livro_Assunto>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.Livro_CodlEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlEqual(request.Livro_CodlEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlEqual(request.Livro_CodlEqual.Value);
				}
				if (request.Livro_CodlNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
				}
				if (request.Livro_CodlContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlContains(request.Livro_CodlContains);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlContains(request.Livro_CodlContains);
				}
				if (request.Livro_CodlNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlNotContains(request.Livro_CodlNotContains);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlNotContains(request.Livro_CodlNotContains);
				}
				if (request.Livro_CodlSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlSince.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlSince.Value);
				}
				if (request.Livro_CodlUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlLessThan(request.Livro_CodlUntil.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlLessThan(request.Livro_CodlUntil.Value);
				}
				if (request.Livro_CodlNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlNotEqual(request.Livro_CodlNotEqual.Value);
				}
				if (request.Livro_CodlLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlLessThan(request.Livro_CodlLessThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlLessThan(request.Livro_CodlLessThan.Value);
				}
				if (request.Livro_CodlGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlGreaterThan(request.Livro_CodlGreaterThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlGreaterThan(request.Livro_CodlGreaterThan.Value);
				}
				if (request.Livro_CodlLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlLessThanOrEqual(request.Livro_CodlLessThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlLessThanOrEqual(request.Livro_CodlLessThanOrEqual.Value);
				}
				if (request.Livro_CodlGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlGreaterThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Livro_CodlGreaterThanOrEqual(request.Livro_CodlGreaterThanOrEqual.Value);
				}
				if (request.Assunto_CodAutEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutEqual(request.Assunto_CodAutEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutEqual(request.Assunto_CodAutEqual.Value);
				}
				if (request.Assunto_CodAutNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutNotEqual(request.Assunto_CodAutNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutNotEqual(request.Assunto_CodAutNotEqual.Value);
				}
				if (request.Assunto_CodAutContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutContains(request.Assunto_CodAutContains);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutContains(request.Assunto_CodAutContains);
				}
				if (request.Assunto_CodAutNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutNotContains(request.Assunto_CodAutNotContains);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutNotContains(request.Assunto_CodAutNotContains);
				}
				if (request.Assunto_CodAutSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThanOrEqual(request.Assunto_CodAutSince.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThanOrEqual(request.Assunto_CodAutSince.Value);
				}
				if (request.Assunto_CodAutUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutLessThan(request.Assunto_CodAutUntil.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutLessThan(request.Assunto_CodAutUntil.Value);
				}
				if (request.Assunto_CodAutNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutNotEqual(request.Assunto_CodAutNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutNotEqual(request.Assunto_CodAutNotEqual.Value);
				}
				if (request.Assunto_CodAutLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutLessThan(request.Assunto_CodAutLessThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutLessThan(request.Assunto_CodAutLessThan.Value);
				}
				if (request.Assunto_CodAutGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThan(request.Assunto_CodAutGreaterThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThan(request.Assunto_CodAutGreaterThan.Value);
				}
				if (request.Assunto_CodAutLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutLessThanOrEqual(request.Assunto_CodAutLessThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutLessThanOrEqual(request.Assunto_CodAutLessThanOrEqual.Value);
				}
				if (request.Assunto_CodAutGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThanOrEqual(request.Assunto_CodAutGreaterThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.Assunto_CodAutGreaterThanOrEqual(request.Assunto_CodAutGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= Livro_AssuntoSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= Livro_AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= Livro_AssuntoSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= Livro_AssuntoSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= Livro_AssuntoSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.IdContains(request.IdContains);
					else
						filter &= Livro_AssuntoSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= Livro_AssuntoSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= Livro_AssuntoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= Livro_AssuntoSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class LivroFilters 
	{
	    public static Expression<Func<Livro, bool>> GetFilters(this LivroQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Livro> GetFiltersSpecification(this LivroQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Livro> filter = new DirectSpecification<Livro>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.TituloEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.TituloEqual(request.TituloEqual);
					else
						filter &= LivroSpecifications.TituloEqual(request.TituloEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TituloNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.TituloNotEqual(request.TituloNotEqual);
					else
						filter &= LivroSpecifications.TituloNotEqual(request.TituloNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TituloNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.TituloNotEqual(request.TituloNotEqual);
					else
						filter &= LivroSpecifications.TituloNotEqual(request.TituloNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TituloContains)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.TituloContains(request.TituloContains);
					else
						filter &= LivroSpecifications.TituloContains(request.TituloContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TituloStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.TituloStartsWith(request.TituloStartsWith);
					else
						filter &= LivroSpecifications.TituloStartsWith(request.TituloStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.EditoraEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EditoraEqual(request.EditoraEqual);
					else
						filter &= LivroSpecifications.EditoraEqual(request.EditoraEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EditoraNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EditoraNotEqual(request.EditoraNotEqual);
					else
						filter &= LivroSpecifications.EditoraNotEqual(request.EditoraNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EditoraNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EditoraNotEqual(request.EditoraNotEqual);
					else
						filter &= LivroSpecifications.EditoraNotEqual(request.EditoraNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EditoraContains)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EditoraContains(request.EditoraContains);
					else
						filter &= LivroSpecifications.EditoraContains(request.EditoraContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EditoraStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EditoraStartsWith(request.EditoraStartsWith);
					else
						filter &= LivroSpecifications.EditoraStartsWith(request.EditoraStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.EdicaoEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoEqual(request.EdicaoEqual);
					else
						filter &= LivroSpecifications.EdicaoEqual(request.EdicaoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EdicaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual);
					else
						filter &= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EdicaoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual);
					else
						filter &= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.EdicaoContains)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoContains(request.EdicaoContains);
					else
						filter &= LivroSpecifications.EdicaoContains(request.EdicaoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.EdicaoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoStartsWith(request.EdicaoStartsWith);
					else
						filter &= LivroSpecifications.EdicaoStartsWith(request.EdicaoStartsWith);
				}
				if (request.AnoPublicacaoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoEqual(request.AnoPublicacaoEqual.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoEqual(request.AnoPublicacaoEqual.Value);
				}
				if (request.AnoPublicacaoNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoNotEqual(request.AnoPublicacaoNotEqual.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoNotEqual(request.AnoPublicacaoNotEqual.Value);
				}
				if (request.AnoPublicacaoContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoContains(request.AnoPublicacaoContains);
					else
						filter &= LivroSpecifications.AnoPublicacaoContains(request.AnoPublicacaoContains);
				}
				if (request.AnoPublicacaoNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoNotContains(request.AnoPublicacaoNotContains);
					else
						filter &= LivroSpecifications.AnoPublicacaoNotContains(request.AnoPublicacaoNotContains);
				}
				if (request.AnoPublicacaoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoGreaterThanOrEqual(request.AnoPublicacaoSince.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoGreaterThanOrEqual(request.AnoPublicacaoSince.Value);
				}
				if (request.AnoPublicacaoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoLessThan(request.AnoPublicacaoUntil.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoLessThan(request.AnoPublicacaoUntil.Value);
				}
				if (request.AnoPublicacaoNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoNotEqual(request.AnoPublicacaoNotEqual.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoNotEqual(request.AnoPublicacaoNotEqual.Value);
				}
				if (request.AnoPublicacaoLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoLessThan(request.AnoPublicacaoLessThan.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoLessThan(request.AnoPublicacaoLessThan.Value);
				}
				if (request.AnoPublicacaoGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoGreaterThan(request.AnoPublicacaoGreaterThan.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoGreaterThan(request.AnoPublicacaoGreaterThan.Value);
				}
				if (request.AnoPublicacaoLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoLessThanOrEqual(request.AnoPublicacaoLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoLessThanOrEqual(request.AnoPublicacaoLessThanOrEqual.Value);
				}
				if (request.AnoPublicacaoGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AnoPublicacaoGreaterThanOrEqual(request.AnoPublicacaoGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.AnoPublicacaoGreaterThanOrEqual(request.AnoPublicacaoGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= LivroSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= LivroSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= LivroSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= LivroSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= LivroSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= LivroSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= LivroSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= LivroSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= LivroSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= LivroSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= LivroSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= LivroSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= LivroSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= LivroSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= LivroSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= LivroSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= LivroSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= LivroSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= LivroSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= LivroSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= LivroSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= LivroSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= LivroSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= LivroSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= LivroSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= LivroSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= LivroSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= LivroSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= LivroSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdContains(request.IdContains);
					else
						filter &= LivroSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= LivroSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= LivroSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
}

