using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class LivrariaAggSettingsCreatedEvent : BaseEvent
    {
        public LivrariaAggSettingsCreatedEvent(ILogRequestContext ctx, LivrariaAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsDeletedEvent : BaseEvent
    {
        public LivrariaAggSettingsDeletedEvent(ILogRequestContext ctx, LivrariaAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsDeletedRangeEvent : BaseEvent
    {
        public LivrariaAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<LivrariaAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsActivatedEvent : BaseEvent
    {
        public LivrariaAggSettingsActivatedEvent(ILogRequestContext ctx, LivrariaAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsUpdatedEvent : BaseEvent
    {
        public LivrariaAggSettingsUpdatedEvent(ILogRequestContext ctx, LivrariaAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public LivrariaAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<LivrariaAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class LivrariaAggSettingsDeactivatedEvent : BaseEvent
    {
        public LivrariaAggSettingsDeactivatedEvent(ILogRequestContext ctx, LivrariaAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorCreatedEvent : BaseEvent
    {
        public Livro_AutorCreatedEvent(ILogRequestContext ctx, Livro_Autor data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorDeletedEvent : BaseEvent
    {
        public Livro_AutorDeletedEvent(ILogRequestContext ctx, Livro_Autor data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorDeletedRangeEvent : BaseEvent
    {
        public Livro_AutorDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro_Autor> data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorActivatedEvent : BaseEvent
    {
        public Livro_AutorActivatedEvent(ILogRequestContext ctx, Livro_Autor data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorUpdatedEvent : BaseEvent
    {
        public Livro_AutorUpdatedEvent(ILogRequestContext ctx, Livro_Autor data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorUpdatedRangeEvent : BaseEvent
    {
        public Livro_AutorUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro_Autor> data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AutorDeactivatedEvent : BaseEvent
    {
        public Livro_AutorDeactivatedEvent(ILogRequestContext ctx, Livro_Autor data) 
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
    public partial class Livro_AssuntoCreatedEvent : BaseEvent
    {
        public Livro_AssuntoCreatedEvent(ILogRequestContext ctx, Livro_Assunto data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoDeletedEvent : BaseEvent
    {
        public Livro_AssuntoDeletedEvent(ILogRequestContext ctx, Livro_Assunto data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoDeletedRangeEvent : BaseEvent
    {
        public Livro_AssuntoDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro_Assunto> data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoActivatedEvent : BaseEvent
    {
        public Livro_AssuntoActivatedEvent(ILogRequestContext ctx, Livro_Assunto data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoUpdatedEvent : BaseEvent
    {
        public Livro_AssuntoUpdatedEvent(ILogRequestContext ctx, Livro_Assunto data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoUpdatedRangeEvent : BaseEvent
    {
        public Livro_AssuntoUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro_Assunto> data) 
            : base(ctx, data) { }
    }
    public partial class Livro_AssuntoDeactivatedEvent : BaseEvent
    {
        public Livro_AssuntoDeactivatedEvent(ILogRequestContext ctx, Livro_Assunto data) 
            : base(ctx, data) { }
    }
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
}
