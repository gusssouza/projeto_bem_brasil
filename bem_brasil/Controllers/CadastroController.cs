using bem_brasil.Data;
using bem_brasil.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ILogger<CadastroController> _logger;
        private readonly IOperadorRepositorio _operadorRepositorio;

        public CadastroController(ILogger<CadastroController> logger, IOperadorRepositorio operadorRepositorio)
        {
            _logger = logger;
            _operadorRepositorio = operadorRepositorio;
        }

        [HttpPost]
        public IActionResult CadastrarOperador(Operador operador)
        {
            _operadorRepositorio.AdicionarOperador(operador);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Logar(Operador operador)
        {
            _operadorRepositorio.Logar(operador);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
