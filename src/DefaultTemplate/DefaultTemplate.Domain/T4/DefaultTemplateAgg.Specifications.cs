using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Niu.Nutri.DefaultTemplate.Domain.Aggregates.DefaultTemplateAgg.Specifications {
	using Entities;
   public partial class DefaultEntitySpecifications {
				public static Specification<DefaultEntity> IdExternoContains(string value) {
			return new DirectSpecification<DefaultEntity>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<DefaultEntity> IdExternoNotContains(string value) {
			return new DirectSpecification<DefaultEntity>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<DefaultEntity> IdExternoStartsWith(string value) {
			return new DirectSpecification<DefaultEntity>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<DefaultEntity> IdExternoEqual(string value) {
			return new DirectSpecification<DefaultEntity>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<DefaultEntity> IdExternoNotEqual(string value) {
			return new DirectSpecification<DefaultEntity>(p => p.IdExterno != value);
		}
		public static Specification<DefaultEntity> IdExternoIsNull() {
            return new DirectSpecification<DefaultEntity>(p => p.IdExterno == null);
        }
		public static Specification<DefaultEntity> IdExternoIsNotNull() {
            return new DirectSpecification<DefaultEntity>(p => p.IdExterno != null);
        }
		
					public static Specification<DefaultEntity> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => values.Contains(p.CriadoEm.Value));
        }
		public static Specification<DefaultEntity> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => !values.Contains(p.CriadoEm.Value));
        }
		public static Specification<DefaultEntity> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultEntity>(p => values.Contains(p.CriadoEm.Value));
        }
        public static Specification<DefaultEntity> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.CriadoEm >= value);
        }
        public static Specification<DefaultEntity> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.CriadoEm <= value);
        }
        public static Specification<DefaultEntity> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.CriadoEm != value);
        }
        public static Specification<DefaultEntity> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.CriadoEm > value);
        }
        public static Specification<DefaultEntity> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.CriadoEm < value);
        }
		
					public static Specification<DefaultEntity> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<DefaultEntity> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => !values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<DefaultEntity> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultEntity>(p => values.Contains(p.AtualizadoEm.Value));
        }
        public static Specification<DefaultEntity> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.AtualizadoEm >= value);
        }
        public static Specification<DefaultEntity> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.AtualizadoEm <= value);
        }
        public static Specification<DefaultEntity> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.AtualizadoEm != value);
        }
        public static Specification<DefaultEntity> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.AtualizadoEm > value);
        }
        public static Specification<DefaultEntity> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.AtualizadoEm < value);
        }
		
					public static Specification<DefaultEntity> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<DefaultEntity> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultEntity>(p => !values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<DefaultEntity> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultEntity>(p => values.Contains(p.DeletadoEm.Value));
        }
        public static Specification<DefaultEntity> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.DeletadoEm >= value);
        }
        public static Specification<DefaultEntity> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.DeletadoEm <= value);
        }
        public static Specification<DefaultEntity> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.DeletadoEm != value);
        }
        public static Specification<DefaultEntity> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.DeletadoEm > value);
        }
        public static Specification<DefaultEntity> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultEntity>(p => p.DeletadoEm < value);
        }
		
					public static Specification<DefaultEntity> IdContains(params int[] values) {
            return new DirectSpecification<DefaultEntity>(p => values.Contains(p.Id));
        }
		public static Specification<DefaultEntity> IdNotContains(params int[] values) {
            return new DirectSpecification<DefaultEntity>(p => !values.Contains(p.Id));
        }
		public static Specification<DefaultEntity> IdEqual(params int[] values) {
			return new DirectSpecification<DefaultEntity>(p => values.Contains(p.Id));
        }
        public static Specification<DefaultEntity> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<DefaultEntity>(p => p.Id >= value);
        }
        public static Specification<DefaultEntity> IdLessThanOrEqual(int value) {
            return new DirectSpecification<DefaultEntity>(p => p.Id <= value);
        }
        public static Specification<DefaultEntity> IdNotEqual(int value) {
            return new DirectSpecification<DefaultEntity>(p => p.Id != value);
        }
        public static Specification<DefaultEntity> IdGreaterThan(int value) {
            return new DirectSpecification<DefaultEntity>(p => p.Id > value);
        }
        public static Specification<DefaultEntity> IdLessThan(int value) {
            return new DirectSpecification<DefaultEntity>(p => p.Id < value);
        }
		
					public static Specification<DefaultEntity> DeletadoEqual(bool value) {
			return new DirectSpecification<DefaultEntity>(p => p.Deletado == value);
		}
		
	   }
   public partial class DefaultTemplateAggSettingsSpecifications {
				public static Specification<DefaultTemplateAggSettings> UserIdContains(params int[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.UserId));
        }
		public static Specification<DefaultTemplateAggSettings> UserIdNotContains(params int[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => !values.Contains(p.UserId));
        }
		public static Specification<DefaultTemplateAggSettings> UserIdEqual(params int[] values) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.UserId));
        }
        public static Specification<DefaultTemplateAggSettings> UserIdGreaterThanOrEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.UserId >= value);
        }
        public static Specification<DefaultTemplateAggSettings> UserIdLessThanOrEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.UserId <= value);
        }
        public static Specification<DefaultTemplateAggSettings> UserIdNotEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.UserId != value);
        }
        public static Specification<DefaultTemplateAggSettings> UserIdGreaterThan(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.UserId > value);
        }
        public static Specification<DefaultTemplateAggSettings> UserIdLessThan(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.UserId < value);
        }
		
					public static Specification<DefaultTemplateAggSettings> AutoSaveSettingsEnabledEqual(bool value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AutoSaveSettingsEnabled == value);
		}
		
					public static Specification<DefaultTemplateAggSettings> IdExternoContains(string value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<DefaultTemplateAggSettings> IdExternoNotContains(string value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<DefaultTemplateAggSettings> IdExternoStartsWith(string value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<DefaultTemplateAggSettings> IdExternoEqual(string value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<DefaultTemplateAggSettings> IdExternoNotEqual(string value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => p.IdExterno != value);
		}
		public static Specification<DefaultTemplateAggSettings> IdExternoIsNull() {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.IdExterno == null);
        }
		public static Specification<DefaultTemplateAggSettings> IdExternoIsNotNull() {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.IdExterno != null);
        }
		
					public static Specification<DefaultTemplateAggSettings> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.CriadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => !values.Contains(p.CriadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.CriadoEm.Value));
        }
        public static Specification<DefaultTemplateAggSettings> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.CriadoEm >= value);
        }
        public static Specification<DefaultTemplateAggSettings> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.CriadoEm <= value);
        }
        public static Specification<DefaultTemplateAggSettings> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.CriadoEm != value);
        }
        public static Specification<DefaultTemplateAggSettings> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.CriadoEm > value);
        }
        public static Specification<DefaultTemplateAggSettings> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.CriadoEm < value);
        }
		
					public static Specification<DefaultTemplateAggSettings> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => !values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.AtualizadoEm.Value));
        }
        public static Specification<DefaultTemplateAggSettings> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AtualizadoEm >= value);
        }
        public static Specification<DefaultTemplateAggSettings> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AtualizadoEm <= value);
        }
        public static Specification<DefaultTemplateAggSettings> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AtualizadoEm != value);
        }
        public static Specification<DefaultTemplateAggSettings> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AtualizadoEm > value);
        }
        public static Specification<DefaultTemplateAggSettings> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.AtualizadoEm < value);
        }
		
					public static Specification<DefaultTemplateAggSettings> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => !values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<DefaultTemplateAggSettings> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.DeletadoEm.Value));
        }
        public static Specification<DefaultTemplateAggSettings> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.DeletadoEm >= value);
        }
        public static Specification<DefaultTemplateAggSettings> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.DeletadoEm <= value);
        }
        public static Specification<DefaultTemplateAggSettings> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.DeletadoEm != value);
        }
        public static Specification<DefaultTemplateAggSettings> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.DeletadoEm > value);
        }
        public static Specification<DefaultTemplateAggSettings> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.DeletadoEm < value);
        }
		
					public static Specification<DefaultTemplateAggSettings> IdContains(params int[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.Id));
        }
		public static Specification<DefaultTemplateAggSettings> IdNotContains(params int[] values) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => !values.Contains(p.Id));
        }
		public static Specification<DefaultTemplateAggSettings> IdEqual(params int[] values) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => values.Contains(p.Id));
        }
        public static Specification<DefaultTemplateAggSettings> IdGreaterThanOrEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Id >= value);
        }
        public static Specification<DefaultTemplateAggSettings> IdLessThanOrEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Id <= value);
        }
        public static Specification<DefaultTemplateAggSettings> IdNotEqual(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Id != value);
        }
        public static Specification<DefaultTemplateAggSettings> IdGreaterThan(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Id > value);
        }
        public static Specification<DefaultTemplateAggSettings> IdLessThan(int value) {
            return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Id < value);
        }
		
					public static Specification<DefaultTemplateAggSettings> DeletadoEqual(bool value) {
			return new DirectSpecification<DefaultTemplateAggSettings>(p => p.Deletado == value);
		}
		
	   }
}
