using bem_brasil.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataFinal
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
        public TipoProduto? TipoProduto { get; set; }
        public string Titulo { get; set; }
        public TipoComida? TipoComida { get; set; }
        public TipoPostagem? TipoPostagem { get; set; }
        public string LinkImagem { get; set; }
        public string Tamanho { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string NumeroCasa { get; set; }
        public string CEP { get; set; }

        public virtual ICollection<Doaco> Doacos { get; set; }
    }
}
