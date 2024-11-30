        
namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Validators {
    using Requests;
    public partial class LivrariaMealStep1Validator : BaseLivrariaAggValidator<LivrariaMealDTO>
	{
        partial void ConfigureAdditionalValidations() {}
    }
    public partial class LivrariaMealStep2Validator : BaseLivrariaAggValidator<LivrariaMealDTO>
	{
        partial void ConfigureAdditionalValidations() {}
    }
    public partial class LivrariaMealStep3Validator : BaseLivrariaAggValidator<LivrariaMealDTO>
	{
        partial void ConfigureAdditionalValidations() {}
    }
}
