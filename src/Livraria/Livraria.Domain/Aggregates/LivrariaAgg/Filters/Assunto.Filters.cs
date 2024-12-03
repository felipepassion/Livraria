namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Filters;

using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Entities;
using Specifications;
using Queries.Models;

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
				if (!string.IsNullOrWhiteSpace(request.IdExternoEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdExternoEqual(request.IdExternoEqual);
					else
						filter &= AssuntoSpecifications.IdExternoEqual(request.IdExternoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= AssuntoSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= AssuntoSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoContains)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdExternoContains(request.IdExternoContains);
					else
						filter &= AssuntoSpecifications.IdExternoContains(request.IdExternoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
					else
						filter &= AssuntoSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
				}
				if (request.CriadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
				}
				if (request.CriadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmContains(request.CriadoEmContains);
					else
						filter &= AssuntoSpecifications.CriadoEmContains(request.CriadoEmContains);
				}
				if (request.CriadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
					else
						filter &= AssuntoSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
				}
				if (request.CriadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
				}
				if (request.CriadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
				}
				if (request.CriadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
				}
				if (request.CriadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
				}
				if (request.CriadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
				}
				if (request.CriadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
				}
				if (request.AtualizadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
					else
						filter &= AssuntoSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
				}
				if (request.AtualizadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
					else
						filter &= AssuntoSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
				}
				if (request.AtualizadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
				}
				if (request.AtualizadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
				}
				if (request.AtualizadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
				}
				if (request.AtualizadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
				}
				if (request.AtualizadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmContains(request.DeletadoEmContains);
					else
						filter &= AssuntoSpecifications.DeletadoEmContains(request.DeletadoEmContains);
				}
				if (request.DeletadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
					else
						filter &= AssuntoSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
				}
				if (request.DeletadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
				}
				if (request.DeletadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
				}
				if (request.DeletadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
				}
				if (request.DeletadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
				}
				if (request.DeletadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AssuntoSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
					else
						filter &= AssuntoSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
				}
			}
			return filter;
		}
	}
