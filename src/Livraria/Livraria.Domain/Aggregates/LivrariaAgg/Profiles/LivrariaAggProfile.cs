using Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles
{
    public partial class LivrariaAggProfile
    {
        partial void ConfigureAdditionalProfiles()
        {
            CreateMap<LivroDTO, Livro>()
                .ForPath(x => x.LivroAutor.Autor, opt => opt.MapFrom(x => x.Autor))
                .ForPath(x => x.LivroAssunto.Assunto, opt => opt.MapFrom(x => x.Assunto));

            CreateMap<Livro, LivroDTO>();
        }
    }
}
