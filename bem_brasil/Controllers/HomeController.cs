using bem_brasil.Models;
using bem_brasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bem_brasil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOperadorRepositorio _operadorRepositorio;
        private readonly IPublicarRepositorio _publicarRepositorio;

        public HomeController(ILogger<HomeController> logger,
            IOperadorRepositorio operadorRepositorio, 
            IPublicarRepositorio publicarRepositorio)
        {
            _operadorRepositorio = operadorRepositorio;
            _logger = logger;
            _publicarRepositorio = publicarRepositorio;
        }

        public IActionResult Index()
        {
            var produtos = _publicarRepositorio.GetAll();
            return View(produtos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Precisodisso()
        {
            var pedidos = _publicarRepositorio.GetPedidos();
            return View(pedidos);
        }

        public IActionResult Querodoar()
        {
            var doacoes = _publicarRepositorio.GetProdutos();
            return View(doacoes);
        }

        public IActionResult Entrega()
        {
            return View();
        }

        public IActionResult publicardoacao()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Telabrinquedo()
        {
            return View();
        }
        public IActionResult Telasalvos()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Termosdeuso()  
        {
            return View();
        }

        public IActionResult Tela()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}