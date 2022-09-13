using bem_brasil.Enums;
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
        }

        public Guid CodigoOperador { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public TipoOperador TipoOperador { get; set; }
        public Guid? CodigoEndereco { get; set; }

        public virtual Endereco CodigoEnderecoNavigation { get; set; }
        public virtual ICollection<Doaco> Doacos { get; set; }
    }
}
