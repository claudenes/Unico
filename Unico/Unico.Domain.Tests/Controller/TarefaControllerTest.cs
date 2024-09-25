using FluentAssertions;
using NSubstitute;
using Unico.API.Controllers;
using Unico.Application.Dtos;
using Unico.Application.Interfaces;
using Unico.Domain.Tests.Domain;

namespace Unico.Domain.Tests.Controller
{
    public class TarefaControllerTest
    {
        private readonly ITarefaService _service;
        private readonly TarefaController _controller;
        public TarefaControllerTest()
        {
            _service = Substitute.For<ITarefaService>();
            _controller = new TarefaController(_service);
        }
        [Fact]
        public void Constructor()
        {
            var result = new TarefaController(_service);
            TarefaDto dto = GenerateFakerTarefaDto.CreateTarefaDto();
            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            TarefaDto dto = GenerateFakerTarefaDto.CreateTarefaDto();
            var result = _controller.ListAll();
            result.Should().NotBeNull();
        }
        [Fact]
        public void Create()
        {
            TarefaDto dto = GenerateFakerTarefaDto.CreateTarefaDto();
            var result = _controller.Create(dto);
            result.Should().BeNull();
        }
        [Fact]
        public void Update()
        {
            TarefaDto dto = GenerateFakerTarefaDto.CreateTarefaDto();
            var result = _controller.Update(dto);
        }
        [Fact]
        public void Delete()
        {
            TarefaDto dto = GenerateFakerTarefaDto.CreateTarefaDto();
            var result = _controller.Delete(dto.Id);
            result.Should().BeNull();
        }
        
    }
}
