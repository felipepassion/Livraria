﻿
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Queries.Models;

using Core.Api.Queries;
using Enumerations;

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
		public int? EdicaoEqual { get; set; }
		public int? EdicaoNotEqual { get; set; }
		public int[]? EdicaoContains { get; set; }
		public int[]? EdicaoNotContains { get; set; }
		public int? EdicaoSince { get; set; }
		public int? EdicaoUntil { get; set; }
		public int? EdicaoLessThan { get; set; }
		public int? EdicaoGreaterThan { get; set; }
		public int? EdicaoLessThanOrEqual { get; set; }
		public int? EdicaoGreaterThanOrEqual { get; set; }
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