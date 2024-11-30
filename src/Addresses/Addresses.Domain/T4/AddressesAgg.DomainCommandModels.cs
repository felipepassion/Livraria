using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.CommandModels
{
    using Queries.Models; 
    using Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests; 
    public partial class CreateAddressCommand : BaseRequestableCommand<AddressQueryModel, AddressDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateAddressCommand(ILogRequestContext ctx, AddressDTO data, bool updateIfExists = true, AddressQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteAddressCommand : BaseDeletionCommand<AddressQueryModel>
    {
        public DeleteAddressCommand(ILogRequestContext ctx, AddressQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeAddressCommand : BaseDeletionCommand<AddressQueryModel>
    {
        public DeleteRangeAddressCommand(ILogRequestContext ctx, AddressQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeAddressCommand : BaseRequestableRangeCommand<AddressQueryModel, AddressDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeAddressCommand(ILogRequestContext ctx, Dictionary<AddressQueryModel, AddressDTO> query)
            : base(ctx, query) { }
        public UpdateRangeAddressCommand(ILogRequestContext ctx, AddressQueryModel query, AddressDTO data)
            : base(ctx, new Dictionary<AddressQueryModel, AddressDTO> { { query, data } }) { }
    }
    
    public partial class UpdateAddressCommand : BaseRequestableCommand<AddressQueryModel, AddressDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateAddressCommand(ILogRequestContext ctx, AddressQueryModel query, AddressDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveAddressCommand : AddressSearchableCommand
    {
        public ActiveAddressCommand(ILogRequestContext ctx, AddressQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveAddressCommand : AddressSearchableCommand
    {
        public DeactiveAddressCommand(ILogRequestContext ctx, AddressQueryModel query)
            : base(ctx, query) { }
    }
    public class AddressSearchableCommand : BaseSearchableCommand<AddressQueryModel> {
        public AddressSearchableCommand(ILogRequestContext ctx, AddressQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateAddressesAggSettingsCommand : BaseRequestableCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsDTO data, bool updateIfExists = true, AddressesAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteAddressesAggSettingsCommand : BaseDeletionCommand<AddressesAggSettingsQueryModel>
    {
        public DeleteAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeAddressesAggSettingsCommand : BaseDeletionCommand<AddressesAggSettingsQueryModel>
    {
        public DeleteRangeAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeAddressesAggSettingsCommand : BaseRequestableRangeCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeAddressesAggSettingsCommand(ILogRequestContext ctx, Dictionary<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, AddressesAggSettingsDTO data)
            : base(ctx, new Dictionary<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateAddressesAggSettingsCommand : BaseRequestableCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, AddressesAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveAddressesAggSettingsCommand : AddressesAggSettingsSearchableCommand
    {
        public ActiveAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveAddressesAggSettingsCommand : AddressesAggSettingsSearchableCommand
    {
        public DeactiveAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class AddressesAggSettingsSearchableCommand : BaseSearchableCommand<AddressesAggSettingsQueryModel> {
        public AddressesAggSettingsSearchableCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
