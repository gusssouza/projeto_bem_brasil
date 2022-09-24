using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class EditarController : Controller
    {
        private readonly ILogger<EditarController> _logger;

        public EditarController(ILogger<EditarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Editara()
        {
            return View();
        }
    }
}
