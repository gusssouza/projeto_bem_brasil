using bem_brasil.DataFinal;

namespace bem_brasil.Repositorio
{
    public interface IPublicarRepositorio
    {
        void PublicarDoacao(Produto produto);
        void PublicarPedido(Produto produto);
        List<Produto> GetAll();
        List<Produto> GetPedidos();
        List<Produto> GetProdutos();
        Produto GetProdutoByCodigo(Guid codigoProduto);
        void EditarProduto(Produto produto);
        void DeletarProduto(Guid codigoProduto);
    }
}
