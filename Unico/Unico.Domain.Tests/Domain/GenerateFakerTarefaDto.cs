using Bogus;
using Unico.Application.Dtos;
using Unico.Domain.Entities;

namespace Unico.Domain.Tests.Domain
{
    internal class GenerateFakerTarefaDto
    {
        private static Faker<TarefaDto> CreateTarefaDtoFaker()
        {
            return new Faker<TarefaDto>().StrictMode(true)
            .RuleFor(x => x.Id, f => f.Random.Guid())
            .RuleFor(x => x.Titulo, f => f.Name.FirstName())
            .RuleFor(x => x.Descricao, f => f.Name.FirstName())
            .RuleFor(x => x.DataVencimento, f => f.Date.Past())
            .RuleFor(x => x.Status, f => f.Name.FirstName());
        }
        private static Faker<Tarefa> CreateTarefaFaker(TarefaDto tarefa)
        {
            return new Faker<Tarefa>().StrictMode(true)
            .RuleFor(x => x.Id, f => tarefa.Id)
            .RuleFor(x => x.Titulo, f => tarefa.Titulo)
            .RuleFor(x => x.Descricao, f => tarefa.Descricao)
            .RuleFor(x => x.DataVencimento, f => tarefa.DataVencimento)
            .RuleFor(x => x.Status, f => tarefa.Status);
        }
        public static TarefaDto CreateTarefaDto()
        {
            return CreateTarefaDtoFaker().Generate(); 
        }
        public static Tarefa CreateTarefa(TarefaDto tarefa)
        {
            return CreateTarefaFaker(tarefa).Generate();
        }
        public static IEnumerable<Tarefa> CreateIEnumerableTarefa(TarefaDto tarefa, int count)
        {
            return CreateTarefaFaker(tarefa).Generate(count);
        }
    }
}
