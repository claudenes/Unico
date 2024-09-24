using Microsoft.AspNetCore.Mvc;
using Unico.Application.Interfaces;

namespace Unico.WebUI.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaService _service;
        public TarefaController(ITarefaService service)
        {
            _service = service;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var tarefas = _service.ListAll();
            return View(tarefas);
        }
    }
}
