﻿using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.Data
{
    public partial class Doaco
    {
        public Guid CodigoDoacoes { get; set; }
        public int? TipoDoacao { get; set; }
        public Guid? CodigoOperador { get; set; }
        public Guid? CodigoProduto { get; set; }

        public virtual Operador CodigoOperadorNavigation { get; set; }
        public virtual Produto CodigoProdutoNavigation { get; set; }
    }
}