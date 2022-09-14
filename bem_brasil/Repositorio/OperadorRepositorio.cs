using bem_brasil.DataDb;
using bem_brasil.Models;

namespace bem_brasil.Repositorio
{
    public class OperadorRepositorio : IOperadorRepositorio
    {
        private readonly bemBrasil_SPBContext _bdContext;

        public OperadorRepositorio(bemBrasil_SPBContext bdContext)
        {
            _bdContext = bdContext;
        }

        public Operador AdicionarOperador(Operador operadorModel)
        {
            operadorModel.CodigoOperador = Guid.NewGuid();

            _bdContext.Operadors.Add(operadorModel);
            _bdContext.SaveChanges();
            return operadorModel;
       
        }
    }
}
