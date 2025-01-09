namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class AssuntoSpecifications {
				public static Specification<Subject> IdContains(params int[] values) {
            return new DirectSpecification<Subject>(p => values.Contains(p.Id));
        }
		public static Specification<Subject> IdNotContains(params int[] values) {
            return new DirectSpecification<Subject>(p => !values.Contains(p.Id));
        }
		public static Specification<Subject> IdEqual(params int[] values) {
			return new DirectSpecification<Subject>(p => values.Contains(p.Id));
        }
        public static Specification<Subject> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<Subject>(p => p.Id >= value);
        }
        public static Specification<Subject> IdLessThanOrEqual(int value) {
            return new DirectSpecification<Subject>(p => p.Id <= value);
        }
        public static Specification<Subject> IdNotEqual(int value) {
            return new DirectSpecification<Subject>(p => p.Id != value);
        }
        public static Specification<Subject> IdGreaterThan(int value) {
            return new DirectSpecification<Subject>(p => p.Id > value);
        }
        public static Specification<Subject> IdLessThan(int value) {
            return new DirectSpecification<Subject>(p => p.Id < value);
        }
		
					public static Specification<Subject> DescricaoContains(string value) {
			return new DirectSpecification<Subject>(p => EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Subject> DescricaoNotContains(string value) {
			return new DirectSpecification<Subject>(p => !EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Subject> DescricaoStartsWith(string value) {
			return new DirectSpecification<Subject>(p => EF.Functions.Like(p.Descricao.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Subject> DescricaoEqual(string value) {
			return new DirectSpecification<Subject>(p => value.ToLower() == (p.Descricao.ToLower()));
		}
		public static Specification<Subject> DescricaoNotEqual(string value) {
			return new DirectSpecification<Subject>(p => p.Descricao != value);
		}
		public static Specification<Subject> DescricaoIsNull() {
            return new DirectSpecification<Subject>(p => p.Descricao == null);
        }
		public static Specification<Subject> DescricaoIsNotNull() {
            return new DirectSpecification<Subject>(p => p.Descricao != null);
        }
		
				
					public static Specification<Subject> IdExternoContains(string value) {
			return new DirectSpecification<Subject>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Subject> IdExternoNotContains(string value) {
			return new DirectSpecification<Subject>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Subject> IdExternoStartsWith(string value) {
			return new DirectSpecification<Subject>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Subject> IdExternoEqual(string value) {
			return new DirectSpecification<Subject>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Subject> IdExternoNotEqual(string value) {
			return new DirectSpecification<Subject>(p => p.IdExterno != value);
		}
		public static Specification<Subject> IdExternoIsNull() {
            return new DirectSpecification<Subject>(p => p.IdExterno == null);
        }
		public static Specification<Subject> IdExternoIsNotNull() {
            return new DirectSpecification<Subject>(p => p.IdExterno != null);
        }
		
					public static Specification<Subject> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Subject> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => !values.Contains(p.CreatedAt.Value));
        }
		public static Specification<Subject> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Subject>(p => values.Contains(p.CreatedAt.Value));
        }
        public static Specification<Subject> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.CreatedAt >= value);
        }
        public static Specification<Subject> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.CreatedAt <= value);
        }
        public static Specification<Subject> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.CreatedAt != value);
        }
        public static Specification<Subject> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.CreatedAt > value);
        }
        public static Specification<Subject> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.CreatedAt < value);
        }
		
					public static Specification<Subject> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Subject> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => !values.Contains(p.UpdatedAt.Value));
        }
		public static Specification<Subject> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Subject>(p => values.Contains(p.UpdatedAt.Value));
        }
        public static Specification<Subject> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.UpdatedAt >= value);
        }
        public static Specification<Subject> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.UpdatedAt <= value);
        }
        public static Specification<Subject> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.UpdatedAt != value);
        }
        public static Specification<Subject> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.UpdatedAt > value);
        }
        public static Specification<Subject> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.UpdatedAt < value);
        }
		
					public static Specification<Subject> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Subject> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Subject>(p => !values.Contains(p.DeletedAt.Value));
        }
		public static Specification<Subject> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Subject>(p => values.Contains(p.DeletedAt.Value));
        }
        public static Specification<Subject> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.DeletedAt >= value);
        }
        public static Specification<Subject> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.DeletedAt <= value);
        }
        public static Specification<Subject> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.DeletedAt != value);
        }
        public static Specification<Subject> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.DeletedAt > value);
        }
        public static Specification<Subject> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Subject>(p => p.DeletedAt < value);
        }
		
					public static Specification<Subject> DeletadoEqual(bool value) {
			return new DirectSpecification<Subject>(p => p.Deletado == value);
		}
		
	   }
