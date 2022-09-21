using System.ComponentModel.DataAnnotations;

namespace bem_brasil.Enums
{
    public enum TipoProduto
    {
        [Display(Name = "Alimentício")]
        Alimenticio = 1,
        [Display(Name = "Brinquedo")]
        Brinquedo = 2,
        [Display(Name = "Roupas")]
        Roupas = 3,
    }
}
