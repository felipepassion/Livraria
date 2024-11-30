using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities
{
    public partial class User : Entity
    {
        /// <summary>
        /// Nome completo do usuário.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
