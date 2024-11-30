using MediatR;
using Niu.Nutri.Core.Domain.Extensions;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.ModelEvents;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.EventHandlers
{
    public partial class AddressEventHandler : BaseEventHandler,
        INotificationHandler<AddressCreatedEvent>,
        INotificationHandler<AddressDeletedEvent>,
        INotificationHandler<AddressUpdatedEvent>,
        INotificationHandler<AddressActivatedEvent>,
        INotificationHandler<AddressDeactivatedEvent>{
        public AddressEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(AddressCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public partial class AddressesAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<AddressesAggSettingsCreatedEvent>,
        INotificationHandler<AddressesAggSettingsDeletedEvent>,
        INotificationHandler<AddressesAggSettingsUpdatedEvent>,
        INotificationHandler<AddressesAggSettingsActivatedEvent>,
        INotificationHandler<AddressesAggSettingsDeactivatedEvent>{
        public AddressesAggSettingsEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(AddressesAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(AddressesAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
