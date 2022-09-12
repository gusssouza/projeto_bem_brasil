using System;

namespace bem_brasil.Models
{
    public class DoacoesModel
    {
        public Guid CodigoDoacoes { get; set; }
        public int TipoDoacao { get; set; }
        public Guid CodigoOperador { get; set; }
        public Guid CodigoProduto { get; set; }
    }
}
