namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class LivroSpecifications {
				public static Specification<Book> IdContains(params int[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.Id));
        }
		public static Specification<Book> IdNotContains(params int[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.Id));
        }
		public static Specification<Book> IdEqual(params int[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.Id));
        }
        public static Specification<Book> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Book>(p => p.Id >= value);
        }
        public static Specification<Book> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Book>(p => p.Id <= value);
        }
        public static Specification<Book> IdNotEqual(int value) {
            return new DirectSpecification<Book>(p => p.Id != value);
        }
        public static Specification<Book> IdGreaterThan(int value) {
            return new DirectSpecification<Book>(p => p.Id > value);
        }
        public static Specification<Book> IdLessThan(int value) {
            return new DirectSpecification<Book>(p => p.Id < value);
        }
		
					public static Specification<Book> TituloContains(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.Title.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> TituloNotContains(string value) {
			return new DirectSpecification<Book>(p => !EF.Functions.Like(p.Title.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> TituloStartsWith(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.Title.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Book> TituloEqual(string value) {
			return new DirectSpecification<Book>(p => value.ToLower() == (p.Title.ToLower()));
		}
		public static Specification<Book> TituloNotEqual(string value) {
			return new DirectSpecification<Book>(p => p.Title != value);
		}
		public static Specification<Book> TituloIsNull() {
            return new DirectSpecification<Book>(p => p.Title == null);
        }
		public static Specification<Book> TituloIsNotNull() {
            return new DirectSpecification<Book>(p => p.Title != null);
        }
		
					public static Specification<Book> EditoraContains(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.Publisher.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> EditoraNotContains(string value) {
			return new DirectSpecification<Book>(p => !EF.Functions.Like(p.Publisher.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> EditoraStartsWith(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.Publisher.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Book> EditoraEqual(string value) {
			return new DirectSpecification<Book>(p => value.ToLower() == (p.Publisher.ToLower()));
		}
		public static Specification<Book> EditoraNotEqual(string value) {
			return new DirectSpecification<Book>(p => p.Publisher != value);
		}
		public static Specification<Book> EditoraIsNull() {
            return new DirectSpecification<Book>(p => p.Publisher == null);
        }
		public static Specification<Book> EditoraIsNotNull() {
            return new DirectSpecification<Book>(p => p.Publisher != null);
        }
		
					public static Specification<Book> EdicaoContains(params int[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.Edition.Value));
        }
		public static Specification<Book> EdicaoNotContains(params int[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.Edition.Value));
        }
		public static Specification<Book> EdicaoEqual(params int[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.Edition.Value));
        }
        public static Specification<Book> EdicaoGreaterThanOrEqual(int value) {
            return new DirectSpecification<Book>(p => p.Edition >= value);
        }
        public static Specification<Book> EdicaoLessThanOrEqual(int value) {
            return new DirectSpecification<Book>(p => p.Edition <= value);
        }
        public static Specification<Book> EdicaoNotEqual(int value) {
            return new DirectSpecification<Book>(p => p.Edition != value);
        }
        public static Specification<Book> EdicaoGreaterThan(int value) {
            return new DirectSpecification<Book>(p => p.Edition > value);
        }
        public static Specification<Book> EdicaoLessThan(int value) {
            return new DirectSpecification<Book>(p => p.Edition < value);
        }
		
					public static Specification<Book> AnoPublicacaoContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.AnoPublicacao));
        }
		public static Specification<Book> AnoPublicacaoNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.AnoPublicacao));
        }
		public static Specification<Book> AnoPublicacaoEqual(params System.DateTime[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.AnoPublicacao));
        }
        public static Specification<Book> AnoPublicacaoGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.AnoPublicacao >= value);
        }
        public static Specification<Book> AnoPublicacaoLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.AnoPublicacao <= value);
        }
        public static Specification<Book> AnoPublicacaoNotEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.AnoPublicacao != value);
        }
        public static Specification<Book> AnoPublicacaoGreaterThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.AnoPublicacao > value);
        }
        public static Specification<Book> AnoPublicacaoLessThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.AnoPublicacao < value);
        }
		
				
				
					public static Specification<Book> IdExternoContains(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> IdExternoNotContains(string value) {
			return new DirectSpecification<Book>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Book> IdExternoStartsWith(string value) {
			return new DirectSpecification<Book>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Book> IdExternoEqual(string value) {
			return new DirectSpecification<Book>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Book> IdExternoNotEqual(string value) {
			return new DirectSpecification<Book>(p => p.IdExterno != value);
		}
		public static Specification<Book> IdExternoIsNull() {
            return new DirectSpecification<Book>(p => p.IdExterno == null);
        }
		public static Specification<Book> IdExternoIsNotNull() {
            return new DirectSpecification<Book>(p => p.IdExterno != null);
        }
		
					public static Specification<Book> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Book> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Book> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Book> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.CreatedAt >= value);
        }
        public static Specification<Book> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.CreatedAt <= value);
        }
        public static Specification<Book> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.CreatedAt != value);
        }
        public static Specification<Book> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.CreatedAt > value);
        }
        public static Specification<Book> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.CreatedAt < value);
        }
		
					public static Specification<Book> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Book> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Book> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Book> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.UpdatedAt >= value);
        }
        public static Specification<Book> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.UpdatedAt <= value);
        }
        public static Specification<Book> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.UpdatedAt != value);
        }
        public static Specification<Book> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.UpdatedAt > value);
        }
        public static Specification<Book> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Book> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Book> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Book>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Book> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Book>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Book> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.DeletedAt >= value);
        }
        public static Specification<Book> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.DeletedAt <= value);
        }
        public static Specification<Book> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.DeletedAt != value);
        }
        public static Specification<Book> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.DeletedAt > value);
        }
        public static Specification<Book> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Book>(p => p.DeletedAt < value);
        }
		
					public static Specification<Book> DeletadoEqual(bool value) {
			return new DirectSpecification<Book>(p => p.Deletado == value);
		}
		
	   }
