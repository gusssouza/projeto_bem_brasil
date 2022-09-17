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
    }
}
