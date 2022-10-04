using bem_brasil.Data;

namespace bem_brasil.Repositorio
{
    public class PublicarRepositorio : IPublicarRepositorio
    {
        private readonly bem_brasil_dbContext _bdContext;

        public PublicarRepositorio(bem_brasil_dbContext bdContext)
        {
            _bdContext = bdContext;
        }

        public List<Produto> GetAll()
        {
            return _bdContext.Produtos.Select(x => x).ToList();
        }

        public List<Produto> GetPedidos()
        {
            return _bdContext.Produtos.Select(x => x).Where(a => a.TipoPostagem == Enums.TipoPostagem.Pedido).ToList();
        }

        public List<Produto> GetProdutos()
        {
            return _bdContext.Produtos.Select(x => x).Where(a => a.TipoPostagem == Enums.TipoPostagem.Doacao).ToList();
        }

        public void PublicarDoacao(Produto produto)
        {
            produto.CodigoProduto = Guid.NewGuid();
            produto.TipoPostagem = Enums.TipoPostagem.Doacao;

            _bdContext.Produtos.Add(produto);
            _bdContext.SaveChanges();
        }

        public void PublicarPedido(Produto produto)
        {
            produto.CodigoProduto = Guid.NewGuid();
            produto.TipoPostagem = Enums.TipoPostagem.Pedido;

            _bdContext.Produtos.Add(produto);
            _bdContext.SaveChanges();
        }
    }
}
