namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Queries.Models;

using Core.Api.Queries;
using Enumerations;

public partial class AutorQueryModel : BaseQueryModel {
		public string? NomeEqual { get; set; }
		public string? NomeNotEqual { get; set; }
		public string? NomeContains { get; set; }
		public string? NomeNotContains { get; set; }
		public string? NomeStartsWith { get; set; }
		public string? IdExternoEqual { get; set; }
		public string? IdExternoNotEqual { get; set; }
		public string? IdExternoContains { get; set; }
		public string? IdExternoNotContains { get; set; }
		public string? IdExternoStartsWith { get; set; }
		public System.DateTime? CriadoEmEqual { get; set; }
		public System.DateTime? CriadoEmNotEqual { get; set; }
		public System.DateTime[]? CriadoEmContains { get; set; }
		public System.DateTime[]? CriadoEmNotContains { get; set; }
		public System.DateTime? CriadoEmSince { get; set; }
		public System.DateTime? CriadoEmUntil { get; set; }
		public System.DateTime? CriadoEmLessThan { get; set; }
		public System.DateTime? CriadoEmGreaterThan { get; set; }
		public System.DateTime? CriadoEmLessThanOrEqual { get; set; }
		public System.DateTime? CriadoEmGreaterThanOrEqual { get; set; }
		public System.DateTime? AtualizadoEmEqual { get; set; }
		public System.DateTime? AtualizadoEmNotEqual { get; set; }
		public System.DateTime[]? AtualizadoEmContains { get; set; }
		public System.DateTime[]? AtualizadoEmNotContains { get; set; }
		public System.DateTime? AtualizadoEmSince { get; set; }
		public System.DateTime? AtualizadoEmUntil { get; set; }
		public System.DateTime? AtualizadoEmLessThan { get; set; }
		public System.DateTime? AtualizadoEmGreaterThan { get; set; }
		public System.DateTime? AtualizadoEmLessThanOrEqual { get; set; }
		public System.DateTime? AtualizadoEmGreaterThanOrEqual { get; set; }
		public System.DateTime? DeletadoEmEqual { get; set; }
		public System.DateTime? DeletadoEmNotEqual { get; set; }
		public System.DateTime[]? DeletadoEmContains { get; set; }
		public System.DateTime[]? DeletadoEmNotContains { get; set; }
		public System.DateTime? DeletadoEmSince { get; set; }
		public System.DateTime? DeletadoEmUntil { get; set; }
		public System.DateTime? DeletadoEmLessThan { get; set; }
		public System.DateTime? DeletadoEmGreaterThan { get; set; }
		public System.DateTime? DeletadoEmLessThanOrEqual { get; set; }
		public System.DateTime? DeletadoEmGreaterThanOrEqual { get; set; }
		public int? IdEqual { get; set; }
		public int? IdNotEqual { get; set; }
		public int[]? IdContains { get; set; }
		public int[]? IdNotContains { get; set; }
		public bool? DeletadoEqual { get; set; }
	}
