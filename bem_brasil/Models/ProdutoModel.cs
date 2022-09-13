using bem_brasil.Enums;
using System;

namespace bem_brasil.Models
{
    public class ProdutoModel
    {
        public Guid CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public int QtdProduto { get; set; }
        public TipoProduto TipoProduto { get; set; }
    }
}
