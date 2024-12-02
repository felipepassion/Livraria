namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.CommandHandlers
{
    using Entities;
    using Microsoft.Extensions.DependencyInjection;
    using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
    using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;
    using System.Threading.Tasks;

    public partial class LivroCommandHandler : BaseLivrariaAggCommandHandler<Livro>
    {
        public async override Task<DomainResponse> OnCreateAsync(Livro entity)
        {
            var assuntoRepo = _serviceProvider.GetRequiredService<IAssuntoRepository>();
            var autorRepo = _serviceProvider.GetRequiredService<IAutorRepository>();

            var autoresIds = entity.Autores.Select(x => x.Id);
            var assuntosIds = entity.Assuntos.Select(x => x.Id);

            entity.Autores = (await autorRepo.SelectAllAsync(filter: x => autoresIds.Contains(x.Id), selector: x => x)).ToList();
            entity.Assuntos = (await assuntoRepo.SelectAllAsync(filter: x => assuntosIds.Contains(x.Id), selector: x => x)).ToList();

            return await base.OnCreateAsync(entity);
        }
    }
}
