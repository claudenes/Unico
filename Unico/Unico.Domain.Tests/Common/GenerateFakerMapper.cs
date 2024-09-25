using AutoMapper;
using Unico.Application.Dtos;
using Unico.Domain.Entities;

namespace Unico.Domain.Tests.Common
{
    public class GenerateFakerMapper
    {
        public static IMapper AddMapperConfiguration()
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Tarefa, TarefaDto>().ReverseMap();

            });
            IMapper mapper = new Mapper(autoMapperConfig);
            return mapper;
        }
    }
}
