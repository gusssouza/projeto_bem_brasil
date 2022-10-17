using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataFinal
{
    public partial class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        public Guid CodigoEstado { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
