using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles
{
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Entities;
	public partial class LivrariaAggSettingsListiningProfile : Profile
	{
		public LivrariaAggSettingsListiningProfile()
		{
			 CreateMap<LivrariaAggSettings, LivrariaAggSettingsListiningDTO>();
		}
	}
	public partial class Livro_AutorListiningProfile : Profile
	{
		public Livro_AutorListiningProfile()
		{
			 CreateMap<Livro_Autor, Livro_AutorListiningDTO>();
		}
	}
	public partial class AutorListiningProfile : Profile
	{
		public AutorListiningProfile()
		{
			 CreateMap<Autor, AutorListiningDTO>();
		}
	}
	public partial class AssuntoListiningProfile : Profile
	{
		public AssuntoListiningProfile()
		{
			 CreateMap<Assunto, AssuntoListiningDTO>();
		}
	}
	public partial class Livro_AssuntoListiningProfile : Profile
	{
		public Livro_AssuntoListiningProfile()
		{
			 CreateMap<Livro_Assunto, Livro_AssuntoListiningDTO>();
		}
	}
	public partial class LivroListiningProfile : Profile
	{
		public LivroListiningProfile()
		{
			 CreateMap<Livro, LivroListiningDTO>();
		}
	}
}
