using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
	public partial class AddressListiningProfile : Profile
	{
		public AddressListiningProfile()
		{
			 CreateMap<Address, AddressListiningDTO>();
		}
	}
	public partial class AddressesAggSettingsListiningProfile : Profile
	{
		public AddressesAggSettingsListiningProfile()
		{
			 CreateMap<AddressesAggSettings, AddressesAggSettingsListiningDTO>();
		}
	}
}
