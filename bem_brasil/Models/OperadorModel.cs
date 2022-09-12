using bem_brasil.Enums;
using System;

namespace bem_brasil.Models
{
    public class OperadorModel
    {
        public Guid CodigoOperador { get; set; }
        public Guid CodigoEndereco { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public TipoOperador TipoOperador { get; set; }

    }
}
