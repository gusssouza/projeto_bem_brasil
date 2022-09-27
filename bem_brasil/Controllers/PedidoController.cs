using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Pedido()
        {
            return View();
        }

        public IActionResult Editarpedido()
        {
            return View();
        }
    }
}
