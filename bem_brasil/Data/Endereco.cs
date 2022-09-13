using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.Data
{
    public partial class Endereco
    {
        public Endereco()
        {
            Operadors = new HashSet<Operador>();
        }

        public Guid CodigoEndereco { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public Guid? CodigoCidade { get; set; }

        public virtual Cidade CodigoCidadeNavigation { get; set; }
        public virtual ICollection<Operador> Operadors { get; set; }
    }
}
