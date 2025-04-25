using System.ComponentModel.DataAnnotations;

namespace SalesCet96.Web.Data.Entities
{
    public class Country
    {
        [Key] // indicador de chave primária, que neste caso não precisa por conta do Id que por si só já indica
        public int Id { get; set; }

        [Display(Name = "País")] //Data Anotations: não aparece o nome da propriedade mas sim a apalavra país 

        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteteres")] // Data Anotations é bom para msg de erro

        [Required(ErrorMessage= "O campo {0} é obrigatório")] //campos obrigatórios
        public string? Name { get; set; }    
    }
}
