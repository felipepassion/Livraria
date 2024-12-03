using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.Responses;

namespace Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public class BaseCommand : IRequest<DomainResponse>
    {
        public string LoggedUserId { get; set; }
    }
}
