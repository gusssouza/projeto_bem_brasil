using bem_brasil.DataDb;
using bem_brasil.Models;
using bem_brasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace bem_brasil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOperadorRepositorio _operadorRepositorio;

        public HomeController(ILogger<HomeController> logger,
            IOperadorRepositorio operadorRepositorio)
        {
            _operadorRepositorio = operadorRepositorio;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Precisodisso()
        {
            return View();
        }

        public IActionResult Querodoar()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Entrega()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CadastrarOperador (Operador operador)
        {
            _operadorRepositorio.AdicionarOperador(operador);
            return RedirectToAction("Index");
        }
    }
}