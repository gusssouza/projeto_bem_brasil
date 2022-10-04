using bem_brasil.Data;

namespace bem_brasil.Repositorio
{
    public interface IPublicarRepositorio
    {
        void PublicarDoacao(Produto produto);
        void PublicarPedido(Produto produto);
        List<Produto> GetAll();
        List<Produto> GetPedidos();
        List<Produto> GetProdutos();
    }
}
