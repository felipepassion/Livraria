namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class AutorSpecifications {
				public static Specification<Author> IdContains(params int[] values) {
            return new DirectSpecification<Author>(p => values.Contains(p.Id));
        }
		public static Specification<Author> IdNotContains(params int[] values) {
            return new DirectSpecification<Author>(p => !values.Contains(p.Id));
        }
		public static Specification<Author> IdEqual(params int[] values) {
			return new DirectSpecification<Author>(p => values.Contains(p.Id));
        }
        public static Specification<Author> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Author>(p => p.Id >= value);
        }
        public static Specification<Author> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Author>(p => p.Id <= value);
        }
        public static Specification<Author> IdNotEqual(int value) {
            return new DirectSpecification<Author>(p => p.Id != value);
        }
        public static Specification<Author> IdGreaterThan(int value) {
            return new DirectSpecification<Author>(p => p.Id > value);
        }
        public static Specification<Author> IdLessThan(int value) {
            return new DirectSpecification<Author>(p => p.Id < value);
        }
		
					public static Specification<Author> NomeContains(string value) {
			return new DirectSpecification<Author>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Author> NomeNotContains(string value) {
			return new DirectSpecification<Author>(p => !EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Author> NomeStartsWith(string value) {
			return new DirectSpecification<Author>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Author> NomeEqual(string value) {
			return new DirectSpecification<Author>(p => value.ToLower() == (p.Nome.ToLower()));
		}
		public static Specification<Author> NomeNotEqual(string value) {
			return new DirectSpecification<Author>(p => p.Nome != value);
		}
		public static Specification<Author> NomeIsNull() {
            return new DirectSpecification<Author>(p => p.Nome == null);
        }
		public static Specification<Author> NomeIsNotNull() {
            return new DirectSpecification<Author>(p => p.Nome != null);
        }
		
				
					public static Specification<Author> IdExternoContains(string value) {
			return new DirectSpecification<Author>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Author> IdExternoNotContains(string value) {
			return new DirectSpecification<Author>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Author> IdExternoStartsWith(string value) {
			return new DirectSpecification<Author>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Author> IdExternoEqual(string value) {
			return new DirectSpecification<Author>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Author> IdExternoNotEqual(string value) {
			return new DirectSpecification<Author>(p => p.IdExterno != value);
		}
		public static Specification<Author> IdExternoIsNull() {
            return new DirectSpecification<Author>(p => p.IdExterno == null);
        }
		public static Specification<Author> IdExternoIsNotNull() {
            return new DirectSpecification<Author>(p => p.IdExterno != null);
        }
		
					public static Specification<Author> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Author> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Author> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Author>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Author> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.CreatedAt >= value);
        }
        public static Specification<Author> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.CreatedAt <= value);
        }
        public static Specification<Author> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.CreatedAt != value);
        }
        public static Specification<Author> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.CreatedAt > value);
        }
        public static Specification<Author> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.CreatedAt < value);
        }
		
					public static Specification<Author> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Author> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Author> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Author>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Author> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.UpdatedAt >= value);
        }
        public static Specification<Author> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.UpdatedAt <= value);
        }
        public static Specification<Author> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.UpdatedAt != value);
        }
        public static Specification<Author> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.UpdatedAt > value);
        }
        public static Specification<Author> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Author> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Author> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Author>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Author> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Author>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Author> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.DeletedAt >= value);
        }
        public static Specification<Author> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.DeletedAt <= value);
        }
        public static Specification<Author> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.DeletedAt != value);
        }
        public static Specification<Author> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.DeletedAt > value);
        }
        public static Specification<Author> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Author>(p => p.DeletedAt < value);
        }
		
					public static Specification<Author> DeletadoEqual(bool value) {
			return new DirectSpecification<Author>(p => p.Deletado == value);
		}
		
	   }
