using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.Data
{
    public partial class Operador
    {
        public Operador()
        {
            Doacos = new HashSet<Doaco>();
            Enderecos = new HashSet<Endereco>();
        }

        public Guid CodigoOperador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtNascimento { get; set; }
        public int? TipoOperador { get; set; }
        public Guid? CodigoCidade { get; set; }

        public virtual Cidade CodigoCidadeNavigation { get; set; }
        public virtual ICollection<Doaco> Doacos { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
