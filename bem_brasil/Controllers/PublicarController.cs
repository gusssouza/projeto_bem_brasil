using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class PublicarController : Controller
    {
        private readonly ILogger<PublicarController> _logger;

        public PublicarController(ILogger<PublicarController> logger)
        {
            _logger = logger;
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
    }
}
