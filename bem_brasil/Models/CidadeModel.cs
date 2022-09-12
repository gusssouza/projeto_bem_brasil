using System;

namespace bem_brasil.Models
{
    public class CidadeModel
    {
        public Guid CodigoCidade { get; set; }
        public string Nome { get; set; }
        public Guid CodigoEstado { get; set; }
    }
}
