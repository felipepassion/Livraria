
using CsvHelper.Configuration;
namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
	public partial class AddressCsvMap : ClassMap<Address>
	{
		public AddressCsvMap()
		{
			Map(x=>x.CEP).Name("CEP");Map(x=>x.Logradouro).Name("Logradouro");Map(x=>x.TipoLogradouro).Name("TipoLogradouro");Map(x=>x.Bairro_Distrito).Name("Bairro_Distrito");Map(x=>x.Cidade_Localidade).Name("Cidade_Localidade");Map(x=>x.UF).Name("UF");Map(x=>x.Lat).Name("Lat");Map(x=>x.Lng).Name("Lng");
		}
	}
	public partial class AddressesAggSettingsCsvMap : ClassMap<AddressesAggSettings>
	{
		public AddressesAggSettingsCsvMap()
		{
			Map(x=>x.UserId).Name("UserId");
		}
	}
}
