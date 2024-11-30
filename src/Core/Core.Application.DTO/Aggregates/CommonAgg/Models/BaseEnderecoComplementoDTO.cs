using System.ComponentModel;

namespace Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public interface IBaseAddressComplementoDTO<T>
        where T : IBaseAddressDTO, new()
    {
        public int GrupoEmpresaId { get; set; }

        public abstract int? AddressId { get; set; }

        public abstract string Number { get; set; }

        public abstract string Referencia { get; set; }

        public abstract string TipoAddress { get; set; }

        public abstract string Complemento { get; set; }

        public abstract T Address { get; set; }
    }

    public abstract class BaseAddressComplementoDTO<T> : EntityDTO
        where T : BaseAddressDTO, new()
    {
        public BaseAddressComplementoDTO()
        {
            this.Address = new T();
        }

        public int GrupoEmpresaId { get; set; }

        public abstract int? AddressId { get; set; }

        [DisplayName("Número")] 
        public abstract string Number { get; set; }

        [DisplayName("Referência")] 
        public abstract string Referencia { get; set; }

        [DisplayName("Tipo de Endereço")] 
        public abstract string TipoAddress { get; set; }

        [DisplayName("Complemento")]
        public abstract string Complemento { get; set; }

        public abstract T Address { get; set; }
    }

    public interface IBaseAddressComplemento
    {

    }
}
