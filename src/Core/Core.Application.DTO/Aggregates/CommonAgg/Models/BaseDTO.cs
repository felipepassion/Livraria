using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Application.DTO.Extensions;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

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

    [NullableProperty]
    public string? IdExterno { get; set; } = Guid.NewGuid().ToString();

    public DateTime? CriadoEm { get; set; }

    public DateTime? AtualizadoEm { get; set; }

    [NullableProperty]
    public string? TitleProperty => this.GetValueWithAttribute<Title>()?.ToString();

    [NullableProperty]
    public string? SubTitle => this.GetValueWithAttribute<Subtitle>()?.ToString();

    [NullableProperty]
    public string? DisplayNameTitle => this.GetFieldInfoByWithAttribute<Title>()?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "Título";

    [NullableProperty]
    public string? DisplayNameSubTitle => this.GetFieldInfoByWithAttribute<Subtitle>()?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property?.Name ?? "SubTítulo";

    [NullableProperty]
    public string? TitlePropertyName => this.GetFieldInfoByWithAttribute<Title>()?.Name;

    [NullableProperty]
    public string? SubTitlePropertyName => this.GetFieldInfoByWithAttribute<Subtitle>()?.Name;

    public new bool Equals(object? x, object? y) => (x as IEntityDTO)?.Id == (y as IEntityDTO)?.Id;

    public int GetHashCode(object obj) => (obj as IEntityDTO)?.Id ?? base.GetHashCode();
}
