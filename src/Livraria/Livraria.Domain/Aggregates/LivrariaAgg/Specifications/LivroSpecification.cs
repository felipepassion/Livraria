namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class LivroSpecifications
{
    public static Specification<Livro> TituloContains(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Titulo.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> TituloNotContains(string value)
    {
        return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.Titulo.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> TituloStartsWith(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Titulo.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Livro> TituloEqual(string value)
    {
        return new DirectSpecification<Livro>(p => value.ToLower() == (p.Titulo.ToLower()));
    }
    public static Specification<Livro> TituloNotEqual(string value)
    {
        return new DirectSpecification<Livro>(p => p.Titulo != value);
    }
    public static Specification<Livro> TituloIsNull()
    {
        return new DirectSpecification<Livro>(p => p.Titulo == null);
    }
    public static Specification<Livro> TituloIsNotNull()
    {
        return new DirectSpecification<Livro>(p => p.Titulo != null);
    }

    public static Specification<Livro> EditoraContains(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Editora.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> EditoraNotContains(string value)
    {
        return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.Editora.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> EditoraStartsWith(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.Editora.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Livro> EditoraEqual(string value)
    {
        return new DirectSpecification<Livro>(p => value.ToLower() == (p.Editora.ToLower()));
    }
    public static Specification<Livro> EditoraNotEqual(string value)
    {
        return new DirectSpecification<Livro>(p => p.Editora != value);
    }
    public static Specification<Livro> EditoraIsNull()
    {
        return new DirectSpecification<Livro>(p => p.Editora == null);
    }
    public static Specification<Livro> EditoraIsNotNull()
    {
        return new DirectSpecification<Livro>(p => p.Editora != null);
    }

    public static Specification<Livro> EdicaoContains(params int[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.Edicao.Value));
    }
    public static Specification<Livro> EdicaoNotContains(params int[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.Edicao.Value));
    }
    public static Specification<Livro> EdicaoEqual(params int[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.Edicao.Value));
    }
    public static Specification<Livro> EdicaoGreaterThanOrEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Edicao >= value);
    }
    public static Specification<Livro> EdicaoLessThanOrEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Edicao <= value);
    }
    public static Specification<Livro> EdicaoNotEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Edicao != value);
    }
    public static Specification<Livro> EdicaoGreaterThan(int value)
    {
        return new DirectSpecification<Livro>(p => p.Edicao > value);
    }
    public static Specification<Livro> EdicaoLessThan(int value)
    {
        return new DirectSpecification<Livro>(p => p.Edicao < value);
    }

    public static Specification<Livro> AnoPublicacaoContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.AnoPublicacao));
    }
    public static Specification<Livro> AnoPublicacaoNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.AnoPublicacao));
    }
    public static Specification<Livro> AnoPublicacaoEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.AnoPublicacao));
    }
    public static Specification<Livro> AnoPublicacaoGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AnoPublicacao >= value);
    }
    public static Specification<Livro> AnoPublicacaoLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AnoPublicacao <= value);
    }
    public static Specification<Livro> AnoPublicacaoNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AnoPublicacao != value);
    }
    public static Specification<Livro> AnoPublicacaoGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AnoPublicacao > value);
    }
    public static Specification<Livro> AnoPublicacaoLessThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AnoPublicacao < value);
    }



    public static Specification<Livro> IdExternoContains(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> IdExternoNotContains(string value)
    {
        return new DirectSpecification<Livro>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Livro> IdExternoStartsWith(string value)
    {
        return new DirectSpecification<Livro>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Livro> IdExternoEqual(string value)
    {
        return new DirectSpecification<Livro>(p => value.ToLower() == (p.IdExterno.ToLower()));
    }
    public static Specification<Livro> IdExternoNotEqual(string value)
    {
        return new DirectSpecification<Livro>(p => p.IdExterno != value);
    }
    public static Specification<Livro> IdExternoIsNull()
    {
        return new DirectSpecification<Livro>(p => p.IdExterno == null);
    }
    public static Specification<Livro> IdExternoIsNotNull()
    {
        return new DirectSpecification<Livro>(p => p.IdExterno != null);
    }

    public static Specification<Livro> CriadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Livro> CriadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Livro> CriadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Livro> CriadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.CriadoEm >= value);
    }
    public static Specification<Livro> CriadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.CriadoEm <= value);
    }
    public static Specification<Livro> CriadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.CriadoEm != value);
    }
    public static Specification<Livro> CriadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.CriadoEm > value);
    }
    public static Specification<Livro> CriadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.CriadoEm < value);
    }

    public static Specification<Livro> AtualizadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Livro> AtualizadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Livro> AtualizadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Livro> AtualizadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AtualizadoEm >= value);
    }
    public static Specification<Livro> AtualizadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AtualizadoEm <= value);
    }
    public static Specification<Livro> AtualizadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AtualizadoEm != value);
    }
    public static Specification<Livro> AtualizadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AtualizadoEm > value);
    }
    public static Specification<Livro> AtualizadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.AtualizadoEm < value);
    }

    public static Specification<Livro> DeletadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Livro> DeletadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Livro> DeletadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Livro> DeletadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.DeletadoEm >= value);
    }
    public static Specification<Livro> DeletadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.DeletadoEm <= value);
    }
    public static Specification<Livro> DeletadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.DeletadoEm != value);
    }
    public static Specification<Livro> DeletadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.DeletadoEm > value);
    }
    public static Specification<Livro> DeletadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Livro>(p => p.DeletadoEm < value);
    }

    public static Specification<Livro> IdContains(params int[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.Id));
    }
    public static Specification<Livro> IdNotContains(params int[] values)
    {
        return new DirectSpecification<Livro>(p => !values.Contains(p.Id));
    }
    public static Specification<Livro> IdEqual(params int[] values)
    {
        return new DirectSpecification<Livro>(p => values.Contains(p.Id));
    }
    public static Specification<Livro> IdGreaterThanOrEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Id >= value);
    }
    public static Specification<Livro> IdLessThanOrEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Id <= value);
    }
    public static Specification<Livro> IdNotEqual(int value)
    {
        return new DirectSpecification<Livro>(p => p.Id != value);
    }
    public static Specification<Livro> IdGreaterThan(int value)
    {
        return new DirectSpecification<Livro>(p => p.Id > value);
    }
    public static Specification<Livro> IdLessThan(int value)
    {
        return new DirectSpecification<Livro>(p => p.Id < value);
    }

    public static Specification<Livro> DeletadoEqual(bool value)
    {
        return new DirectSpecification<Livro>(p => p.Deletado == value);
    }

}
