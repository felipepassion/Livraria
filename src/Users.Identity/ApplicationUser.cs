using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Users.Identity
{
    [Table("aspnetusers")]
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
        public ApplicationUser()
        {
            this.IdExterno = Guid.NewGuid().ToString();
            this.CriadoEm = DateTime.UtcNow;
        }

        public string Name { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Criado em")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [IgnorePropertyT4OnRequest]
        [DisplayName("Atualizado em")]
        public DateTime? AtualizadoEm { get; set; }

        [IgnorePropertyT4OnRequest]
        [DisplayName("Deletado em")]
        public DateTime? DeletadoEm { get; set; }
        
        public string IdExterno { get; set; }

        [IgnorePropertyT4OnRequest]
        public bool Deletado { get; set; }

        //[Column(TypeName = "jsonb"), NotMapped]
        //public List<EventsHistory>? EventsHistory { get; set; }
        public bool NeedResetPassword { get; set; }
        public int? RecoverPasswordCode { get; set; }
        public DateTime? RecoverPasswordCodeDate { get; set; }

        public string GetTitle()
        {
            return string.Empty;
        }

        public string GetTitlePropName()
        {
            return string.Empty;
        }
    }
}
