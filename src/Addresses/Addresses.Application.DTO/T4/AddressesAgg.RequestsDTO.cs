

using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Niu.Nutri.Core.Application.DTO.Attributes;

namespace Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests 
{
public partial class AddressDTO : EntityDTO
	{
	    [Title] public  string CEP { get; set; }
	    public  string Logradouro { get; set; }
	    public  string TipoLogradouro { get; set; }
	    public  string Bairro_Distrito { get; set; }
	    public  string Cidade_Localidade { get; set; }
	    public  string UF { get; set; }
	    public  double? Lat { get; set; }
	    public  double? Lng { get; set; }
	}
public partial class AddressesAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  int UserId { get; set; }
	}
}
namespace Niu.Nutri.Addresses.Application.DTO.Aggregates.UsersAgg.Requests 
{
public partial class UserDTO : EntityDTO
	{
	}
}
