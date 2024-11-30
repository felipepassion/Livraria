using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Validators {
    public class BaseLivrariaAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseLivrariaAggValidator() : base(){ }
            public BaseLivrariaAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Validators 
{
	using Requests;
    public partial class Livro_AutorStep1Validator : BaseLivrariaAggValidator<Livro_AutorDTO>
	{
        public Livro_AutorStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Livro.AnoPublicacao).NotEmpty();RuleFor(Q => Q.Livro.Assunto);RuleFor(Q => Q.Livro.Assunto.CodAs);RuleFor(Q => Q.Livro.Assunto.Descricao);RuleFor(Q => Q.Livro.Edicao).NotEmpty();RuleFor(Q => Q.Livro.Editora).NotEmpty();RuleFor(Q => Q.Livro.Titulo).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class LivroStep1Validator : BaseLivrariaAggValidator<LivroDTO>
	{
        public LivroStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Titulo).NotEmpty();RuleFor(Q => Q.Editora).NotEmpty();RuleFor(Q => Q.Edicao).NotEmpty();RuleFor(Q => Q.AnoPublicacao).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AssuntoStep1Validator : BaseLivrariaAggValidator<AssuntoDTO>
	{
        public AssuntoStep1Validator(HttpClient db)
                    : base(db)
        {
            
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class Livro_AssuntoStep1Validator : BaseLivrariaAggValidator<Livro_AssuntoDTO>
	{
        public Livro_AssuntoStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Livro_Codl).NotEmpty();RuleFor(Q => Q.Assunto_CodAut).NotEmpty();RuleFor(Q => Q.Livro.AnoPublicacao).NotEmpty();RuleFor(Q => Q.Livro.Autor);RuleFor(Q => Q.Livro.Autor.CodAu);RuleFor(Q => Q.Livro.Autor.Nome);RuleFor(Q => Q.Livro.Edicao).NotEmpty();RuleFor(Q => Q.Livro.Editora).NotEmpty();RuleFor(Q => Q.Livro.Titulo).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class AutorStep1Validator : BaseLivrariaAggValidator<AutorDTO>
	{
        public AutorStep1Validator(HttpClient db)
                    : base(db)
        {
            
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class LivrariaAggSettingsStep1Validator : BaseLivrariaAggValidator<LivrariaAggSettingsDTO>
	{
        public LivrariaAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
}
