using AutoMapper;
using Unico.Application.Dtos;
using Unico.Domain.Entities;

namespace Unico.Application.Mappings
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile() 
        {
            CreateMap<TarefaDto, Tarefa>().ReverseMap();
        }
    }
}
