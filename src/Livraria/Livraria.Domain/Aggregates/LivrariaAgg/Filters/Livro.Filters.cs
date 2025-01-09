
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Filters;

using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Entities;
using Specifications;
using Queries.Models;

	public static class LivroFilters 
	{
	    public static Expression<Func<Book, bool>> GetFilters(this LivroQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Book> GetFiltersSpecification(this LivroQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Book> filter = new DirectSpecification<Book>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
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
				if (request.EdicaoEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoEqual(request.EdicaoEqual.Value);
					else
						filter &= LivroSpecifications.EdicaoEqual(request.EdicaoEqual.Value);
				}
				if (request.EdicaoNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual.Value);
					else
						filter &= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual.Value);
				}
				if (request.EdicaoContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoContains(request.EdicaoContains);
					else
						filter &= LivroSpecifications.EdicaoContains(request.EdicaoContains);
				}
				if (request.EdicaoNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoNotContains(request.EdicaoNotContains);
					else
						filter &= LivroSpecifications.EdicaoNotContains(request.EdicaoNotContains);
				}
				if (request.EdicaoSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoGreaterThanOrEqual(request.EdicaoSince.Value);
					else
						filter &= LivroSpecifications.EdicaoGreaterThanOrEqual(request.EdicaoSince.Value);
				}
				if (request.EdicaoUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoLessThan(request.EdicaoUntil.Value);
					else
						filter &= LivroSpecifications.EdicaoLessThan(request.EdicaoUntil.Value);
				}
				if (request.EdicaoNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual.Value);
					else
						filter &= LivroSpecifications.EdicaoNotEqual(request.EdicaoNotEqual.Value);
				}
				if (request.EdicaoLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoLessThan(request.EdicaoLessThan.Value);
					else
						filter &= LivroSpecifications.EdicaoLessThan(request.EdicaoLessThan.Value);
				}
				if (request.EdicaoGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoGreaterThan(request.EdicaoGreaterThan.Value);
					else
						filter &= LivroSpecifications.EdicaoGreaterThan(request.EdicaoGreaterThan.Value);
				}
				if (request.EdicaoLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoLessThanOrEqual(request.EdicaoLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.EdicaoLessThanOrEqual(request.EdicaoLessThanOrEqual.Value);
				}
				if (request.EdicaoGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.EdicaoGreaterThanOrEqual(request.EdicaoGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.EdicaoGreaterThanOrEqual(request.EdicaoGreaterThanOrEqual.Value);
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
				if (!string.IsNullOrWhiteSpace(request.IdExternoEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdExternoEqual(request.IdExternoEqual);
					else
						filter &= LivroSpecifications.IdExternoEqual(request.IdExternoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= LivroSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
					else
						filter &= LivroSpecifications.IdExternoNotEqual(request.IdExternoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoContains)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdExternoContains(request.IdExternoContains);
					else
						filter &= LivroSpecifications.IdExternoContains(request.IdExternoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.IdExternoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
					else
						filter &= LivroSpecifications.IdExternoStartsWith(request.IdExternoStartsWith);
				}
				if (request.CriadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
					else
						filter &= LivroSpecifications.CriadoEmEqual(request.CriadoEmEqual.Value);
				}
				if (request.CriadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmContains(request.CriadoEmContains);
					else
						filter &= LivroSpecifications.CriadoEmContains(request.CriadoEmContains);
				}
				if (request.CriadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
					else
						filter &= LivroSpecifications.CriadoEmNotContains(request.CriadoEmNotContains);
				}
				if (request.CriadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
					else
						filter &= LivroSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmSince.Value);
				}
				if (request.CriadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
					else
						filter &= LivroSpecifications.CriadoEmLessThan(request.CriadoEmUntil.Value);
				}
				if (request.CriadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.CriadoEmNotEqual(request.CriadoEmNotEqual.Value);
				}
				if (request.CriadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
					else
						filter &= LivroSpecifications.CriadoEmLessThan(request.CriadoEmLessThan.Value);
				}
				if (request.CriadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
					else
						filter &= LivroSpecifications.CriadoEmGreaterThan(request.CriadoEmGreaterThan.Value);
				}
				if (request.CriadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.CriadoEmLessThanOrEqual(request.CriadoEmLessThanOrEqual.Value);
				}
				if (request.CriadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.CriadoEmGreaterThanOrEqual(request.CriadoEmGreaterThanOrEqual.Value);
				}
				if (request.AtualizadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmEqual(request.AtualizadoEmEqual.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
					else
						filter &= LivroSpecifications.AtualizadoEmContains(request.AtualizadoEmContains);
				}
				if (request.AtualizadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
					else
						filter &= LivroSpecifications.AtualizadoEmNotContains(request.AtualizadoEmNotContains);
				}
				if (request.AtualizadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmSince.Value);
				}
				if (request.AtualizadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmLessThan(request.AtualizadoEmUntil.Value);
				}
				if (request.AtualizadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmNotEqual(request.AtualizadoEmNotEqual.Value);
				}
				if (request.AtualizadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmLessThan(request.AtualizadoEmLessThan.Value);
				}
				if (request.AtualizadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmGreaterThan(request.AtualizadoEmGreaterThan.Value);
				}
				if (request.AtualizadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmLessThanOrEqual(request.AtualizadoEmLessThanOrEqual.Value);
				}
				if (request.AtualizadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.AtualizadoEmGreaterThanOrEqual(request.AtualizadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEmEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEmEqual(request.DeletadoEmEqual.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmContains(request.DeletadoEmContains);
					else
						filter &= LivroSpecifications.DeletadoEmContains(request.DeletadoEmContains);
				}
				if (request.DeletadoEmNotContains != null)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
					else
						filter &= LivroSpecifications.DeletadoEmNotContains(request.DeletadoEmNotContains);
				}
				if (request.DeletadoEmSince.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
					else
						filter &= LivroSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmSince.Value);
				}
				if (request.DeletadoEmUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
					else
						filter &= LivroSpecifications.DeletadoEmLessThan(request.DeletadoEmUntil.Value);
				}
				if (request.DeletadoEmNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEmNotEqual(request.DeletadoEmNotEqual.Value);
				}
				if (request.DeletadoEmLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
					else
						filter &= LivroSpecifications.DeletadoEmLessThan(request.DeletadoEmLessThan.Value);
				}
				if (request.DeletadoEmGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
					else
						filter &= LivroSpecifications.DeletadoEmGreaterThan(request.DeletadoEmGreaterThan.Value);
				}
				if (request.DeletadoEmLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEmLessThanOrEqual(request.DeletadoEmLessThanOrEqual.Value);
				}
				if (request.DeletadoEmGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEmGreaterThanOrEqual(request.DeletadoEmGreaterThanOrEqual.Value);
				}
				if (request.DeletadoEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= LivroSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
					else
						filter &= LivroSpecifications.DeletadoEqual(request.DeletadoEqual.Value);
				}
			}
			return filter;
		}
	}
