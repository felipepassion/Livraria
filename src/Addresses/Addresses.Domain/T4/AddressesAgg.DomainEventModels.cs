using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class AddressCreatedEvent : BaseEvent
    {
        public AddressCreatedEvent(ILogRequestContext ctx, Address data) 
            : base(ctx, data) { }
    }
    public partial class AddressDeletedEvent : BaseEvent
    {
        public AddressDeletedEvent(ILogRequestContext ctx, Address data) 
            : base(ctx, data) { }
    }
    public partial class AddressDeletedRangeEvent : BaseEvent
    {
        public AddressDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Address> data) 
            : base(ctx, data) { }
    }
    public partial class AddressActivatedEvent : BaseEvent
    {
        public AddressActivatedEvent(ILogRequestContext ctx, Address data) 
            : base(ctx, data) { }
    }
    public partial class AddressUpdatedEvent : BaseEvent
    {
        public AddressUpdatedEvent(ILogRequestContext ctx, Address data) 
            : base(ctx, data) { }
    }
    public partial class AddressUpdatedRangeEvent : BaseEvent
    {
        public AddressUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Address> data) 
            : base(ctx, data) { }
    }
    public partial class AddressDeactivatedEvent : BaseEvent
    {
        public AddressDeactivatedEvent(ILogRequestContext ctx, Address data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsCreatedEvent : BaseEvent
    {
        public AddressesAggSettingsCreatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeletedEvent : BaseEvent
    {
        public AddressesAggSettingsDeletedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeletedRangeEvent : BaseEvent
    {
        public AddressesAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<AddressesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsActivatedEvent : BaseEvent
    {
        public AddressesAggSettingsActivatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsUpdatedEvent : BaseEvent
    {
        public AddressesAggSettingsUpdatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public AddressesAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<AddressesAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class AddressesAggSettingsDeactivatedEvent : BaseEvent
    {
        public AddressesAggSettingsDeactivatedEvent(ILogRequestContext ctx, AddressesAggSettings data) 
            : base(ctx, data) { }
    }
}
