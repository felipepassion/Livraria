using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Niu.Nutri.Addresses.Domain.CrossCuttin.Aggregates.AddressesAgg.ValueObjects
{
    public abstract class BaseAddressComplemento<T> : Entity
        where T : BaseAddress
    {
        public abstract int? AddressId { get; set; }

        [DisplayName("Número")]
        public abstract string? Number { get; set; }

        [DisplayName("Referência")]
        public abstract string? Referencia { get; set; }

        [DisplayName("Tipo Endereço")]
        public abstract string? TipoAddress { get; set; }

        [DisplayName("Complemento")]
        public abstract string? Complemento { get; set; }

        public abstract T Address { get; set; }
    }
}
