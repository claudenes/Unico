using Unico.Application.Dtos;

namespace Unico.Application.Interfaces
{
    public interface ITarefaService
    {
        TarefaDto Create(TarefaDto tarefa);
        TarefaDto Read(Guid Id);
        TarefaDto Update(TarefaDto tarefa);
        TarefaDto Delete(Guid Id);
        IEnumerable<TarefaDto> ListAll();

    }
}
