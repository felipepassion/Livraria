using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
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
}

