namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class AssuntoSpecifications
{
    public static Specification<Assunto> DescricaoContains(string value)
    {
        return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Assunto> DescricaoNotContains(string value)
    {
        return new DirectSpecification<Assunto>(p => !EF.Functions.Like(p.Descricao.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Assunto> DescricaoStartsWith(string value)
    {
        return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.Descricao.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Assunto> DescricaoEqual(string value)
    {
        return new DirectSpecification<Assunto>(p => value.ToLower() == (p.Descricao.ToLower()));
    }
    public static Specification<Assunto> DescricaoNotEqual(string value)
    {
        return new DirectSpecification<Assunto>(p => p.Descricao != value);
    }
    public static Specification<Assunto> DescricaoIsNull()
    {
        return new DirectSpecification<Assunto>(p => p.Descricao == null);
    }
    public static Specification<Assunto> DescricaoIsNotNull()
    {
        return new DirectSpecification<Assunto>(p => p.Descricao != null);
    }


    public static Specification<Assunto> IdExternoContains(string value)
    {
        return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Assunto> IdExternoNotContains(string value)
    {
        return new DirectSpecification<Assunto>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Assunto> IdExternoStartsWith(string value)
    {
        return new DirectSpecification<Assunto>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Assunto> IdExternoEqual(string value)
    {
        return new DirectSpecification<Assunto>(p => value.ToLower() == (p.IdExterno.ToLower()));
    }
    public static Specification<Assunto> IdExternoNotEqual(string value)
    {
        return new DirectSpecification<Assunto>(p => p.IdExterno != value);
    }
    public static Specification<Assunto> IdExternoIsNull()
    {
        return new DirectSpecification<Assunto>(p => p.IdExterno == null);
    }
    public static Specification<Assunto> IdExternoIsNotNull()
    {
        return new DirectSpecification<Assunto>(p => p.IdExterno != null);
    }

    public static Specification<Assunto> CriadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Assunto> CriadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => !values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Assunto> CriadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Assunto> CriadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.CriadoEm >= value);
    }
    public static Specification<Assunto> CriadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.CriadoEm <= value);
    }
    public static Specification<Assunto> CriadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.CriadoEm != value);
    }
    public static Specification<Assunto> CriadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.CriadoEm > value);
    }
    public static Specification<Assunto> CriadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.CriadoEm < value);
    }

    public static Specification<Assunto> AtualizadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Assunto> AtualizadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => !values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Assunto> AtualizadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Assunto> AtualizadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.AtualizadoEm >= value);
    }
    public static Specification<Assunto> AtualizadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.AtualizadoEm <= value);
    }
    public static Specification<Assunto> AtualizadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.AtualizadoEm != value);
    }
    public static Specification<Assunto> AtualizadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.AtualizadoEm > value);
    }
    public static Specification<Assunto> AtualizadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.AtualizadoEm < value);
    }

    public static Specification<Assunto> DeletadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Assunto> DeletadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => !values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Assunto> DeletadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Assunto> DeletadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.DeletadoEm >= value);
    }
    public static Specification<Assunto> DeletadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.DeletadoEm <= value);
    }
    public static Specification<Assunto> DeletadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.DeletadoEm != value);
    }
    public static Specification<Assunto> DeletadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.DeletadoEm > value);
    }
    public static Specification<Assunto> DeletadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Assunto>(p => p.DeletadoEm < value);
    }

    public static Specification<Assunto> IdContains(params int[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.Id));
    }
    public static Specification<Assunto> IdNotContains(params int[] values)
    {
        return new DirectSpecification<Assunto>(p => !values.Contains(p.Id));
    }
    public static Specification<Assunto> IdEqual(params int[] values)
    {
        return new DirectSpecification<Assunto>(p => values.Contains(p.Id));
    }
    public static Specification<Assunto> IdGreaterThanOrEqual(int value)
    {
        return new DirectSpecification<Assunto>(p => p.Id >= value);
    }
    public static Specification<Assunto> IdLessThanOrEqual(int value)
    {
        return new DirectSpecification<Assunto>(p => p.Id <= value);
    }
    public static Specification<Assunto> IdNotEqual(int value)
    {
        return new DirectSpecification<Assunto>(p => p.Id != value);
    }
    public static Specification<Assunto> IdGreaterThan(int value)
    {
        return new DirectSpecification<Assunto>(p => p.Id > value);
    }
    public static Specification<Assunto> IdLessThan(int value)
    {
        return new DirectSpecification<Assunto>(p => p.Id < value);
    }

    public static Specification<Assunto> DeletadoEqual(bool value)
    {
        return new DirectSpecification<Assunto>(p => p.Deletado == value);
    }

}
