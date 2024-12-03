namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Specifications;
using Entities;
using Microsoft.EntityFrameworkCore;
using Core.Domain.Seedwork.Specification;
public partial class AutorSpecifications
{
    public static Specification<Autor> NomeContains(string value)
    {
        return new DirectSpecification<Autor>(p => EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Autor> NomeNotContains(string value)
    {
        return new DirectSpecification<Autor>(p => !EF.Functions.Like(p.Nome.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Autor> NomeStartsWith(string value)
    {
        return new DirectSpecification<Autor>(p => EF.Functions.Like(p.Nome.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Autor> NomeEqual(string value)
    {
        return new DirectSpecification<Autor>(p => value.ToLower() == (p.Nome.ToLower()));
    }
    public static Specification<Autor> NomeNotEqual(string value)
    {
        return new DirectSpecification<Autor>(p => p.Nome != value);
    }
    public static Specification<Autor> NomeIsNull()
    {
        return new DirectSpecification<Autor>(p => p.Nome == null);
    }
    public static Specification<Autor> NomeIsNotNull()
    {
        return new DirectSpecification<Autor>(p => p.Nome != null);
    }


    public static Specification<Autor> IdExternoContains(string value)
    {
        return new DirectSpecification<Autor>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Autor> IdExternoNotContains(string value)
    {
        return new DirectSpecification<Autor>(p => !EF.Functions.Like(p.IdExterno.ToLower(), $"%{value.ToLower()}%"));
    }
    public static Specification<Autor> IdExternoStartsWith(string value)
    {
        return new DirectSpecification<Autor>(p => EF.Functions.Like(p.IdExterno.ToLower(), $"{value.ToLower()}%"));
    }

    public static Specification<Autor> IdExternoEqual(string value)
    {
        return new DirectSpecification<Autor>(p => value.ToLower() == (p.IdExterno.ToLower()));
    }
    public static Specification<Autor> IdExternoNotEqual(string value)
    {
        return new DirectSpecification<Autor>(p => p.IdExterno != value);
    }
    public static Specification<Autor> IdExternoIsNull()
    {
        return new DirectSpecification<Autor>(p => p.IdExterno == null);
    }
    public static Specification<Autor> IdExternoIsNotNull()
    {
        return new DirectSpecification<Autor>(p => p.IdExterno != null);
    }

    public static Specification<Autor> CriadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Autor> CriadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => !values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Autor> CriadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.CriadoEm.Value));
    }
    public static Specification<Autor> CriadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.CriadoEm >= value);
    }
    public static Specification<Autor> CriadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.CriadoEm <= value);
    }
    public static Specification<Autor> CriadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.CriadoEm != value);
    }
    public static Specification<Autor> CriadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.CriadoEm > value);
    }
    public static Specification<Autor> CriadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.CriadoEm < value);
    }

    public static Specification<Autor> AtualizadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Autor> AtualizadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => !values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Autor> AtualizadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.AtualizadoEm.Value));
    }
    public static Specification<Autor> AtualizadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.AtualizadoEm >= value);
    }
    public static Specification<Autor> AtualizadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.AtualizadoEm <= value);
    }
    public static Specification<Autor> AtualizadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.AtualizadoEm != value);
    }
    public static Specification<Autor> AtualizadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.AtualizadoEm > value);
    }
    public static Specification<Autor> AtualizadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.AtualizadoEm < value);
    }

    public static Specification<Autor> DeletadoEmContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Autor> DeletadoEmNotContains(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => !values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Autor> DeletadoEmEqual(params System.DateTime[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.DeletadoEm.Value));
    }
    public static Specification<Autor> DeletadoEmGreaterThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.DeletadoEm >= value);
    }
    public static Specification<Autor> DeletadoEmLessThanOrEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.DeletadoEm <= value);
    }
    public static Specification<Autor> DeletadoEmNotEqual(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.DeletadoEm != value);
    }
    public static Specification<Autor> DeletadoEmGreaterThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.DeletadoEm > value);
    }
    public static Specification<Autor> DeletadoEmLessThan(System.DateTime value)
    {
        return new DirectSpecification<Autor>(p => p.DeletadoEm < value);
    }

    public static Specification<Autor> IdContains(params int[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.Id));
    }
    public static Specification<Autor> IdNotContains(params int[] values)
    {
        return new DirectSpecification<Autor>(p => !values.Contains(p.Id));
    }
    public static Specification<Autor> IdEqual(params int[] values)
    {
        return new DirectSpecification<Autor>(p => values.Contains(p.Id));
    }
    public static Specification<Autor> IdGreaterThanOrEqual(int value)
    {
        return new DirectSpecification<Autor>(p => p.Id >= value);
    }
    public static Specification<Autor> IdLessThanOrEqual(int value)
    {
        return new DirectSpecification<Autor>(p => p.Id <= value);
    }
    public static Specification<Autor> IdNotEqual(int value)
    {
        return new DirectSpecification<Autor>(p => p.Id != value);
    }
    public static Specification<Autor> IdGreaterThan(int value)
    {
        return new DirectSpecification<Autor>(p => p.Id > value);
    }
    public static Specification<Autor> IdLessThan(int value)
    {
        return new DirectSpecification<Autor>(p => p.Id < value);
    }

    public static Specification<Autor> DeletadoEqual(bool value)
    {
        return new DirectSpecification<Autor>(p => p.Deletado == value);
    }

}
