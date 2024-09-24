using AutoMapper;
using Unico.Application.Dtos;
using Unico.Application.Interfaces;
using Unico.Domain.Entities;
using Unico.Domain.Interfaces;

namespace Unico.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repository;
        private readonly IMapper _mapper;

        public TarefaService(ITarefaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TarefaDto Create(TarefaDto tarefa)
        {
            return _mapper.Map<TarefaDto>(_repository.Create(_mapper.Map<Tarefa>(tarefa)));
        }

        public TarefaDto Delete(Guid Id)
        {
            return _mapper.Map<TarefaDto>(_repository.Delete(Id));
        }

        public IEnumerable<TarefaDto> ListAll()
        {
            return _mapper.Map<IEnumerable<TarefaDto>>(_repository.ReadAll());
        }

        public TarefaDto Read(Guid Id)
        {
            return _mapper.Map<TarefaDto>(_repository.ReadById(Id));
        }

        public TarefaDto Update(TarefaDto tarefa)
        {
            return _mapper.Map<TarefaDto>(_repository.Update(_mapper.Map<Tarefa>(tarefa)));
        }
    }
}
