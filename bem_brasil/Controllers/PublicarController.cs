using bem_brasil.Data;
using bem_brasil.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class PublicarController : Controller
    {
        private readonly ILogger<PublicarController> _logger;
        private readonly IPublicarRepositorio _publicarRepositorio;

        public PublicarController(ILogger<PublicarController> logger, 
            IPublicarRepositorio publicarRepositorio)
        {
            _logger = logger;
            _publicarRepositorio = publicarRepositorio;
        }

        public IActionResult Publicardoacao()
        {
            return View();
        }

        public IActionResult PublicarPedido()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult doacaoComida()
        {
            return View();
        }

        public IActionResult doacaoRoupa()
        {
            return View();
        }
        public IActionResult doacaoBrinquedo()
        {
            return View();
        }

        public IActionResult precisoComida()
        {
            return View();
        }

        public IActionResult precisoRoupa()
        {
            return View();
        }
        public IActionResult precisoBrinquedo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostarDoacao (Produto produto)
        {
            _publicarRepositorio.PublicarDoacao(produto);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult PostarPedido(Produto produto)
        {
            _publicarRepositorio.PublicarPedido(produto);

            return RedirectToAction("Index", "Home");
        }
    }
}
