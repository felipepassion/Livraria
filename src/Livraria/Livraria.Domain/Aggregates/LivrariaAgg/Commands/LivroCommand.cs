namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands;

using CrossCutting.Infra.Log.Contexts;
using Core.Domain.Aggregates.CommonAgg.Commands;
using Queries.Models; 
using Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests; 
    public partial class CreateLivroCommand : BaseRequestableCommand<LivroQueryModel, LivroDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateLivroCommand(ILogRequestContext ctx, LivroDTO data, bool updateIfExists = true, LivroQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteLivroCommand : BaseDeletionCommand<LivroQueryModel>
    {
        public DeleteLivroCommand(ILogRequestContext ctx, LivroQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeLivroCommand : BaseDeletionCommand<LivroQueryModel>
    {
        public DeleteRangeLivroCommand(ILogRequestContext ctx, LivroQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeLivroCommand : BaseRequestableRangeCommand<LivroQueryModel, LivroDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeLivroCommand(ILogRequestContext ctx, Dictionary<LivroQueryModel, LivroDTO> query)
            : base(ctx, query) { }
        public UpdateRangeLivroCommand(ILogRequestContext ctx, LivroQueryModel query, LivroDTO data)
            : base(ctx, new Dictionary<LivroQueryModel, LivroDTO> { { query, data } }) { }
    }
    
    public partial class UpdateLivroCommand : BaseRequestableCommand<LivroQueryModel, LivroDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateLivroCommand(ILogRequestContext ctx, LivroQueryModel query, LivroDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveLivroCommand : LivroSearchableCommand
    {
        public ActiveLivroCommand(ILogRequestContext ctx, LivroQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveLivroCommand : LivroSearchableCommand
    {
        public DeactiveLivroCommand(ILogRequestContext ctx, LivroQueryModel query)
            : base(ctx, query) { }
    }
    public class LivroSearchableCommand : BaseSearchableCommand<LivroQueryModel> {
        public LivroSearchableCommand(ILogRequestContext ctx, LivroQueryModel query)
            : base(ctx, query) { }
    }
