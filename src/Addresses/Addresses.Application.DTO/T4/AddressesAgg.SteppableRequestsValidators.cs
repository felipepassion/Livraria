using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Validators {
    public class BaseAddressesAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseAddressesAggValidator() : base(){ }
            public BaseAddressesAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Validators 
{
	using Requests;
    public partial class AddressStep1Validator : BaseAddressesAggValidator<AddressDTO>
	{
        public AddressStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.CEP).NotEmpty();RuleFor(Q => Q.Logradouro).NotEmpty();RuleFor(Q => Q.TipoLogradouro).NotEmpty();RuleFor(Q => Q.Bairro_Distrito).NotEmpty();RuleFor(x=>x).MustAsync((x, y) => BeUnique<AddressDTO>(x.ExternalId, "Cidade_Localidade", x.Cidade_Localidade, CancellationToken.None)).WithMessage("Cidade_Localidade já existente.").WithName("Cidade_Localidade");RuleFor(Q => Q.Cidade_Localidade).NotEmpty();RuleFor(Q => Q.UF).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AddressesAggSettingsStep1Validator : BaseAddressesAggValidator<AddressesAggSettingsDTO>
	{
        public AddressesAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AddressesAggSettingsStep2Validator : BaseAddressesAggValidator<AddressesAggSettingsDTO>
	{
        public AddressesAggSettingsStep2Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AddressesAggSettingsStep3Validator : BaseAddressesAggValidator<AddressesAggSettingsDTO>
	{
        public AddressesAggSettingsStep3Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AddressesAggSettingsStep4Validator : BaseAddressesAggValidator<AddressesAggSettingsDTO>
	{
        public AddressesAggSettingsStep4Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
}
