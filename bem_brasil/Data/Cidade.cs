using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.Data
{
    public partial class Cidade
    {
        public Cidade()
        {
            Enderecos = new HashSet<Endereco>();
        }

        public Guid CodigoCidade { get; set; }
        public string Nome { get; set; }
        public Guid? CodigoEstado { get; set; }

        public virtual Estado CodigoEstadoNavigation { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
