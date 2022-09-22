using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class ItensDoacaoController : Controller
    {
        private readonly ILogger<ItensDoacaoController> _logger;

        public ItensDoacaoController(ILogger<ItensDoacaoController> logger)
        {
            _logger = logger;
        }

        public IActionResult DoacaoComida()
        {
            return View();
        }

        public IActionResult DoacaoRoupa()
        {
            return View();
        }

        public IActionResult DoacaoBrinquedo()
        {
            return View();
        }
    }
}