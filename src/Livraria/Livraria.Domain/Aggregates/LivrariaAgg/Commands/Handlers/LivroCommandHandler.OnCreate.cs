namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands.Handlers
{
    using Entities;
    using Microsoft.Extensions.DependencyInjection;
    using Niu.Nutri.Core.Application.DTO.Http.Models.Responses;
    using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;
    using System.Threading.Tasks;

    public partial class LivroCommandHandler : BaseLivrariaAggCommandHandler<Book>
    {
        public async override Task<DomainResponse> OnCreateAsync(Book entity)
        {
            var assuntoRepo = _serviceProvider.GetRequiredService<IAssuntoRepository>();
            var autorRepo = _serviceProvider.GetRequiredService<IAutorRepository>();

            var autoresIds = entity.Authors.Select(x => x.Id);
            var assuntosIds = entity.Subjects.Select(x => x.Id);

            entity.Authors = (await autorRepo.SelectAllAsync(filter: x => autoresIds.Contains(x.Id), selector: x => x)).ToList();
            entity.Subjects = (await assuntoRepo.SelectAllAsync(filter: x => assuntosIds.Contains(x.Id), selector: x => x)).ToList();

            return await base.OnCreateAsync(entity);
        }
    }
}
