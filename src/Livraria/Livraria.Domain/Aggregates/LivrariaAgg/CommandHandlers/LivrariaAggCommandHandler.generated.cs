

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.CommandHandlers {
    using MediatR;
    using Core.Domain.Aggregates.CommonAgg.Commands.Handles;
    using Core.Domain.Aggregates.CommonAgg.Entities;
    public class BaseLivrariaAggCommandHandler<T> : BaseCommandHandler<T> where T : IEntity {public BaseLivrariaAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
}

        