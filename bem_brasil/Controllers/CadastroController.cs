using bem_brasil.DataFinal;
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
            var logado = _operadorRepositorio.Logar(operador);
            if (logado)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["Erro"] = "Houve um erro ao logar!!";
                return RedirectToAction("Login", "Cadastro");
            }
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Login()
        {
            return PartialView();
        }

    }
}
