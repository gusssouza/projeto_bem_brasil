using bem_brasil.DataFinal;
using bem_brasil.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPublicarRepositorio _publicarRepositorio;
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger, IPublicarRepositorio publicarRepositorio)
        {
            _logger = logger;
            _publicarRepositorio = publicarRepositorio;
        }
        public IActionResult Pedido()
        {
            var response = _publicarRepositorio.GetAll();
            return View(response);
        }

        public IActionResult Editarpedido(Guid codigoProduto)
        {
            var produto = _publicarRepositorio.GetProdutoByCodigo(codigoProduto);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            _publicarRepositorio.EditarProduto(produto);
            return RedirectToAction("Pedido", "Pedido");
        }
         
        public IActionResult Deletar(Guid codigoProduto)
        {
            _publicarRepositorio.DeletarProduto(codigoProduto);
            return RedirectToAction("Pedido", "Pedido");
        }
    }
}
