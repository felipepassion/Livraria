namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Events.Handlers;

using MediatR;
using CrossCutting.Infra.Log.Providers;
using Core.Domain.Aggregates.CommonAgg.Events.Handles;

public partial class AutorEventHandler : BaseEventHandler,
    INotificationHandler<AutorCreatedEvent>,
    INotificationHandler<AutorDeletedEvent>,
    INotificationHandler<AutorUpdatedEvent>,
    INotificationHandler<AutorActivatedEvent>,
    INotificationHandler<AutorDeactivatedEvent>{
    public AutorEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
    public async Task Handle(AutorCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AutorDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AutorActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AutorUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(AutorDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
}
