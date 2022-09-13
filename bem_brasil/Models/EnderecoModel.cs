using System;

namespace bem_brasil.Models
{
    public class EnderecoModel
    {
        public Guid CodigoEndereco { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public Guid CodigoCidade { get; set; }
    }
}
