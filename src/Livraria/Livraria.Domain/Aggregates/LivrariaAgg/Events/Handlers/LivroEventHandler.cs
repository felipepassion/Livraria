
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Events.Handlers;

using MediatR;
using CrossCutting.Infra.Log.Providers;
using Core.Domain.Aggregates.CommonAgg.Events.Handles;

public partial class LivroEventHandler : BaseEventHandler,
    INotificationHandler<LivroCreatedEvent>,
    INotificationHandler<LivroDeletedEvent>,
    INotificationHandler<LivroUpdatedEvent>,
    INotificationHandler<LivroActivatedEvent>,
    INotificationHandler<LivroDeactivatedEvent>{
    public LivroEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
    public async Task Handle(LivroCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(LivroDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(LivroActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(LivroUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    public async Task Handle(LivroDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
}
