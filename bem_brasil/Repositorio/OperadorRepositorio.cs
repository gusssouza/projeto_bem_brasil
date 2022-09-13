using bem_brasil.Data;
using bem_brasil.Models;

namespace bem_brasil.Repositorio
{
    public class OperadorRepositorio : IOperadorRepositorio
    {
        private readonly bemBrasilContext _bdContext;

        public OperadorRepositorio(bemBrasilContext bdContext)
        {
            _bdContext = bdContext;
        }

        public Operador AdicionarOperador(Operador operadorModel)
        {
            operadorModel.CodigoOperador = Guid.NewGuid();
            operadorModel.CodigoEndereco = Guid.Parse("8c1c9e71-26a1-458a-95a9-4252c5afe6d2");

            _bdContext.Operadors.Add(operadorModel);
            _bdContext.SaveChanges();
            return operadorModel;
       
        }
    }
}
