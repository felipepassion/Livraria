namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Filters;

using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Entities;
using Specifications;
using Queries.Models;

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
				if (!string.IsNullOrWhiteSpace(request.IdExternoEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdExternoEqual(request.IdExternoEqual);
					else
						filter &= AutorSpecifications.IdExternoEqual(request.IdExternoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= AutorSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= AutorSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoContains)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdExternoContains(request.IdExternoContains);
					else
						filter &= AutorSpecifications.IdExternoContains(request.IdExternoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
					else
						filter &= AutorSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
				}
				if (request.CriadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
					else
						filter &= AutorSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
				}
				if (request.CriadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmContains(request.CriadoEmContains);
					else
						filter &= AutorSpecifications.CriadoEmContains(request.CriadoEmContains);
				}
				if (request.CriadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
					else
						filter &= AutorSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
				}
				if (request.CriadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
					else
						filter &= AutorSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
				}
				if (request.CriadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
					else
						filter &= AutorSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
				}
				if (request.CriadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
					else
						filter &= AutorSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
				}
				if (request.CriadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
					else
						filter &= AutorSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
				}
				if (request.CriadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
				}
				if (request.CriadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
				}
				if (request.AtualizadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
					else
						filter &= AutorSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
				}
				if (request.AtualizadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
					else
						filter &= AutorSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
				}
				if (request.AtualizadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
				}
				if (request.AtualizadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
				}
				if (request.AtualizadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
				}
				if (request.AtualizadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
				}
				if (request.AtualizadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmContains(request.DeletadoEmContains);
					else
						filter &= AutorSpecifications.DeletadoEmContains(request.DeletadoEmContains);
				}
				if (request.DeletadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
					else
						filter &= AutorSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
				}
				if (request.DeletadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
					else
						filter &= AutorSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
				}
				if (request.DeletadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
					else
						filter &= AutorSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
					else
						filter &= AutorSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
				}
				if (request.DeletadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
					else
						filter &= AutorSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
				}
				if (request.DeletadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
				}
				if (request.DeletadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AutorSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
					else
						filter &= AutorSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
				}
			}
			return filter;
		}
	}
