using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataDb
{
    public partial class Doaco
    {
        public Guid CodigoDoacoes { get; set; }
        public Guid? CodigoOperador { get; set; }
        public Guid? CodigoProduto { get; set; }
        public Guid? CodigoEndereco { get; set; }

        public virtual Endereco CodigoEnderecoNavigation { get; set; }
        public virtual Operador CodigoOperadorNavigation { get; set; }
        public virtual Produto CodigoProdutoNavigation { get; set; }
    }
}
