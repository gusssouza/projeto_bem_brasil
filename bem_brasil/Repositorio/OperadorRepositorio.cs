using bem_brasil.Data;
using bem_brasil.Enums;

namespace bem_brasil.Repositorio
{
    public class OperadorRepositorio : IOperadorRepositorio
    {
        private readonly bem_brasil_dbContext _bdContext;

        public OperadorRepositorio(bem_brasil_dbContext bdContext)
        {
            _bdContext = bdContext;
        }

        public Operador AdicionarOperador(Operador operadorModel)
        {
            operadorModel.CodigoOperador = Guid.NewGuid();
            operadorModel.DtInclusao = DateTime.Now;
            operadorModel.TipoOperador = (int?)TipoOperador.Doador;

            _bdContext.Operadors.Add(operadorModel);
            _bdContext.SaveChanges();
            return operadorModel;

        }

        public bool Logar(Operador operador)
        {
            var contas = _bdContext.Operadors.Where(x => x.Email == operador.Email && x.Senha == operador.Senha).FirstOrDefault();

            if (contas != null)
                return true;
            else
                return false;
        }
    }
}
