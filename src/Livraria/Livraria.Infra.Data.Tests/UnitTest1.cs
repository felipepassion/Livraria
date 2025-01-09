using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories;
using Niu.Nutri.Livraria.Infra.Data.Context;

namespace Livraria.Infra.Data.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Criar_Assunto_Deve_Retornar_Sucesso()
        {
            AssuntoRepository assuntoRespository = CreateAssuntoRepo();

            var randomInt = new Random().Next(1, 1000);
            assuntoRespository.Add(new Subject { Descricao = $"Teste {randomInt}" });
            var result = await assuntoRespository.UnitOfWork.Commit();

            Assert.True(result);
        }

        private static AssuntoRepository CreateAssuntoRepo()
        {
            var fakeMediator = new Mock<IMediator>();
            DbContextOptions<LivrariaAggContext> options = new DbContextOptionsBuilder<LivrariaAggContext>()
                .UseNpgsql("Server=localhost;Port=5432;Database=desafio-basis-db;Pooling=true;User Id=postgres;Password=postgres")
                .Options;
            IServiceProvider fakeProvider = new Mock<IServiceProvider>().Object;

            var fakeContext = new LivrariaAggContext(fakeMediator.Object, options, fakeProvider);

            var assuntoRespository = new AssuntoRepository(fakeContext);
            return assuntoRespository;
        }
    }
}
