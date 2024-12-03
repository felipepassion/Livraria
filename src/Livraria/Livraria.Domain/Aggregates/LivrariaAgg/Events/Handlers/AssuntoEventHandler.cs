namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Events.Handlers;

using MediatR;
using CrossCutting.Infra.Log.Providers;
using Core.Domain.Aggregates.CommonAgg.Events.Handles;

public partial class AssuntoEventHandler : BaseEventHandler,
    INotificationHandler<AssuntoCreatedEvent>,
    INotificationHandler<AssuntoDeletedEvent>,
    INotificationHandler<AssuntoUpdatedEvent>,
    INotificationHandler<AssuntoActivatedEvent>,
    INotificationHandler<AssuntoDeactivatedEvent>{
    public AssuntoEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
    public async Task Handle(AssuntoCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AssuntoDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AssuntoActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AssuntoUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AssuntoDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
}
