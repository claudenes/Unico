using Microsoft.AspNetCore.Mvc;
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
    }
}
