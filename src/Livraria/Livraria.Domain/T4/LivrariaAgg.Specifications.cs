using Niu.Nutri.Core.Domain.Seedwork.Specification;
using Microsoft.EntityFrameworkCore;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications {
	using Entities;
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
		
					public static Specification<Livro> EdicaoContains(params int[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.Edicao.Value));
        }
		public static Specification<Livro> EdicaoNotContains(params int[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.Edicao.Value));
        }
		public static Specification<Livro> EdicaoEqual(params int[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.Edicao.Value));
        }
        public static Specification<Livro> EdicaoGreaterThanOrEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Edicao >= value);
        }
        public static Specification<Livro> EdicaoLessThanOrEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Edicao <= value);
        }
        public static Specification<Livro> EdicaoNotEqual(int value) {
            return new DirectSpecification<Livro>(p => p.Edicao != value);
        }
        public static Specification<Livro> EdicaoGreaterThan(int value) {
            return new DirectSpecification<Livro>(p => p.Edicao > value);
        }
        public static Specification<Livro> EdicaoLessThan(int value) {
            return new DirectSpecification<Livro>(p => p.Edicao < value);
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
		
				
				
					public static Specification<Livro> IdExternoContains(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> IdExternoNotContains(string value) {
			return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Livro> IdExternoStartsWith(string value) {
			return new DirectSpecification<Livro>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Livro> IdExternoEqual(string value) {
			return new DirectSpecification<Livro>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Livro> IdExternoNotEqual(string value) {
			return new DirectSpecification<Livro>(p => p.IdExterno != value);
		}
		public static Specification<Livro> IdExternoIsNull() {
            return new DirectSpecification<Livro>(p => p.IdExterno == null);
        }
		public static Specification<Livro> IdExternoIsNotNull() {
            return new DirectSpecification<Livro>(p => p.IdExterno != null);
        }
		
					public static Specification<Livro> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Livro> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Livro> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.CriadoEm.Value));
        }
        public static Specification<Livro> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CriadoEm >= value);
        }
        public static Specification<Livro> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CriadoEm <= value);
        }
        public static Specification<Livro> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CriadoEm != value);
        }
        public static Specification<Livro> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CriadoEm > value);
        }
        public static Specification<Livro> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.CriadoEm < value);
        }
		
					public static Specification<Livro> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Livro> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Livro> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.AtualizadoEm.Value));
        }
        public static Specification<Livro> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AtualizadoEm >= value);
        }
        public static Specification<Livro> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AtualizadoEm <= value);
        }
        public static Specification<Livro> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AtualizadoEm != value);
        }
        public static Specification<Livro> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AtualizadoEm > value);
        }
        public static Specification<Livro> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.AtualizadoEm < value);
        }
		
					public static Specification<Livro> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Livro> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Livro>(p => !values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Livro> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Livro>(p => values.Contains(p.DeletadoEm.Value));
        }
        public static Specification<Livro> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletadoEm >= value);
        }
        public static Specification<Livro> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletadoEm <= value);
        }
        public static Specification<Livro> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletadoEm != value);
        }
        public static Specification<Livro> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletadoEm > value);
        }
        public static Specification<Livro> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Livro>(p => p.DeletadoEm < value);
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
		
					public static Specification<Livro> DeletadoEqual(bool value) {
			return new DirectSpecification<Livro>(p => p.Deletado == value);
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
		
				
					public static Specification<Assunto> IdExternoContains(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> IdExternoNotContains(string value) {
			return new DirectSpecification<Assunto>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Assunto> IdExternoStartsWith(string value) {
			return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Assunto> IdExternoEqual(string value) {
			return new DirectSpecification<Assunto>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Assunto> IdExternoNotEqual(string value) {
			return new DirectSpecification<Assunto>(p => p.IdExterno != value);
		}
		public static Specification<Assunto> IdExternoIsNull() {
            return new DirectSpecification<Assunto>(p => p.IdExterno == null);
        }
		public static Specification<Assunto> IdExternoIsNotNull() {
            return new DirectSpecification<Assunto>(p => p.IdExterno != null);
        }
		
					public static Specification<Assunto> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Assunto> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Assunto> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.CriadoEm.Value));
        }
        public static Specification<Assunto> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CriadoEm >= value);
        }
        public static Specification<Assunto> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CriadoEm <= value);
        }
        public static Specification<Assunto> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CriadoEm != value);
        }
        public static Specification<Assunto> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CriadoEm > value);
        }
        public static Specification<Assunto> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.CriadoEm < value);
        }
		
					public static Specification<Assunto> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Assunto> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Assunto> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.AtualizadoEm.Value));
        }
        public static Specification<Assunto> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.AtualizadoEm >= value);
        }
        public static Specification<Assunto> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.AtualizadoEm <= value);
        }
        public static Specification<Assunto> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.AtualizadoEm != value);
        }
        public static Specification<Assunto> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.AtualizadoEm > value);
        }
        public static Specification<Assunto> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.AtualizadoEm < value);
        }
		
					public static Specification<Assunto> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Assunto> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Assunto>(p => !values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Assunto> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Assunto>(p => values.Contains(p.DeletadoEm.Value));
        }
        public static Specification<Assunto> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletadoEm >= value);
        }
        public static Specification<Assunto> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletadoEm <= value);
        }
        public static Specification<Assunto> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletadoEm != value);
        }
        public static Specification<Assunto> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletadoEm > value);
        }
        public static Specification<Assunto> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Assunto>(p => p.DeletadoEm < value);
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
		
					public static Specification<Assunto> DeletadoEqual(bool value) {
			return new DirectSpecification<Assunto>(p => p.Deletado == value);
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
		
				
					public static Specification<Autor> IdExternoContains(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> IdExternoNotContains(string value) {
			return new DirectSpecification<Autor>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
		}
		public static Specification<Autor> IdExternoStartsWith(string value) {
			return new DirectSpecification<Autor>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
		}
	
		public static Specification<Autor> IdExternoEqual(string value) {
			return new DirectSpecification<Autor>(p => value.ToLower() == (p.IdExterno.ToLower()));
		}
		public static Specification<Autor> IdExternoNotEqual(string value) {
			return new DirectSpecification<Autor>(p => p.IdExterno != value);
		}
		public static Specification<Autor> IdExternoIsNull() {
            return new DirectSpecification<Autor>(p => p.IdExterno == null);
        }
		public static Specification<Autor> IdExternoIsNotNull() {
            return new DirectSpecification<Autor>(p => p.IdExterno != null);
        }
		
					public static Specification<Autor> CriadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Autor> CriadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.CriadoEm.Value));
        }
		public static Specification<Autor> CriadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.CriadoEm.Value));
        }
        public static Specification<Autor> CriadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CriadoEm >= value);
        }
        public static Specification<Autor> CriadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CriadoEm <= value);
        }
        public static Specification<Autor> CriadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CriadoEm != value);
        }
        public static Specification<Autor> CriadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CriadoEm > value);
        }
        public static Specification<Autor> CriadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.CriadoEm < value);
        }
		
					public static Specification<Autor> AtualizadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Autor> AtualizadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.AtualizadoEm.Value));
        }
		public static Specification<Autor> AtualizadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.AtualizadoEm.Value));
        }
        public static Specification<Autor> AtualizadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.AtualizadoEm >= value);
        }
        public static Specification<Autor> AtualizadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.AtualizadoEm <= value);
        }
        public static Specification<Autor> AtualizadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.AtualizadoEm != value);
        }
        public static Specification<Autor> AtualizadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.AtualizadoEm > value);
        }
        public static Specification<Autor> AtualizadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.AtualizadoEm < value);
        }
		
					public static Specification<Autor> DeletadoEmContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Autor> DeletadoEmNotContains(params System.DateTime[] values) {
            return new DirectSpecification<Autor>(p => !values.Contains(p.DeletadoEm.Value));
        }
		public static Specification<Autor> DeletadoEmEqual(params System.DateTime[] values) {
			return new DirectSpecification<Autor>(p => values.Contains(p.DeletadoEm.Value));
        }
        public static Specification<Autor> DeletadoEmGreaterThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletadoEm >= value);
        }
        public static Specification<Autor> DeletadoEmLessThanOrEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletadoEm <= value);
        }
        public static Specification<Autor> DeletadoEmNotEqual(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletadoEm != value);
        }
        public static Specification<Autor> DeletadoEmGreaterThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletadoEm > value);
        }
        public static Specification<Autor> DeletadoEmLessThan(System.DateTime value) {
            return new DirectSpecification<Autor>(p => p.DeletadoEm < value);
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
		
					public static Specification<Autor> DeletadoEqual(bool value) {
			return new DirectSpecification<Autor>(p => p.Deletado == value);
		}
		
	   }
}
