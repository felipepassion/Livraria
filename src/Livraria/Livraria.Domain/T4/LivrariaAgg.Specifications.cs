using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications {
	using Entities;
   public partial class Livro_AutorSpecifications {
				public static Specification<Livro_Autor> Livro_CodlContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Livro_Codl));
        }
		public static Specification<Livro_Autor> Livro_CodlNotContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.Livro_Codl));
        }
		public static Specification<Livro_Autor> Livro_CodlEqual(params int[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Livro_Codl));
        }
        public static Specification<Livro_Autor> Livro_CodlGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Livro_Codl >= value);
        }
        public static Specification<Livro_Autor> Livro_CodlLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Livro_Codl <= value);
        }
        public static Specification<Livro_Autor> Livro_CodlNotEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Livro_Codl != value);
        }
        public static Specification<Livro_Autor> Livro_CodlGreaterThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Livro_Codl > value);
        }
        public static Specification<Livro_Autor> Livro_CodlLessThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Livro_Codl < value);
        }
		
					public static Specification<Livro_Autor> Autor_CodAutContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Autor_CodAut));
        }
		public static Specification<Livro_Autor> Autor_CodAutNotContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.Autor_CodAut));
        }
		public static Specification<Livro_Autor> Autor_CodAutEqual(params int[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Autor_CodAut));
        }
        public static Specification<Livro_Autor> Autor_CodAutGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Autor_CodAut >= value);
        }
        public static Specification<Livro_Autor> Autor_CodAutLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Autor_CodAut <= value);
        }
        public static Specification<Livro_Autor> Autor_CodAutNotEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Autor_CodAut != value);
        }
        public static Specification<Livro_Autor> Autor_CodAutGreaterThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Autor_CodAut > value);
        }
        public static Specification<Livro_Autor> Autor_CodAutLessThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Autor_CodAut < value);
        }
		
				
				
					public static Specification<Livro_Autor> ExternalIdContains(string value) {
			return new DirectSpecification<Livro_Autor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro_Autor> ExternalIdNotContains(string value) {
			return new DirectSpecification<Livro_Autor>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro_Autor> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Livro_Autor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro_Autor> ExternalIdEqual(string value) {
			return new DirectSpecification<Livro_Autor>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Livro_Autor> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Livro_Autor>(p => p.ExternalId != value);
		}
		public static Specification<Livro_Autor> ExternalIdIsNull() {
            return new DirectSpecification<Livro_Autor>(p => p.ExternalId == null);
        }
		public static Specification<Livro_Autor> ExternalIdIsNotNull() {
            return new DirectSpecification<Livro_Autor>(p => p.ExternalId != null);
        }
		
					public static Specification<Livro_Autor> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro_Autor> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro_Autor> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Livro_Autor> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.CreatedAt >= value);
        }
        public static Specification<Livro_Autor> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.CreatedAt <= value);
        }
        public static Specification<Livro_Autor> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.CreatedAt != value);
        }
        public static Specification<Livro_Autor> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.CreatedAt > value);
        }
        public static Specification<Livro_Autor> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.CreatedAt < value);
        }
		
					public static Specification<Livro_Autor> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro_Autor> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro_Autor> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Livro_Autor> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.UpdatedAt >= value);
        }
        public static Specification<Livro_Autor> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.UpdatedAt <= value);
        }
        public static Specification<Livro_Autor> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.UpdatedAt != value);
        }
        public static Specification<Livro_Autor> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.UpdatedAt > value);
        }
        public static Specification<Livro_Autor> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Livro_Autor> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro_Autor> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro_Autor> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Livro_Autor> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.DeletedAt >= value);
        }
        public static Specification<Livro_Autor> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.DeletedAt <= value);
        }
        public static Specification<Livro_Autor> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.DeletedAt != value);
        }
        public static Specification<Livro_Autor> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.DeletedAt > value);
        }
        public static Specification<Livro_Autor> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Autor>(p => p.DeletedAt < value);
        }
		
					public static Specification<Livro_Autor> IdContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Id));
        }
		public static Specification<Livro_Autor> IdNotContains(params int[] values) {
            return new DirectSpecification<Livro_Autor>(p => !values.Contains(p.Id));
        }
		public static Specification<Livro_Autor> IdEqual(params int[] values) {
			return new DirectSpecification<Livro_Autor>(p => values.Contains(p.Id));
        }
        public static Specification<Livro_Autor> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Id >= value);
        }
        public static Specification<Livro_Autor> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Id <= value);
        }
        public static Specification<Livro_Autor> IdNotEqual(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Id != value);
        }
        public static Specification<Livro_Autor> IdGreaterThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Id > value);
        }
        public static Specification<Livro_Autor> IdLessThan(int value) {
            return new DirectSpecification<Livro_Autor>(p => p.Id < value);
        }
		
					public static Specification<Livro_Autor> IsDeletedEqual(bool value) {
			return new DirectSpecification<Livro_Autor>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class LivroSpecifications {
				public static Specification<Livro> TituloContains(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Titulo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> TituloNotContains(string value) {
			return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.Titulo.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> TituloStartsWith(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Titulo.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro> TituloEqual(string value) {
			return new DirectSpecification<Livro>(p => value.ToLower() == (p.Titulo.ToLower()));
		}
		public static Specification<Livro> TituloNotEqual(string value) {
			return new DirectSpecification<Livro>(p => p.Titulo != value);
		}
		public static Specification<Livro> TituloIsNull() {
            return new DirectSpecification<Livro>(p => p.Titulo == null);
        }
		public static Specification<Livro> TituloIsNotNull() {
            return new DirectSpecification<Livro>(p => p.Titulo != null);
        }
		
					public static Specification<Livro> EditoraContains(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Editora.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> EditoraNotContains(string value) {
			return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.Editora.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> EditoraStartsWith(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Editora.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro> EditoraEqual(string value) {
			return new DirectSpecification<Livro>(p => value.ToLower() == (p.Editora.ToLower()));
		}
		public static Specification<Livro> EditoraNotEqual(string value) {
			return new DirectSpecification<Livro>(p => p.Editora != value);
		}
		public static Specification<Livro> EditoraIsNull() {
            return new DirectSpecification<Livro>(p => p.Editora == null);
        }
		public static Specification<Livro> EditoraIsNotNull() {
            return new DirectSpecification<Livro>(p => p.Editora != null);
        }
		
					public static Specification<Livro> EdicaoContains(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Edicao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> EdicaoNotContains(string value) {
			return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.Edicao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> EdicaoStartsWith(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Edicao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro> EdicaoEqual(string value) {
			return new DirectSpecification<Livro>(p => value.ToLower() == (p.Edicao.ToLower()));
		}
		public static Specification<Livro> EdicaoNotEqual(string value) {
			return new DirectSpecification<Livro>(p => p.Edicao != value);
		}
		public static Specification<Livro> EdicaoIsNull() {
            return new DirectSpecification<Livro>(p => p.Edicao == null);
        }
		public static Specification<Livro> EdicaoIsNotNull() {
            return new DirectSpecification<Livro>(p => p.Edicao != null);
        }
		
					public static Specification<Livro> AnoPublicacaoContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.AnoPublicacao));
        }
		public static Specification<Livro> AnoPublicacaoNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.AnoPublicacao));
        }
		public static Specification<Livro> AnoPublicacaoEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.AnoPublicacao));
        }
        public static Specification<Livro> AnoPublicacaoGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AnoPublicacao >= value);
        }
        public static Specification<Livro> AnoPublicacaoLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AnoPublicacao <= value);
        }
        public static Specification<Livro> AnoPublicacaoNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AnoPublicacao != value);
        }
        public static Specification<Livro> AnoPublicacaoGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AnoPublicacao > value);
        }
        public static Specification<Livro> AnoPublicacaoLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AnoPublicacao < value);
        }
		
				
				
					public static Specification<Livro> ExternalIdContains(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> ExternalIdNotContains(string value) {
			return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro> ExternalIdEqual(string value) {
			return new DirectSpecification<Livro>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Livro> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Livro>(p => p.ExternalId != value);
		}
		public static Specification<Livro> ExternalIdIsNull() {
            return new DirectSpecification<Livro>(p => p.ExternalId == null);
        }
		public static Specification<Livro> ExternalIdIsNotNull() {
            return new DirectSpecification<Livro>(p => p.ExternalId != null);
        }
		
					public static Specification<Livro> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Livro> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CreatedAt >= value);
        }
        public static Specification<Livro> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CreatedAt <= value);
        }
        public static Specification<Livro> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CreatedAt != value);
        }
        public static Specification<Livro> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CreatedAt > value);
        }
        public static Specification<Livro> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CreatedAt < value);
        }
		
					public static Specification<Livro> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Livro> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.UpdatedAt >= value);
        }
        public static Specification<Livro> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.UpdatedAt <= value);
        }
        public static Specification<Livro> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.UpdatedAt != value);
        }
        public static Specification<Livro> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.UpdatedAt > value);
        }
        public static Specification<Livro> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Livro> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Livro> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletedAt >= value);
        }
        public static Specification<Livro> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletedAt <= value);
        }
        public static Specification<Livro> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletedAt != value);
        }
        public static Specification<Livro> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletedAt > value);
        }
        public static Specification<Livro> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletedAt < value);
        }
		
					public static Specification<Livro> IdContains(params int[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.Id));
        }
		public static Specification<Livro> IdNotContains(params int[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.Id));
        }
		public static Specification<Livro> IdEqual(params int[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.Id));
        }
        public static Specification<Livro> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Id >= value);
        }
        public static Specification<Livro> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Id <= value);
        }
        public static Specification<Livro> IdNotEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Id != value);
        }
        public static Specification<Livro> IdGreaterThan(int value) {
            return new DirectSpecification<Livro>(p => p.Id > value);
        }
        public static Specification<Livro> IdLessThan(int value) {
            return new DirectSpecification<Livro>(p => p.Id < value);
        }
		
					public static Specification<Livro> IsDeletedEqual(bool value) {
			return new DirectSpecification<Livro>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class AssuntoSpecifications {
				public static Specification<Assunto> DescricaoContains(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> DescricaoNotContains(string value) {
			return new DirectSpecification<Assunto>(p => !EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> DescricaoStartsWith(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.Descricao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Assunto> DescricaoEqual(string value) {
			return new DirectSpecification<Assunto>(p => value.ToLower() == (p.Descricao.ToLower()));
		}
		public static Specification<Assunto> DescricaoNotEqual(string value) {
			return new DirectSpecification<Assunto>(p => p.Descricao != value);
		}
		public static Specification<Assunto> DescricaoIsNull() {
            return new DirectSpecification<Assunto>(p => p.Descricao == null);
        }
		public static Specification<Assunto> DescricaoIsNotNull() {
            return new DirectSpecification<Assunto>(p => p.Descricao != null);
        }
		
					public static Specification<Assunto> ExternalIdContains(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> ExternalIdNotContains(string value) {
			return new DirectSpecification<Assunto>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Assunto> ExternalIdEqual(string value) {
			return new DirectSpecification<Assunto>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Assunto> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Assunto>(p => p.ExternalId != value);
		}
		public static Specification<Assunto> ExternalIdIsNull() {
            return new DirectSpecification<Assunto>(p => p.ExternalId == null);
        }
		public static Specification<Assunto> ExternalIdIsNotNull() {
            return new DirectSpecification<Assunto>(p => p.ExternalId != null);
        }
		
					public static Specification<Assunto> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Assunto> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Assunto> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Assunto> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CreatedAt >= value);
        }
        public static Specification<Assunto> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CreatedAt <= value);
        }
        public static Specification<Assunto> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CreatedAt != value);
        }
        public static Specification<Assunto> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CreatedAt > value);
        }
        public static Specification<Assunto> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CreatedAt < value);
        }
		
					public static Specification<Assunto> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Assunto> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Assunto> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Assunto> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.UpdatedAt >= value);
        }
        public static Specification<Assunto> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.UpdatedAt <= value);
        }
        public static Specification<Assunto> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.UpdatedAt != value);
        }
        public static Specification<Assunto> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.UpdatedAt > value);
        }
        public static Specification<Assunto> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Assunto> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Assunto> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Assunto> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Assunto> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletedAt >= value);
        }
        public static Specification<Assunto> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletedAt <= value);
        }
        public static Specification<Assunto> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletedAt != value);
        }
        public static Specification<Assunto> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletedAt > value);
        }
        public static Specification<Assunto> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletedAt < value);
        }
		
					public static Specification<Assunto> IdContains(params int[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.Id));
        }
		public static Specification<Assunto> IdNotContains(params int[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.Id));
        }
		public static Specification<Assunto> IdEqual(params int[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.Id));
        }
        public static Specification<Assunto> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Assunto>(p => p.Id >= value);
        }
        public static Specification<Assunto> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Assunto>(p => p.Id <= value);
        }
        public static Specification<Assunto> IdNotEqual(int value) {
            return new DirectSpecification<Assunto>(p => p.Id != value);
        }
        public static Specification<Assunto> IdGreaterThan(int value) {
            return new DirectSpecification<Assunto>(p => p.Id > value);
        }
        public static Specification<Assunto> IdLessThan(int value) {
            return new DirectSpecification<Assunto>(p => p.Id < value);
        }
		
					public static Specification<Assunto> IsDeletedEqual(bool value) {
			return new DirectSpecification<Assunto>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class Livro_AssuntoSpecifications {
				public static Specification<Livro_Assunto> Livro_CodlContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Livro_Codl));
        }
		public static Specification<Livro_Assunto> Livro_CodlNotContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.Livro_Codl));
        }
		public static Specification<Livro_Assunto> Livro_CodlEqual(params int[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Livro_Codl));
        }
        public static Specification<Livro_Assunto> Livro_CodlGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Livro_Codl >= value);
        }
        public static Specification<Livro_Assunto> Livro_CodlLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Livro_Codl <= value);
        }
        public static Specification<Livro_Assunto> Livro_CodlNotEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Livro_Codl != value);
        }
        public static Specification<Livro_Assunto> Livro_CodlGreaterThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Livro_Codl > value);
        }
        public static Specification<Livro_Assunto> Livro_CodlLessThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Livro_Codl < value);
        }
		
					public static Specification<Livro_Assunto> Assunto_CodAutContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Assunto_CodAut));
        }
		public static Specification<Livro_Assunto> Assunto_CodAutNotContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.Assunto_CodAut));
        }
		public static Specification<Livro_Assunto> Assunto_CodAutEqual(params int[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Assunto_CodAut));
        }
        public static Specification<Livro_Assunto> Assunto_CodAutGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Assunto_CodAut >= value);
        }
        public static Specification<Livro_Assunto> Assunto_CodAutLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Assunto_CodAut <= value);
        }
        public static Specification<Livro_Assunto> Assunto_CodAutNotEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Assunto_CodAut != value);
        }
        public static Specification<Livro_Assunto> Assunto_CodAutGreaterThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Assunto_CodAut > value);
        }
        public static Specification<Livro_Assunto> Assunto_CodAutLessThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Assunto_CodAut < value);
        }
		
				
				
					public static Specification<Livro_Assunto> ExternalIdContains(string value) {
			return new DirectSpecification<Livro_Assunto>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro_Assunto> ExternalIdNotContains(string value) {
			return new DirectSpecification<Livro_Assunto>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro_Assunto> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Livro_Assunto>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro_Assunto> ExternalIdEqual(string value) {
			return new DirectSpecification<Livro_Assunto>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Livro_Assunto> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Livro_Assunto>(p => p.ExternalId != value);
		}
		public static Specification<Livro_Assunto> ExternalIdIsNull() {
            return new DirectSpecification<Livro_Assunto>(p => p.ExternalId == null);
        }
		public static Specification<Livro_Assunto> ExternalIdIsNotNull() {
            return new DirectSpecification<Livro_Assunto>(p => p.ExternalId != null);
        }
		
					public static Specification<Livro_Assunto> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro_Assunto> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Livro_Assunto> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Livro_Assunto> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.CreatedAt >= value);
        }
        public static Specification<Livro_Assunto> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.CreatedAt <= value);
        }
        public static Specification<Livro_Assunto> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.CreatedAt != value);
        }
        public static Specification<Livro_Assunto> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.CreatedAt > value);
        }
        public static Specification<Livro_Assunto> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.CreatedAt < value);
        }
		
					public static Specification<Livro_Assunto> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro_Assunto> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Livro_Assunto> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Livro_Assunto> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.UpdatedAt >= value);
        }
        public static Specification<Livro_Assunto> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.UpdatedAt <= value);
        }
        public static Specification<Livro_Assunto> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.UpdatedAt != value);
        }
        public static Specification<Livro_Assunto> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.UpdatedAt > value);
        }
        public static Specification<Livro_Assunto> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Livro_Assunto> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro_Assunto> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Livro_Assunto> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Livro_Assunto> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.DeletedAt >= value);
        }
        public static Specification<Livro_Assunto> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.DeletedAt <= value);
        }
        public static Specification<Livro_Assunto> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.DeletedAt != value);
        }
        public static Specification<Livro_Assunto> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.DeletedAt > value);
        }
        public static Specification<Livro_Assunto> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Livro_Assunto>(p => p.DeletedAt < value);
        }
		
					public static Specification<Livro_Assunto> IdContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Id));
        }
		public static Specification<Livro_Assunto> IdNotContains(params int[] values) {
            return new DirectSpecification<Livro_Assunto>(p => !values.Contains(p.Id));
        }
		public static Specification<Livro_Assunto> IdEqual(params int[] values) {
			return new DirectSpecification<Livro_Assunto>(p => values.Contains(p.Id));
        }
        public static Specification<Livro_Assunto> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Id >= value);
        }
        public static Specification<Livro_Assunto> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Id <= value);
        }
        public static Specification<Livro_Assunto> IdNotEqual(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Id != value);
        }
        public static Specification<Livro_Assunto> IdGreaterThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Id > value);
        }
        public static Specification<Livro_Assunto> IdLessThan(int value) {
            return new DirectSpecification<Livro_Assunto>(p => p.Id < value);
        }
		
					public static Specification<Livro_Assunto> IsDeletedEqual(bool value) {
			return new DirectSpecification<Livro_Assunto>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class AutorSpecifications {
				public static Specification<Autor> NomeContains(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> NomeNotContains(string value) {
			return new DirectSpecification<Autor>(p => !EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> NomeStartsWith(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Autor> NomeEqual(string value) {
			return new DirectSpecification<Autor>(p => value.ToLower() == (p.Nome.ToLower()));
		}
		public static Specification<Autor> NomeNotEqual(string value) {
			return new DirectSpecification<Autor>(p => p.Nome != value);
		}
		public static Specification<Autor> NomeIsNull() {
            return new DirectSpecification<Autor>(p => p.Nome == null);
        }
		public static Specification<Autor> NomeIsNotNull() {
            return new DirectSpecification<Autor>(p => p.Nome != null);
        }
		
					public static Specification<Autor> ExternalIdContains(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> ExternalIdNotContains(string value) {
			return new DirectSpecification<Autor>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> ExternalIdStartsWith(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Autor> ExternalIdEqual(string value) {
			return new DirectSpecification<Autor>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<Autor> ExternalIdNotEqual(string value) {
			return new DirectSpecification<Autor>(p => p.ExternalId != value);
		}
		public static Specification<Autor> ExternalIdIsNull() {
            return new DirectSpecification<Autor>(p => p.ExternalId == null);
        }
		public static Specification<Autor> ExternalIdIsNotNull() {
            return new DirectSpecification<Autor>(p => p.ExternalId != null);
        }
		
					public static Specification<Autor> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Autor> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Autor> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Autor> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CreatedAt >= value);
        }
        public static Specification<Autor> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CreatedAt <= value);
        }
        public static Specification<Autor> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CreatedAt != value);
        }
        public static Specification<Autor> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CreatedAt > value);
        }
        public static Specification<Autor> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CreatedAt < value);
        }
		
					public static Specification<Autor> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Autor> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Autor> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Autor> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.UpdatedAt >= value);
        }
        public static Specification<Autor> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.UpdatedAt <= value);
        }
        public static Specification<Autor> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.UpdatedAt != value);
        }
        public static Specification<Autor> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.UpdatedAt > value);
        }
        public static Specification<Autor> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Autor> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Autor> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Autor> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Autor> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletedAt >= value);
        }
        public static Specification<Autor> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletedAt <= value);
        }
        public static Specification<Autor> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletedAt != value);
        }
        public static Specification<Autor> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletedAt > value);
        }
        public static Specification<Autor> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletedAt < value);
        }
		
					public static Specification<Autor> IdContains(params int[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.Id));
        }
		public static Specification<Autor> IdNotContains(params int[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.Id));
        }
		public static Specification<Autor> IdEqual(params int[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.Id));
        }
        public static Specification<Autor> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Autor>(p => p.Id >= value);
        }
        public static Specification<Autor> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Autor>(p => p.Id <= value);
        }
        public static Specification<Autor> IdNotEqual(int value) {
            return new DirectSpecification<Autor>(p => p.Id != value);
        }
        public static Specification<Autor> IdGreaterThan(int value) {
            return new DirectSpecification<Autor>(p => p.Id > value);
        }
        public static Specification<Autor> IdLessThan(int value) {
            return new DirectSpecification<Autor>(p => p.Id < value);
        }
		
					public static Specification<Autor> IsDeletedEqual(bool value) {
			return new DirectSpecification<Autor>(p => p.IsDeleted == value);
		}
		
	   }
   public partial class LivrariaAggSettingsSpecifications {
				public static Specification<LivrariaAggSettings> AutoSaveSettingsEnabledEqual(bool value) {
			return new DirectSpecification<LivrariaAggSettings>(p => p.AutoSaveSettingsEnabled == value);
		}
		
					public static Specification<LivrariaAggSettings> ExternalIdContains(string value) {
			return new DirectSpecification<LivrariaAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<LivrariaAggSettings> ExternalIdNotContains(string value) {
			return new DirectSpecification<LivrariaAggSettings>(p => !EF.Functions.Like(p.ExternalId.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<LivrariaAggSettings> ExternalIdStartsWith(string value) {
			return new DirectSpecification<LivrariaAggSettings>(p => EF.Functions.Like(p.ExternalId.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<LivrariaAggSettings> ExternalIdEqual(string value) {
			return new DirectSpecification<LivrariaAggSettings>(p => value.ToLower() == (p.ExternalId.ToLower()));
		}
		public static Specification<LivrariaAggSettings> ExternalIdNotEqual(string value) {
			return new DirectSpecification<LivrariaAggSettings>(p => p.ExternalId != value);
		}
		public static Specification<LivrariaAggSettings> ExternalIdIsNull() {
            return new DirectSpecification<LivrariaAggSettings>(p => p.ExternalId == null);
        }
		public static Specification<LivrariaAggSettings> ExternalIdIsNotNull() {
            return new DirectSpecification<LivrariaAggSettings>(p => p.ExternalId != null);
        }
		
					public static Specification<LivrariaAggSettings> CreatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<LivrariaAggSettings> CreatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<LivrariaAggSettings> CreatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<LivrariaAggSettings> CreatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.CreatedAt >= value);
        }
        public static Specification<LivrariaAggSettings> CreatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.CreatedAt <= value);
        }
        public static Specification<LivrariaAggSettings> CreatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.CreatedAt != value);
        }
        public static Specification<LivrariaAggSettings> CreatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.CreatedAt > value);
        }
        public static Specification<LivrariaAggSettings> CreatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.CreatedAt < value);
        }
		
					public static Specification<LivrariaAggSettings> UpdatedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<LivrariaAggSettings> UpdatedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<LivrariaAggSettings> UpdatedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<LivrariaAggSettings> UpdatedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.UpdatedAt >= value);
        }
        public static Specification<LivrariaAggSettings> UpdatedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.UpdatedAt <= value);
        }
        public static Specification<LivrariaAggSettings> UpdatedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.UpdatedAt != value);
        }
        public static Specification<LivrariaAggSettings> UpdatedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.UpdatedAt > value);
        }
        public static Specification<LivrariaAggSettings> UpdatedAtLessThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.UpdatedAt < value);
        }
		
					public static Specification<LivrariaAggSettings> DeletedAtContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<LivrariaAggSettings> DeletedAtNotContains(params System.DateTime[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<LivrariaAggSettings> DeletedAtEqual(params System.DateTime[] values) {
			return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<LivrariaAggSettings> DeletedAtGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.DeletedAt >= value);
        }
        public static Specification<LivrariaAggSettings> DeletedAtLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.DeletedAt <= value);
        }
        public static Specification<LivrariaAggSettings> DeletedAtNotEqual(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.DeletedAt != value);
        }
        public static Specification<LivrariaAggSettings> DeletedAtGreaterThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.DeletedAt > value);
        }
        public static Specification<LivrariaAggSettings> DeletedAtLessThan(System.DateTime value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.DeletedAt < value);
        }
		
					public static Specification<LivrariaAggSettings> IdContains(params int[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.Id));
        }
		public static Specification<LivrariaAggSettings> IdNotContains(params int[] values) {
            return new DirectSpecification<LivrariaAggSettings>(p => !values.Contains(p.Id));
        }
		public static Specification<LivrariaAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<LivrariaAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<LivrariaAggSettings> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.Id >= value);
        }
        public static Specification<LivrariaAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.Id <= value);
        }
        public static Specification<LivrariaAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.Id != value);
        }
        public static Specification<LivrariaAggSettings> IdGreaterThan(int value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.Id > value);
        }
        public static Specification<LivrariaAggSettings> IdLessThan(int value) {
            return new DirectSpecification<LivrariaAggSettings>(p => p.Id < value);
        }
		
					public static Specification<LivrariaAggSettings> IsDeletedEqual(bool value) {
			return new DirectSpecification<LivrariaAggSettings>(p => p.IsDeleted == value);
		}
		
	   }
}
