using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects
{
    public class ContactNumberDTO
    {
        [Required(ErrorMessage = "'Contact' precisa ser informado")]
        public string Number { get; set; }
    }
}
