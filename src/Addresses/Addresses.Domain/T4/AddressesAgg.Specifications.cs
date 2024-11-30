using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Specifications {
	using Entities;
   public partial class AddressSpecifications {
				public static Specification<Address> CEPContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.CEP.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> CEPNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.CEP.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> CEPStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.CEP.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> CEPEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.CEP.ToLower()));
		}
		public static Specification<Address> CEPNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.CEP != value);
		}
		public static Specification<Address> CEPIsNull() {
            return new DirectSpecification<Address>(p => p.CEP == null);
        }
		public static Specification<Address> CEPIsNotNull() {
            return new DirectSpecification<Address>(p => p.CEP != null);
        }
		
					public static Specification<Address> LogradouroContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Logradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> LogradouroNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.Logradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> LogradouroStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Logradouro.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> LogradouroEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.Logradouro.ToLower()));
		}
		public static Specification<Address> LogradouroNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.Logradouro != value);
		}
		public static Specification<Address> LogradouroIsNull() {
            return new DirectSpecification<Address>(p => p.Logradouro == null);
        }
		public static Specification<Address> LogradouroIsNotNull() {
            return new DirectSpecification<Address>(p => p.Logradouro != null);
        }
		
					public static Specification<Address> TipoLogradouroContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.TipoLogradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> TipoLogradouroNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.TipoLogradouro.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> TipoLogradouroStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.TipoLogradouro.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> TipoLogradouroEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.TipoLogradouro.ToLower()));
		}
		public static Specification<Address> TipoLogradouroNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.TipoLogradouro != value);
		}
		public static Specification<Address> TipoLogradouroIsNull() {
            return new DirectSpecification<Address>(p => p.TipoLogradouro == null);
        }
		public static Specification<Address> TipoLogradouroIsNotNull() {
            return new DirectSpecification<Address>(p => p.TipoLogradouro != null);
        }
		
					public static Specification<Address> Bairro_DistritoContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Bairro_Distrito.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> Bairro_DistritoNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.Bairro_Distrito.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> Bairro_DistritoStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Bairro_Distrito.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> Bairro_DistritoEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.Bairro_Distrito.ToLower()));
		}
		public static Specification<Address> Bairro_DistritoNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.Bairro_Distrito != value);
		}
		public static Specification<Address> Bairro_DistritoIsNull() {
            return new DirectSpecification<Address>(p => p.Bairro_Distrito == null);
        }
		public static Specification<Address> Bairro_DistritoIsNotNull() {
            return new DirectSpecification<Address>(p => p.Bairro_Distrito != null);
        }
		
					public static Specification<Address> Cidade_LocalidadeContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Cidade_Localidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> Cidade_LocalidadeNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.Cidade_Localidade.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> Cidade_LocalidadeStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.Cidade_Localidade.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> Cidade_LocalidadeEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.Cidade_Localidade.ToLower()));
		}
		public static Specification<Address> Cidade_LocalidadeNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.Cidade_Localidade != value);
		}
		public static Specification<Address> Cidade_LocalidadeIsNull() {
            return new DirectSpecification<Address>(p => p.Cidade_Localidade == null);
        }
		public static Specification<Address> Cidade_LocalidadeIsNotNull() {
            return new DirectSpecification<Address>(p => p.Cidade_Localidade != null);
        }
		
					public static Specification<Address> UFContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.UF.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> UFNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.UF.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> UFStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.UF.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> UFEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.UF.ToLower()));
		}
		public static Specification<Address> UFNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.UF != value);
		}
		public static Specification<Address> UFIsNull() {
            return new DirectSpecification<Address>(p => p.UF == null);
        }
		public static Specification<Address> UFIsNotNull() {
            return new DirectSpecification<Address>(p => p.UF != null);
        }
		
					public static Specification<Address> LatContains(params double[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.Lat));
        }
		public static Specification<Address> LatNotContains(params double[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.Lat));
        }
		public static Specification<Address> LatEqual(params double[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.Lat));
        }
        public static Specification<Address> LatGreaterThanOrEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lat >= value);
        }
        public static Specification<Address> LatLessThanOrEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lat <= value);
        }
        public static Specification<Address> LatNotEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lat != value);
        }
        public static Specification<Address> LatGreaterThan(double value) {
            return new DirectSpecification<Address>(p => p.Lat > value);
        }
        public static Specification<Address> LatLessThan(double value) {
            return new DirectSpecification<Address>(p => p.Lat < value);
        }
		
					public static Specification<Address> LngContains(params double[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.Lng));
        }
		public static Specification<Address> LngNotContains(params double[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.Lng));
        }
		public static Specification<Address> LngEqual(params double[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.Lng));
        }
        public static Specification<Address> LngGreaterThanOrEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lng >= value);
        }
        public static Specification<Address> LngLessThanOrEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lng <= value);
        }
        public static Specification<Address> LngNotEqual(double value) {
            return new DirectSpecification<Address>(p => p.Lng != value);
        }
        public static Specification<Address> LngGreaterThan(double value) {
            return new DirectSpecification<Address>(p => p.Lng > value);
        }
        public static Specification<Address> LngLessThan(double value) {
            return new DirectSpecification<Address>(p => p.Lng < value);
        }
		
					public static Specification<Address> ExternalIdContains(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> ExternalIdNotContains(string value) {
			return new DirectSpecification<Address>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Address> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Address>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Address> ExternalIdEqual(string value) {
			return new DirectSpecification<Address>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Address> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Address>(p => p.ExternalId != value);
		}
		public static Specification<Address> ExternalIdIsNull() {
            return new DirectSpecification<Address>(p => p.ExternalId == null);
        }
		public static Specification<Address> ExternalIdIsNotNull() {
            return new DirectSpecification<Address>(p => p.ExternalId != null);
        }
		
					public static Specification<Address> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Address> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Address> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Address> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.CreatedAt >= value);
        }
        public static Specification<Address> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.CreatedAt <= value);
        }
        public static Specification<Address> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.CreatedAt != value);
        }
        public static Specification<Address> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.CreatedAt > value);
        }
        public static Specification<Address> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.CreatedAt < value);
        }
		
					public static Specification<Address> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Address> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Address> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Address> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.UpdatedAt >= value);
        }
        public static Specification<Address> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.UpdatedAt <= value);
        }
        public static Specification<Address> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.UpdatedAt != value);
        }
        public static Specification<Address> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.UpdatedAt > value);
        }
        public static Specification<Address> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Address> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Address> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Address> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Address> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.DeletedAt >= value);
        }
        public static Specification<Address> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.DeletedAt <= value);
        }
        public static Specification<Address> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.DeletedAt != value);
        }
        public static Specification<Address> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.DeletedAt > value);
        }
        public static Specification<Address> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Address>(p => p.DeletedAt < value);
        }
		
					public static Specification<Address> IdContains(params int[] values) {
            return new DirectSpecification<Address>(p => values.Contains(p.Id));
        }
		public static Specification<Address> IdNotContains(params int[] values) {
            return new DirectSpecification<Address>(p => !values.Contains(p.Id));
        }
		public static Specification<Address> IdEqual(params int[] values) {
			return new DirectSpecification<Address>(p => values.Contains(p.Id));
        }
        public static Specification<Address> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Address>(p => p.Id >= value);
        }
        public static Specification<Address> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Address>(p => p.Id <= value);
        }
        public static Specification<Address> IdNotEqual(int value) {
            return new DirectSpecification<Address>(p => p.Id != value);
        }
        public static Specification<Address> IdGreaterThan(int value) {
            return new DirectSpecification<Address>(p => p.Id > value);
        }
        public static Specification<Address> IdLessThan(int value) {
            return new DirectSpecification<Address>(p => p.Id < value);
        }
		
					public static Specification<Address> IsDeletedEqual(bool value) {
			return new DirectSpecification<Address>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class AddressesAggSettingsSpecifications {
				public static Specification<AddressesAggSettings> UserIdContains(params int[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.UserId));
        }
		public static Specification<AddressesAggSettings> UserIdNotContains(params int[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => !values.Contains(p.UserId));
        }
		public static Specification<AddressesAggSettings> UserIdEqual(params int[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.UserId));
        }
        public static Specification<AddressesAggSettings> UserIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UserId >= value);
        }
        public static Specification<AddressesAggSettings> UserIdLessThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UserId <= value);
        }
        public static Specification<AddressesAggSettings> UserIdNotEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UserId != value);
        }
        public static Specification<AddressesAggSettings> UserIdGreaterThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UserId > value);
        }
        public static Specification<AddressesAggSettings> UserIdLessThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UserId < value);
        }
		
					public static Specification<AddressesAggSettings> AutoSaveSettingsEnabledEqual(bool value) {
			return new DirectSpecification<AddressesAggSettings>(p => p.AutoSaveSettingsEnabled == value);
		}
		
					public static Specification<AddressesAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AddressesAggSettings> ExternalIdNotContains(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<AddressesAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<AddressesAggSettings> ExternalIdEqual(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<AddressesAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<AddressesAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<AddressesAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<AddressesAggSettings>(p => p.ExternalId != null);
        }
		
					public static Specification<AddressesAggSettings> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<AddressesAggSettings> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<AddressesAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<AddressesAggSettings> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<AddressesAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<AddressesAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<AddressesAggSettings> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<AddressesAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.CreatedAt < value);
        }
		
					public static Specification<AddressesAggSettings> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<AddressesAggSettings> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<AddressesAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<AddressesAggSettings> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<AddressesAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.UpdatedAt < value);
        }
		
					public static Specification<AddressesAggSettings> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<AddressesAggSettings> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<AddressesAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<AddressesAggSettings> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<AddressesAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<AddressesAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<AddressesAggSettings> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<AddressesAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.DeletedAt < value);
        }
		
					public static Specification<AddressesAggSettings> IdContains(params int[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.Id));
        }
		public static Specification<AddressesAggSettings> IdNotContains(params int[] values) {
            return new DirectSpecification<AddressesAggSettings>(p => !values.Contains(p.Id));
        }
		public static Specification<AddressesAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<AddressesAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<AddressesAggSettings> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id >= value);
        }
        public static Specification<AddressesAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id <= value);
        }
        public static Specification<AddressesAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id != value);
        }
        public static Specification<AddressesAggSettings> IdGreaterThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id > value);
        }
        public static Specification<AddressesAggSettings> IdLessThan(int value) {
            return new DirectSpecification<AddressesAggSettings>(p => p.Id < value);
        }
		
					public static Specification<AddressesAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<AddressesAggSettings>(p => p.IsDeleted == value);
		}
		
	   }
}
