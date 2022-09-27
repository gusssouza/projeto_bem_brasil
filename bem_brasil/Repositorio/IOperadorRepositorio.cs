using bem_brasil.Data;

namespace bem_brasil.Repositorio
{
    public interface IOperadorRepositorio
    {
        Operador AdicionarOperador(Operador operadorModel);
        bool Logar(Operador operador);
    }
}
