using Unico.Domain.Entities;
using Unico.Domain.Interfaces;
using Unico.Infra.Data.Context;

namespace Unico.Infra.Data.Repositories
{
    public class TarefaRepository : ResourceRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationDbContext context) : base(context) { }
    }
}
