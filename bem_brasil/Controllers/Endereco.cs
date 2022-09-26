using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class Endereco : Controller
    {

        private readonly ILogger<PublicarCon> _logger;

        public PublicarController(ILogger<PublicarController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}


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

    }
}