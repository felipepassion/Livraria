
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Events;
using Entities;

public partial class LivroCreatedEvent : BaseEvent
{
    public LivroCreatedEvent(ILogRequestContext ctx, Book data) 
        : base(ctx, data) { }
}
public partial class LivroDeletedEvent : BaseEvent
{
    public LivroDeletedEvent(ILogRequestContext ctx, Book data) 
        : base(ctx, data) { }
}
public partial class LivroDeletedRangeEvent : BaseEvent
{
    public LivroDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Book> data) 
        : base(ctx, data) { }
}
public partial class LivroActivatedEvent : BaseEvent
{
    public LivroActivatedEvent(ILogRequestContext ctx, Book data) 
        : base(ctx, data) { }
}
public partial class LivroUpdatedEvent : BaseEvent
{
    public LivroUpdatedEvent(ILogRequestContext ctx, Book data) 
        : base(ctx, data) { }
}
public partial class LivroUpdatedRangeEvent : BaseEvent
{
    public LivroUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Book> data) 
        : base(ctx, data) { }
}
public partial class LivroDeactivatedEvent : BaseEvent
{
    public LivroDeactivatedEvent(ILogRequestContext ctx, Book data) 
        : base(ctx, data) { }
}
