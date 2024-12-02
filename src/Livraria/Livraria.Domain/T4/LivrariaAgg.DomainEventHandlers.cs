using MediatR;
using Niu.Nutri.Core.Domain.Extensions;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.ModelEvents;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.EventHandlers
{
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
    public partial class LivrariaAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<LivrariaAggSettingsCreatedEvent>,
        INotificationHandler<LivrariaAggSettingsDeletedEvent>,
        INotificationHandler<LivrariaAggSettingsUpdatedEvent>,
        INotificationHandler<LivrariaAggSettingsActivatedEvent>,
        INotificationHandler<LivrariaAggSettingsDeactivatedEvent>{
        public LivrariaAggSettingsEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(LivrariaAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(LivrariaAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(LivrariaAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(LivrariaAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(LivrariaAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
