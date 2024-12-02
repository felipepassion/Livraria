using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class LivroCreatedEvent : BaseEvent
    {
        public LivroCreatedEvent(ILogRequestContext ctx, Livro data) 
            : base(ctx, data) { }
    }
    public partial class LivroDeletedEvent : BaseEvent
    {
        public LivroDeletedEvent(ILogRequestContext ctx, Livro data) 
            : base(ctx, data) { }
    }
    public partial class LivroDeletedRangeEvent : BaseEvent
    {
        public LivroDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro> data) 
            : base(ctx, data) { }
    }
    public partial class LivroActivatedEvent : BaseEvent
    {
        public LivroActivatedEvent(ILogRequestContext ctx, Livro data) 
            : base(ctx, data) { }
    }
    public partial class LivroUpdatedEvent : BaseEvent
    {
        public LivroUpdatedEvent(ILogRequestContext ctx, Livro data) 
            : base(ctx, data) { }
    }
    public partial class LivroUpdatedRangeEvent : BaseEvent
    {
        public LivroUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro> data) 
            : base(ctx, data) { }
    }
    public partial class LivroDeactivatedEvent : BaseEvent
    {
        public LivroDeactivatedEvent(ILogRequestContext ctx, Livro data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoCreatedEvent : BaseEvent
    {
        public AssuntoCreatedEvent(ILogRequestContext ctx, Assunto data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoDeletedEvent : BaseEvent
    {
        public AssuntoDeletedEvent(ILogRequestContext ctx, Assunto data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoDeletedRangeEvent : BaseEvent
    {
        public AssuntoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Assunto> data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoActivatedEvent : BaseEvent
    {
        public AssuntoActivatedEvent(ILogRequestContext ctx, Assunto data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoUpdatedEvent : BaseEvent
    {
        public AssuntoUpdatedEvent(ILogRequestContext ctx, Assunto data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoUpdatedRangeEvent : BaseEvent
    {
        public AssuntoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Assunto> data) 
            : base(ctx, data) { }
    }
    public partial class AssuntoDeactivatedEvent : BaseEvent
    {
        public AssuntoDeactivatedEvent(ILogRequestContext ctx, Assunto data) 
            : base(ctx, data) { }
    }
    public partial class AutorCreatedEvent : BaseEvent
    {
        public AutorCreatedEvent(ILogRequestContext ctx, Autor data) 
            : base(ctx, data) { }
    }
    public partial class AutorDeletedEvent : BaseEvent
    {
        public AutorDeletedEvent(ILogRequestContext ctx, Autor data) 
            : base(ctx, data) { }
    }
    public partial class AutorDeletedRangeEvent : BaseEvent
    {
        public AutorDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Autor> data) 
            : base(ctx, data) { }
    }
    public partial class AutorActivatedEvent : BaseEvent
    {
        public AutorActivatedEvent(ILogRequestContext ctx, Autor data) 
            : base(ctx, data) { }
    }
    public partial class AutorUpdatedEvent : BaseEvent
    {
        public AutorUpdatedEvent(ILogRequestContext ctx, Autor data) 
            : base(ctx, data) { }
    }
    public partial class AutorUpdatedRangeEvent : BaseEvent
    {
        public AutorUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Autor> data) 
            : base(ctx, data) { }
    }
    public partial class AutorDeactivatedEvent : BaseEvent
    {
        public AutorDeactivatedEvent(ILogRequestContext ctx, Autor data) 
            : base(ctx, data) { }
    }
}
