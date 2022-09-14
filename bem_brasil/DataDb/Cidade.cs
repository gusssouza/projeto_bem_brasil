using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataDb
{
    public partial class Cidade
    {
        public Cidade()
        {
            Operadors = new HashSet<Operador>();
        }

        public Guid CodigoCidade { get; set; }
        public string Nome { get; set; }
        public Guid? CodigoEstado { get; set; }

        public virtual Estado CodigoEstadoNavigation { get; set; }
        public virtual ICollection<Operador> Operadors { get; set; }
    }
}
