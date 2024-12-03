namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands;

using CrossCutting.Infra.Log.Contexts;
using Core.Domain.Aggregates.CommonAgg.Commands;
using Queries.Models; 
using Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests; 
    public partial class CreateAssuntoCommand : BaseRequestableCommand<AssuntoQueryModel, AssuntoDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateAssuntoCommand(ILogRequestContext ctx, AssuntoDTO data, bool updateIfExists = true, AssuntoQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteAssuntoCommand : BaseDeletionCommand<AssuntoQueryModel>
    {
        public DeleteAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeAssuntoCommand : BaseDeletionCommand<AssuntoQueryModel>
    {
        public DeleteRangeAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeAssuntoCommand : BaseRequestableRangeCommand<AssuntoQueryModel, AssuntoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeAssuntoCommand(ILogRequestContext ctx, Dictionary<AssuntoQueryModel, AssuntoDTO> query)
            : base(ctx, query) { }
        public UpdateRangeAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query, AssuntoDTO data)
            : base(ctx, new Dictionary<AssuntoQueryModel, AssuntoDTO> { { query, data } }) { }
    }
    
    public partial class UpdateAssuntoCommand : BaseRequestableCommand<AssuntoQueryModel, AssuntoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query, AssuntoDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveAssuntoCommand : AssuntoSearchableCommand
    {
        public ActiveAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveAssuntoCommand : AssuntoSearchableCommand
    {
        public DeactiveAssuntoCommand(ILogRequestContext ctx, AssuntoQueryModel query)
            : base(ctx, query) { }
    }
    public class AssuntoSearchableCommand : BaseSearchableCommand<AssuntoQueryModel> {
        public AssuntoSearchableCommand(ILogRequestContext ctx, AssuntoQueryModel query)
            : base(ctx, query) { }
    }
