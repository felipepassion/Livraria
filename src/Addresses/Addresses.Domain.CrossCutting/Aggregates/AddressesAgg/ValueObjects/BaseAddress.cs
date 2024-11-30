using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Niu.Nutri.Addresses.Domain.CrossCuttin.Aggregates.AddressesAgg.ValueObjects
{
    public abstract class BaseAddress : Entity
    {
        [RequiredT4, Title, DisplayName("CEP")]
        public string? CEP { get; set; }

        [RequiredT4, DisplayName("Logradouro")]
        public string? Logradouro { get; set; }

        [RequiredT4, DisplayName("Bairro")]
        public string? Bairro_Distrito { get; set; }

        [RequiredT4, DisplayOnList(order: 3), DisplayName("Cidade / Localidade")]
        public string? Cidade_Localidade { get; set; }

        [RequiredT4, DisplayName("Estado")]
        public string? UF { get; set; }
    }
}
