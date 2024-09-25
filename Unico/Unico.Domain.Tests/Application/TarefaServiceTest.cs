using AutoMapper.Configuration.Annotations;
using Unico.Application.Interfaces;
using Unico.Domain.Interfaces;
using NSubstitute;
using Unico.Application.Services;
using Unico.Domain.Tests.Common;
using Xunit;
using FluentValidation;
using FluentAssertions;
using Unico.Application.Dtos;
using Unico.Domain.Tests.Domain;
using Unico.Domain.Entities;

namespace Unico.Domain.Tests.Application
{
    public class TarefaServiceTest
    {
        private readonly ITarefaRepository _repository;
        private readonly ITarefaService _service;

        public TarefaServiceTest()
        {
            _repository = Substitute.For<ITarefaRepository>();
            _service = new TarefaService(_repository, GenerateFakerMapper.AddMapperConfiguration());
        }
        [Fact]
        public void Constructor()
        {
            var result = new TarefaService(_repository, GenerateFakerMapper.AddMapperConfiguration());
            result.Should().NotBeNull();

        }
        [Fact]
        public void Create() 
        {
            TarefaDto tarefaDto = GenerateFakerTarefaDto.CreateTarefaDto();
            Tarefa tarefa = GenerateFakerTarefaDto.CreateTarefa(tarefaDto);
            List<Tarefa> querytarefa = new();
            _repository.ReadAll().Where(x=>x.Id==tarefaDto.Id).Returns(querytarefa);

            var result = _repository.Create(tarefa).Returns(tarefa);
            var result2 = _service.Create(tarefaDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Read()
        {
            TarefaDto tarefaDto = GenerateFakerTarefaDto.CreateTarefaDto();
            Tarefa tarefa = GenerateFakerTarefaDto.CreateTarefa(tarefaDto);
            List<Tarefa> querytarefa = new();
            _repository.ReadAll().Where(x => x.Id == tarefaDto.Id).Returns(querytarefa);

            var result = _repository.ReadById(tarefa.Id).Returns(tarefa);
            var result2 = _service.Read(tarefaDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Delete()
        {
            TarefaDto tarefaDto = GenerateFakerTarefaDto.CreateTarefaDto();
            Tarefa tarefa = GenerateFakerTarefaDto.CreateTarefa(tarefaDto);
            List<Tarefa> querytarefa = new();
            _repository.ReadAll().Where(x => x.Id == tarefaDto.Id).Returns(querytarefa);

            var result = _repository.Delete(tarefa.Id).Returns(tarefa);
            var result2 = _service.Delete(tarefaDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Update()
        {
            TarefaDto tarefaDto = GenerateFakerTarefaDto.CreateTarefaDto();
            Tarefa tarefa = GenerateFakerTarefaDto.CreateTarefa(tarefaDto);
            List<Tarefa> querytarefa = new();
            _repository.ReadAll().Where(x => x.Id == tarefaDto.Id).Returns(querytarefa);

            var result = _repository.Update(tarefa).Returns(tarefa);
            var result2 = _service.Update(tarefaDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            TarefaDto tarefaDto = GenerateFakerTarefaDto.CreateTarefaDto();
            IEnumerable<Tarefa> eTarefa = GenerateFakerTarefaDto.CreateIEnumerableTarefa(tarefaDto,1);
            ICollection<Tarefa> CTarefa = eTarefa.ToList();

            _repository.ReadAll().Returns(CTarefa);


            var result = _service.ListAll();
            result.Should().NotBeNull();
        }
    }
}
