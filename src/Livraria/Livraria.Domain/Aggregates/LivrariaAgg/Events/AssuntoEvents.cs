
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Events;
using Entities;

public partial class AssuntoCreatedEvent : BaseEvent
{
    public AssuntoCreatedEvent(ILogRequestContext ctx, Subject data) 
        : base(ctx, data) { }
}
public partial class AssuntoDeletedEvent : BaseEvent
{
    public AssuntoDeletedEvent(ILogRequestContext ctx, Subject data) 
        : base(ctx, data) { }
}
public partial class AssuntoDeletedRangeEvent : BaseEvent
{
    public AssuntoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Subject> data) 
        : base(ctx, data) { }
}
public partial class AssuntoActivatedEvent : BaseEvent
{
    public AssuntoActivatedEvent(ILogRequestContext ctx, Subject data) 
        : base(ctx, data) { }
}
public partial class AssuntoUpdatedEvent : BaseEvent
{
    public AssuntoUpdatedEvent(ILogRequestContext ctx, Subject data) 
        : base(ctx, data) { }
}
public partial class AssuntoUpdatedRangeEvent : BaseEvent
{
    public AssuntoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Subject> data) 
        : base(ctx, data) { }
}
public partial class AssuntoDeactivatedEvent : BaseEvent
{
    public AssuntoDeactivatedEvent(ILogRequestContext ctx, Subject data) 
        : base(ctx, data) { }
}
