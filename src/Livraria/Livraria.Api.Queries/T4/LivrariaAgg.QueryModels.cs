﻿
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Queries.Models
{
    using Core.Api.Queries;
	using Enumerations;
	public partial class LivrariaAggSettingsQueryModel : BaseQueryModel {
		public int? UserIdEqual { get; set; }
		public int? UserIdNotEqual { get; set; }
		public int[]? UserIdContains { get; set; }
		public int[]? UserIdNotContains { get; set; }
		public int? UserIdSince { get; set; }
		public int? UserIdUntil { get; set; }
		public int? UserIdLessThan { get; set; }
		public int? UserIdGreaterThan { get; set; }
		public int? UserIdLessThanOrEqual { get; set; }
		public int? UserIdGreaterThanOrEqual { get; set; }
		public bool? AutoSaveSettingsEnabledEqual { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class Livro_AutorQueryModel : BaseQueryModel {
		public int? Livro_CodlEqual { get; set; }
		public int? Livro_CodlNotEqual { get; set; }
		public int[]? Livro_CodlContains { get; set; }
		public int[]? Livro_CodlNotContains { get; set; }
		public int? Livro_CodlSince { get; set; }
		public int? Livro_CodlUntil { get; set; }
		public int? Livro_CodlLessThan { get; set; }
		public int? Livro_CodlGreaterThan { get; set; }
		public int? Livro_CodlLessThanOrEqual { get; set; }
		public int? Livro_CodlGreaterThanOrEqual { get; set; }
		public int? Autor_CodAutEqual { get; set; }
		public int? Autor_CodAutNotEqual { get; set; }
		public int[]? Autor_CodAutContains { get; set; }
		public int[]? Autor_CodAutNotContains { get; set; }
		public int? Autor_CodAutSince { get; set; }
		public int? Autor_CodAutUntil { get; set; }
		public int? Autor_CodAutLessThan { get; set; }
		public int? Autor_CodAutGreaterThan { get; set; }
		public int? Autor_CodAutLessThanOrEqual { get; set; }
		public int? Autor_CodAutGreaterThanOrEqual { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class AutorQueryModel : BaseQueryModel {
		public int? CodAuEqual { get; set; }
		public int? CodAuNotEqual { get; set; }
		public int[]? CodAuContains { get; set; }
		public int[]? CodAuNotContains { get; set; }
		public int? CodAuSince { get; set; }
		public int? CodAuUntil { get; set; }
		public int? CodAuLessThan { get; set; }
		public int? CodAuGreaterThan { get; set; }
		public int? CodAuLessThanOrEqual { get; set; }
		public int? CodAuGreaterThanOrEqual { get; set; }
		public string? NomeEqual { get; set; }
		public string? NomeNotEqual { get; set; }
		public string? NomeContains { get; set; }
		public string? NomeNotContains { get; set; }
		public string? NomeStartsWith { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class AssuntoQueryModel : BaseQueryModel {
		public int? CodAsEqual { get; set; }
		public int? CodAsNotEqual { get; set; }
		public int[]? CodAsContains { get; set; }
		public int[]? CodAsNotContains { get; set; }
		public int? CodAsSince { get; set; }
		public int? CodAsUntil { get; set; }
		public int? CodAsLessThan { get; set; }
		public int? CodAsGreaterThan { get; set; }
		public int? CodAsLessThanOrEqual { get; set; }
		public int? CodAsGreaterThanOrEqual { get; set; }
		public string? DescricaoEqual { get; set; }
		public string? DescricaoNotEqual { get; set; }
		public string? DescricaoContains { get; set; }
		public string? DescricaoNotContains { get; set; }
		public string? DescricaoStartsWith { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class Livro_AssuntoQueryModel : BaseQueryModel {
		public int? Livro_CodlEqual { get; set; }
		public int? Livro_CodlNotEqual { get; set; }
		public int[]? Livro_CodlContains { get; set; }
		public int[]? Livro_CodlNotContains { get; set; }
		public int? Livro_CodlSince { get; set; }
		public int? Livro_CodlUntil { get; set; }
		public int? Livro_CodlLessThan { get; set; }
		public int? Livro_CodlGreaterThan { get; set; }
		public int? Livro_CodlLessThanOrEqual { get; set; }
		public int? Livro_CodlGreaterThanOrEqual { get; set; }
		public int? Assunto_CodAutEqual { get; set; }
		public int? Assunto_CodAutNotEqual { get; set; }
		public int[]? Assunto_CodAutContains { get; set; }
		public int[]? Assunto_CodAutNotContains { get; set; }
		public int? Assunto_CodAutSince { get; set; }
		public int? Assunto_CodAutUntil { get; set; }
		public int? Assunto_CodAutLessThan { get; set; }
		public int? Assunto_CodAutGreaterThan { get; set; }
		public int? Assunto_CodAutLessThanOrEqual { get; set; }
		public int? Assunto_CodAutGreaterThanOrEqual { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
	public partial class LivroQueryModel : BaseQueryModel {
		public string? TituloEqual { get; set; }
		public string? TituloNotEqual { get; set; }
		public string? TituloContains { get; set; }
		public string? TituloNotContains { get; set; }
		public string? TituloStartsWith { get; set; }
		public string? EditoraEqual { get; set; }
		public string? EditoraNotEqual { get; set; }
		public string? EditoraContains { get; set; }
		public string? EditoraNotContains { get; set; }
		public string? EditoraStartsWith { get; set; }
		public string? EdicaoEqual { get; set; }
		public string? EdicaoNotEqual { get; set; }
		public string? EdicaoContains { get; set; }
		public string? EdicaoNotContains { get; set; }
		public string? EdicaoStartsWith { get; set; }
		public System.DateTime? AnoPublicacaoEqual { get; set; }
		public System.DateTime? AnoPublicacaoNotEqual { get; set; }
		public System.DateTime[]? AnoPublicacaoContains { get; set; }
		public System.DateTime[]? AnoPublicacaoNotContains { get; set; }
		public System.DateTime? AnoPublicacaoSince { get; set; }
		public System.DateTime? AnoPublicacaoUntil { get; set; }
		public System.DateTime? AnoPublicacaoLessThan { get; set; }
		public System.DateTime? AnoPublicacaoGreaterThan { get; set; }
		public System.DateTime? AnoPublicacaoLessThanOrEqual { get; set; }
		public System.DateTime? AnoPublicacaoGreaterThanOrEqual { get; set; }
		public string? ExternalIdEqual { get; set; }
		public string? ExternalIdNotEqual { get; set; }
		public string? ExternalIdContains { get; set; }
		public string? ExternalIdNotContains { get; set; }
		public string? ExternalIdStartsWith { get; set; }
		public System.DateTime? CreatedAtEqual { get; set; }
		public System.DateTime? CreatedAtNotEqual { get; set; }
		public System.DateTime[]? CreatedAtContains { get; set; }
		public System.DateTime[]? CreatedAtNotContains { get; set; }
		public System.DateTime? CreatedAtSince { get; set; }
		public System.DateTime? CreatedAtUntil { get; set; }
		public System.DateTime? CreatedAtLessThan { get; set; }
		public System.DateTime? CreatedAtGreaterThan { get; set; }
		public System.DateTime? CreatedAtLessThanOrEqual { get; set; }
		public System.DateTime? CreatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtEqual { get; set; }
		public System.DateTime? UpdatedAtNotEqual { get; set; }
		public System.DateTime[]? UpdatedAtContains { get; set; }
		public System.DateTime[]? UpdatedAtNotContains { get; set; }
		public System.DateTime? UpdatedAtSince { get; set; }
		public System.DateTime? UpdatedAtUntil { get; set; }
		public System.DateTime? UpdatedAtLessThan { get; set; }
		public System.DateTime? UpdatedAtGreaterThan { get; set; }
		public System.DateTime? UpdatedAtLessThanOrEqual { get; set; }
		public System.DateTime? UpdatedAtGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletedAtEqual { get; set; }
		public System.DateTime? DeletedAtNotEqual { get; set; }
		public System.DateTime[]? DeletedAtContains { get; set; }
		public System.DateTime[]? DeletedAtNotContains { get; set; }
		public System.DateTime? DeletedAtSince { get; set; }
		public System.DateTime? DeletedAtUntil { get; set; }
		public System.DateTime? DeletedAtLessThan { get; set; }
		public System.DateTime? DeletedAtGreaterThan { get; set; }
		public System.DateTime? DeletedAtLessThanOrEqual { get; set; }
		public System.DateTime? DeletedAtGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? IsDeletedEqual { get; set; }
	}
}
