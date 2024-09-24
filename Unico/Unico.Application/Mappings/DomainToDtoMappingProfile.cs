using AutoMapper;
using Unico.Application.Dtos;
using Unico.Domain.Entities;

namespace Unico.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile() 
        { 
            CreateMap<Tarefa,TarefaDto>().ReverseMap();
        }
    }
}
