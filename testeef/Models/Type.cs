using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Type
    {
        [Key]

        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(200, ErrorMessage = "Este campo deve conter entre 5 e 200 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 5 e 200 caracteres")]
        public string Name { get; set; }
    }
}