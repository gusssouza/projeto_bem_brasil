using bem_brasil.DataDb;

namespace bem_brasil.Repositorio
{
    public class PublicarRepositorio : IPublicarRepositorio
    {
        private readonly bemBrasil_SPBContext _bdContext;
        public PublicarRepositorio(bemBrasil_SPBContext bdContext)
        {
            _bdContext = bdContext;
        }

        public List<Produto> BuscarTodos()
        {
            var response = _bdContext.Produtos.ToList();

            return response;
        }
    }
}
