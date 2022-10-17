using bem_brasil.DataFinal;

namespace bem_brasil.Repositorio
{
    public class PublicarRepositorio : IPublicarRepositorio
    {
        private readonly bemBrasil_SPBContext _bdContext;

        public PublicarRepositorio(bemBrasil_SPBContext bdContext)
        {
            _bdContext = bdContext;
        }

        public void EditarProduto(Produto produto)
        {
            var produtoDB = GetProdutoByCodigo(produto.CodigoProduto);
            produtoDB.Titulo = produto.Titulo;
            produtoDB.Descricao = produto.Descricao;
            produtoDB.QtdProduto = produto.QtdProduto;
            produtoDB.Rua = produto.Rua;
            produtoDB.Bairro = produto.Bairro;
            produtoDB.CEP = produto.CEP;
            produtoDB.Cidade = produto.Cidade;
            produtoDB.LinkImagem = produto.LinkImagem;
            produtoDB.NumeroCasa = produto.NumeroCasa;
            produtoDB.Tamanho = produto.Tamanho;

            _bdContext.Produtos.Update(produtoDB);
            _bdContext.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _bdContext.Produtos.Select(x => x).ToList();
        }

        public List<Produto> GetPedidos()
        {
            return _bdContext.Produtos.Select(x => x).Where(a => a.TipoPostagem == Enums.TipoPostagem.Pedido).ToList();
        }

        public Produto GetProdutoByCodigo(Guid codigoProduto)
        {
            var response = _bdContext.Produtos.Select(x => x).Where(a => a.CodigoProduto == codigoProduto).FirstOrDefault();
            return response;
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
