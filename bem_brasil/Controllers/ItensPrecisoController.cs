using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class ItensPrecisoController : Controller
    {
        private readonly ILogger<ItensPrecisoController> _logger;

        public ItensPrecisoController(ILogger<ItensPrecisoController> logger)
        {
            _logger = logger;
        }

        public IActionResult PrecisoComida()
        {
            return View();
        }

        public IActionResult PrecisoRoupa()
        {
            return View();
        }

        public IActionResult PrecisoBrinquedo()
        {
            return View();
        }
    }
}
