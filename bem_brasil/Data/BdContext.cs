using bem_brasil.Models;
using Microsoft.EntityFrameworkCore;

namespace bem_brasil.Data
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {
        }

        public DbSet<OperadorModel> Operador { get; set; }
        public DbSet<CidadeModel> Cidade { get; set; }
        public DbSet<DoacoesModel> Doacoes { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
        public DbSet<EstadoModel> Estado { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
