using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly ILogger<EnderecoController> _logger;

        public EnderecoController(ILogger<EnderecoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Endereco()
        {
            return View();
        }
    }
}



