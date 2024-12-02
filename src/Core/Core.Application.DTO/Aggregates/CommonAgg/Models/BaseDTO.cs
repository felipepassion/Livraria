using System.Collections;

namespace Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;

public interface IEntityDTO
{
    public int? Id { get; set; }
    public string? IdExterno { get; set; }
    public DateTime? CriadoEm { get; set; }
}

public class EntityDTO : IEntityDTO, IEqualityComparer
{
    public bool IsCreated => Id.HasValue;

    public int? Id { get; set; }

    public string? IdExterno { get; set; } = Guid.NewGuid().ToString();

    public DateTime? CriadoEm { get; set; }

    public DateTime? AtualizadoEm { get; set; }

    public new bool Equals(object? x, object? y) => (x as IEntityDTO)?.Id == (y as IEntityDTO)?.Id;

    public int GetHashCode(object obj) => (obj as IEntityDTO)?.Id ?? base.GetHashCode();
}
