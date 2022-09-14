using System;
using System.Collections.Generic;

#nullable disable

namespace bem_brasil.DataDb
{
    public partial class Endereco
    {
        public Endereco()
        {
            Doacos = new HashSet<Doaco>();
        }

        public Guid CodigoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public Guid? CodigoOperador { get; set; }

        public virtual Operador CodigoOperadorNavigation { get; set; }
        public virtual ICollection<Doaco> Doacos { get; set; }
    }
}
