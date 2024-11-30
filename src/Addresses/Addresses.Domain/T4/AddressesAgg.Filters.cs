using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Filters{
	using Entities;
	using Specifications;
	using Queries.Models;
	public static class AddressFilters 
	{
	    public static Expression<Func<Address, bool>> GetFilters(this AddressQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<Address> GetFiltersSpecification(this AddressQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<Address> filter = new DirectSpecification<Address>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (!string.IsNullOrWhiteSpace(request.CEPEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CEPEqual(request.CEPEqual);
					else
						filter &= AddressSpecifications.CEPEqual(request.CEPEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CEPNotEqual(request.CEPNotEqual);
					else
						filter &= AddressSpecifications.CEPNotEqual(request.CEPNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CEPNotEqual(request.CEPNotEqual);
					else
						filter &= AddressSpecifications.CEPNotEqual(request.CEPNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CEPContains(request.CEPContains);
					else
						filter &= AddressSpecifications.CEPContains(request.CEPContains);
				}
				if (!string.IsNullOrWhiteSpace(request.CEPStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CEPStartsWith(request.CEPStartsWith);
					else
						filter &= AddressSpecifications.CEPStartsWith(request.CEPStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LogradouroEqual(request.LogradouroEqual);
					else
						filter &= AddressSpecifications.LogradouroEqual(request.LogradouroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
					else
						filter &= AddressSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
					else
						filter &= AddressSpecifications.LogradouroNotEqual(request.LogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LogradouroContains(request.LogradouroContains);
					else
						filter &= AddressSpecifications.LogradouroContains(request.LogradouroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.LogradouroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LogradouroStartsWith(request.LogradouroStartsWith);
					else
						filter &= AddressSpecifications.LogradouroStartsWith(request.LogradouroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.TipoLogradouroEqual(request.TipoLogradouroEqual);
					else
						filter &= AddressSpecifications.TipoLogradouroEqual(request.TipoLogradouroEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
					else
						filter &= AddressSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
					else
						filter &= AddressSpecifications.TipoLogradouroNotEqual(request.TipoLogradouroNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.TipoLogradouroContains(request.TipoLogradouroContains);
					else
						filter &= AddressSpecifications.TipoLogradouroContains(request.TipoLogradouroContains);
				}
				if (!string.IsNullOrWhiteSpace(request.TipoLogradouroStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.TipoLogradouroStartsWith(request.TipoLogradouroStartsWith);
					else
						filter &= AddressSpecifications.TipoLogradouroStartsWith(request.TipoLogradouroStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Bairro_DistritoEqual(request.Bairro_DistritoEqual);
					else
						filter &= AddressSpecifications.Bairro_DistritoEqual(request.Bairro_DistritoEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
					else
						filter &= AddressSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
					else
						filter &= AddressSpecifications.Bairro_DistritoNotEqual(request.Bairro_DistritoNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Bairro_DistritoContains(request.Bairro_DistritoContains);
					else
						filter &= AddressSpecifications.Bairro_DistritoContains(request.Bairro_DistritoContains);
				}
				if (!string.IsNullOrWhiteSpace(request.Bairro_DistritoStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Bairro_DistritoStartsWith(request.Bairro_DistritoStartsWith);
					else
						filter &= AddressSpecifications.Bairro_DistritoStartsWith(request.Bairro_DistritoStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Cidade_LocalidadeEqual(request.Cidade_LocalidadeEqual);
					else
						filter &= AddressSpecifications.Cidade_LocalidadeEqual(request.Cidade_LocalidadeEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
					else
						filter &= AddressSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
					else
						filter &= AddressSpecifications.Cidade_LocalidadeNotEqual(request.Cidade_LocalidadeNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Cidade_LocalidadeContains(request.Cidade_LocalidadeContains);
					else
						filter &= AddressSpecifications.Cidade_LocalidadeContains(request.Cidade_LocalidadeContains);
				}
				if (!string.IsNullOrWhiteSpace(request.Cidade_LocalidadeStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.Cidade_LocalidadeStartsWith(request.Cidade_LocalidadeStartsWith);
					else
						filter &= AddressSpecifications.Cidade_LocalidadeStartsWith(request.Cidade_LocalidadeStartsWith);
				}
				if (!string.IsNullOrWhiteSpace(request.UFEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UFEqual(request.UFEqual);
					else
						filter &= AddressSpecifications.UFEqual(request.UFEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UFNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UFNotEqual(request.UFNotEqual);
					else
						filter &= AddressSpecifications.UFNotEqual(request.UFNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UFNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UFNotEqual(request.UFNotEqual);
					else
						filter &= AddressSpecifications.UFNotEqual(request.UFNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.UFContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UFContains(request.UFContains);
					else
						filter &= AddressSpecifications.UFContains(request.UFContains);
				}
				if (!string.IsNullOrWhiteSpace(request.UFStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UFStartsWith(request.UFStartsWith);
					else
						filter &= AddressSpecifications.UFStartsWith(request.UFStartsWith);
				}
				if (request.LatEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatEqual(request.LatEqual.Value);
					else
						filter &= AddressSpecifications.LatEqual(request.LatEqual.Value);
				}
				if (request.LatNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatNotEqual(request.LatNotEqual.Value);
					else
						filter &= AddressSpecifications.LatNotEqual(request.LatNotEqual.Value);
				}
				if (request.LatContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatContains(request.LatContains);
					else
						filter &= AddressSpecifications.LatContains(request.LatContains);
				}
				if (request.LatNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatNotContains(request.LatNotContains);
					else
						filter &= AddressSpecifications.LatNotContains(request.LatNotContains);
				}
				if (request.LatSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatGreaterThanOrEqual(request.LatSince.Value);
					else
						filter &= AddressSpecifications.LatGreaterThanOrEqual(request.LatSince.Value);
				}
				if (request.LatUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatLessThan(request.LatUntil.Value);
					else
						filter &= AddressSpecifications.LatLessThan(request.LatUntil.Value);
				}
				if (request.LatNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatNotEqual(request.LatNotEqual.Value);
					else
						filter &= AddressSpecifications.LatNotEqual(request.LatNotEqual.Value);
				}
				if (request.LatLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatLessThan(request.LatLessThan.Value);
					else
						filter &= AddressSpecifications.LatLessThan(request.LatLessThan.Value);
				}
				if (request.LatGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatGreaterThan(request.LatGreaterThan.Value);
					else
						filter &= AddressSpecifications.LatGreaterThan(request.LatGreaterThan.Value);
				}
				if (request.LatLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatLessThanOrEqual(request.LatLessThanOrEqual.Value);
					else
						filter &= AddressSpecifications.LatLessThanOrEqual(request.LatLessThanOrEqual.Value);
				}
				if (request.LatGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LatGreaterThanOrEqual(request.LatGreaterThanOrEqual.Value);
					else
						filter &= AddressSpecifications.LatGreaterThanOrEqual(request.LatGreaterThanOrEqual.Value);
				}
				if (request.LngEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngEqual(request.LngEqual.Value);
					else
						filter &= AddressSpecifications.LngEqual(request.LngEqual.Value);
				}
				if (request.LngNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngNotEqual(request.LngNotEqual.Value);
					else
						filter &= AddressSpecifications.LngNotEqual(request.LngNotEqual.Value);
				}
				if (request.LngContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngContains(request.LngContains);
					else
						filter &= AddressSpecifications.LngContains(request.LngContains);
				}
				if (request.LngNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngNotContains(request.LngNotContains);
					else
						filter &= AddressSpecifications.LngNotContains(request.LngNotContains);
				}
				if (request.LngSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngGreaterThanOrEqual(request.LngSince.Value);
					else
						filter &= AddressSpecifications.LngGreaterThanOrEqual(request.LngSince.Value);
				}
				if (request.LngUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngLessThan(request.LngUntil.Value);
					else
						filter &= AddressSpecifications.LngLessThan(request.LngUntil.Value);
				}
				if (request.LngNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngNotEqual(request.LngNotEqual.Value);
					else
						filter &= AddressSpecifications.LngNotEqual(request.LngNotEqual.Value);
				}
				if (request.LngLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngLessThan(request.LngLessThan.Value);
					else
						filter &= AddressSpecifications.LngLessThan(request.LngLessThan.Value);
				}
				if (request.LngGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngGreaterThan(request.LngGreaterThan.Value);
					else
						filter &= AddressSpecifications.LngGreaterThan(request.LngGreaterThan.Value);
				}
				if (request.LngLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngLessThanOrEqual(request.LngLessThanOrEqual.Value);
					else
						filter &= AddressSpecifications.LngLessThanOrEqual(request.LngLessThanOrEqual.Value);
				}
				if (request.LngGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.LngGreaterThanOrEqual(request.LngGreaterThanOrEqual.Value);
					else
						filter &= AddressSpecifications.LngGreaterThanOrEqual(request.LngGreaterThanOrEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AddressSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AddressSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AddressSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AddressSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AddressSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AddressSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= AddressSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= AddressSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AddressSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AddressSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= AddressSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= AddressSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= AddressSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AddressSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= AddressSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= AddressSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AddressSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AddressSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= AddressSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= AddressSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= AddressSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AddressSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= AddressSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= AddressSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AddressSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AddressSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AddressSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= AddressSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= AddressSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= AddressSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AddressSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= AddressSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.IdContains(request.IdContains);
					else
						filter &= AddressSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= AddressSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AddressSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
	public static class AddressesAggSettingsFilters 
	{
	    public static Expression<Func<AddressesAggSettings, bool>> GetFilters(this AddressesAggSettingsQueryModel request, bool isOrSpecification = false)

		{ return request.GetFiltersSpecification(isOrSpecification).SatisfiedBy(); }
		public static Specification<AddressesAggSettings> GetFiltersSpecification(this AddressesAggSettingsQueryModel request, bool isOrSpecification = false) 
		{
			isOrSpecification = request.IsOrSpecification;
			Specification<AddressesAggSettings> filter = new DirectSpecification<AddressesAggSettings>(p => request.IsEmpty() || !isOrSpecification);
			if(request is not null)
			{
				if (request.UserIdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdEqual(request.UserIdEqual.Value);
				}
				if (request.UserIdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdContains(request.UserIdContains);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdContains(request.UserIdContains);
				}
				if (request.UserIdNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdNotContains(request.UserIdNotContains);
				}
				if (request.UserIdSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdSince.Value);
				}
				if (request.UserIdUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdLessThan(request.UserIdUntil.Value);
				}
				if (request.UserIdNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdNotEqual(request.UserIdNotEqual.Value);
				}
				if (request.UserIdLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdLessThan(request.UserIdLessThan.Value);
				}
				if (request.UserIdGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdGreaterThan(request.UserIdGreaterThan.Value);
				}
				if (request.UserIdLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdLessThanOrEqual(request.UserIdLessThanOrEqual.Value);
				}
				if (request.UserIdGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UserIdGreaterThanOrEqual(request.UserIdGreaterThanOrEqual.Value);
				}
				if (request.AutoSaveSettingsEnabledEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.AutoSaveSettingsEnabledEqual(request.AutoSaveSettingsEnabledEqual.Value);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdEqual(request.ExternalIdEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdNotEqual)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdNotEqual(request.ExternalIdNotEqual);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdContains)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdContains(request.ExternalIdContains);
				}
				if (!string.IsNullOrWhiteSpace(request.ExternalIdStartsWith)) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
					else
						filter &= AddressesAggSettingsSpecifications.ExternalIdStartsWith(request.ExternalIdStartsWith);
				}
				if (request.CreatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtEqual(request.CreatedAtEqual.Value);
				}
				if (request.CreatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtContains(request.CreatedAtContains);
				}
				if (request.CreatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtNotContains(request.CreatedAtNotContains);
				}
				if (request.CreatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtSince.Value);
				}
				if (request.CreatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtUntil.Value);
				}
				if (request.CreatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtNotEqual(request.CreatedAtNotEqual.Value);
				}
				if (request.CreatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtLessThan(request.CreatedAtLessThan.Value);
				}
				if (request.CreatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtGreaterThan(request.CreatedAtGreaterThan.Value);
				}
				if (request.CreatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtLessThanOrEqual(request.CreatedAtLessThanOrEqual.Value);
				}
				if (request.CreatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.CreatedAtGreaterThanOrEqual(request.CreatedAtGreaterThanOrEqual.Value);
				}
				if (request.UpdatedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtEqual(request.UpdatedAtEqual.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtContains(request.UpdatedAtContains);
				}
				if (request.UpdatedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtNotContains(request.UpdatedAtNotContains);
				}
				if (request.UpdatedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtSince.Value);
				}
				if (request.UpdatedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtUntil.Value);
				}
				if (request.UpdatedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtNotEqual(request.UpdatedAtNotEqual.Value);
				}
				if (request.UpdatedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtLessThan(request.UpdatedAtLessThan.Value);
				}
				if (request.UpdatedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtGreaterThan(request.UpdatedAtGreaterThan.Value);
				}
				if (request.UpdatedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtLessThanOrEqual(request.UpdatedAtLessThanOrEqual.Value);
				}
				if (request.UpdatedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.UpdatedAtGreaterThanOrEqual(request.UpdatedAtGreaterThanOrEqual.Value);
				}
				if (request.DeletedAtEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtEqual(request.DeletedAtEqual.Value);
				}
				if (request.DeletedAtNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtContains(request.DeletedAtContains);
				}
				if (request.DeletedAtNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtNotContains(request.DeletedAtNotContains);
				}
				if (request.DeletedAtSince.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtSince.Value);
				}
				if (request.DeletedAtUntil.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtUntil.Value);
				}
				if (request.DeletedAtNotEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtNotEqual(request.DeletedAtNotEqual.Value);
				}
				if (request.DeletedAtLessThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtLessThan(request.DeletedAtLessThan.Value);
				}
				if (request.DeletedAtGreaterThan.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtGreaterThan(request.DeletedAtGreaterThan.Value);
				}
				if (request.DeletedAtLessThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtLessThanOrEqual(request.DeletedAtLessThanOrEqual.Value);
				}
				if (request.DeletedAtGreaterThanOrEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.DeletedAtGreaterThanOrEqual(request.DeletedAtGreaterThanOrEqual.Value);
				}
				if (request.IdEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.IdEqual(request.IdEqual.Value);
				}
				if (request.IdNotEqual.HasValue)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.IdNotEqual(request.IdNotEqual.Value);
				}
				if (request.IdContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IdContains(request.IdContains);
					else
						filter &= AddressesAggSettingsSpecifications.IdContains(request.IdContains);
				}
				if (request.IdNotContains != null)
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IdNotContains(request.IdNotContains);
					else
						filter &= AddressesAggSettingsSpecifications.IdNotContains(request.IdNotContains);
				}
				if (request.IsDeletedEqual.HasValue) 
				{
					if (isOrSpecification)
						filter |= AddressesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
					else
						filter &= AddressesAggSettingsSpecifications.IsDeletedEqual(request.IsDeletedEqual.Value);
				}
			}
			return filter;
		}
	}
}

