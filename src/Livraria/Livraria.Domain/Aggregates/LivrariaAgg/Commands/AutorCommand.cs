namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands;

using CrossCutting.Infra.Log.Contexts;
using Core.Domain.Aggregates.CommonAgg.Commands;
using Queries.Models; 
using Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests; 
    public partial class CreateAutorCommand : BaseRequestableCommand<AutorQueryModel, AutorDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateAutorCommand(ILogRequestContext ctx, AutorDTO data, bool updateIfExists = true, AutorQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteAutorCommand : BaseDeletionCommand<AutorQueryModel>
    {
        public DeleteAutorCommand(ILogRequestContext ctx, AutorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeAutorCommand : BaseDeletionCommand<AutorQueryModel>
    {
        public DeleteRangeAutorCommand(ILogRequestContext ctx, AutorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeAutorCommand : BaseRequestableRangeCommand<AutorQueryModel, AutorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeAutorCommand(ILogRequestContext ctx, Dictionary<AutorQueryModel, AutorDTO> query)
            : base(ctx, query) { }
        public UpdateRangeAutorCommand(ILogRequestContext ctx, AutorQueryModel query, AutorDTO data)
            : base(ctx, new Dictionary<AutorQueryModel, AutorDTO> { { query, data } }) { }
    }
    
    public partial class UpdateAutorCommand : BaseRequestableCommand<AutorQueryModel, AutorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateAutorCommand(ILogRequestContext ctx, AutorQueryModel query, AutorDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveAutorCommand : AutorSearchableCommand
    {
        public ActiveAutorCommand(ILogRequestContext ctx, AutorQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveAutorCommand : AutorSearchableCommand
    {
        public DeactiveAutorCommand(ILogRequestContext ctx, AutorQueryModel query)
            : base(ctx, query) { }
    }
    public class AutorSearchableCommand : BaseSearchableCommand<AutorQueryModel> {
        public AutorSearchableCommand(ILogRequestContext ctx, AutorQueryModel query)
            : base(ctx, query) { }
    }
