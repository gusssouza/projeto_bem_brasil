﻿using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataDb
{
    public partial class Produto
    {
        public Produto()
        {
            Doacos = new HashSet<Doaco>();
        }

        public Guid CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public DateTime? Validade { get; set; }
        public int? QtdProduto { get; set; }
        public int? TipoProduto { get; set; }

        public virtual ICollection<Doaco> Doacos { get; set; }
    }
}