using Microsoft.AspNetCore.Mvc;
using Unico.Application.Dtos;
using Unico.Application.Interfaces;

namespace Unico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _service;
        public TarefaController(ITarefaService service)
        {
            _service = service;
        }
        [HttpGet]
        public Object ListAll()
        {
            return _service.ListAll();
        }
        [HttpPost]
        public Object Create([FromBody] TarefaDto tarefaDto)
        {
            return _service.Create(tarefaDto);
        }
        [HttpPut]
        public Object Update([FromBody] TarefaDto tarefaDto)
        {
            return _service.Update(tarefaDto);
        }
        [HttpDelete]
        public Object Delete(Guid Id)
        {
            return _service.Delete(Id);
        }
    }
}
