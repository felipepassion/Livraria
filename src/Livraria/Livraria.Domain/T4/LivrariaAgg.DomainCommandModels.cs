using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.CommandModels
{
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

    public partial class CreateLivrariaAggSettingsCommand : BaseRequestableCommand<LivrariaAggSettingsQueryModel, LivrariaAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsDTO data, bool updateIfExists = true, LivrariaAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteLivrariaAggSettingsCommand : BaseDeletionCommand<LivrariaAggSettingsQueryModel>
    {
        public DeleteLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeLivrariaAggSettingsCommand : BaseDeletionCommand<LivrariaAggSettingsQueryModel>
    {
        public DeleteRangeLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeLivrariaAggSettingsCommand : BaseRequestableRangeCommand<LivrariaAggSettingsQueryModel, LivrariaAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeLivrariaAggSettingsCommand(ILogRequestContext ctx, Dictionary<LivrariaAggSettingsQueryModel, LivrariaAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query, LivrariaAggSettingsDTO data)
            : base(ctx, new Dictionary<LivrariaAggSettingsQueryModel, LivrariaAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateLivrariaAggSettingsCommand : BaseRequestableCommand<LivrariaAggSettingsQueryModel, LivrariaAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query, LivrariaAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveLivrariaAggSettingsCommand : LivrariaAggSettingsSearchableCommand
    {
        public ActiveLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveLivrariaAggSettingsCommand : LivrariaAggSettingsSearchableCommand
    {
        public DeactiveLivrariaAggSettingsCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class LivrariaAggSettingsSearchableCommand : BaseSearchableCommand<LivrariaAggSettingsQueryModel> {
        public LivrariaAggSettingsSearchableCommand(ILogRequestContext ctx, LivrariaAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
