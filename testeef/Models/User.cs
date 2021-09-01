using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class User
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(200, ErrorMessage = "Este campo deve conter entre 5 e 200 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 5 e 200 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo deve conter entre 11 e 12 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 11 e 12 caracteres")]
        public string Nickname { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(11, ErrorMessage = "Este campo deve conter entre 11 caracteres")]
        [MinLength(11, ErrorMessage = "Este campo deve conter entre 11 caracteres")]
        public string CPF { get; set;}


        [MaxLength(15, ErrorMessage = "Este campo deve conter no máximo 15 caracteres")]
        public string Sex { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(12, ErrorMessage = "Este campo deve conter entre 11 e 12 caracteres")]
        [MinLength(11, ErrorMessage = "Este campo deve conter entre 11 e 12 caracteres")]
        public string Telephone { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="Categoria inválida")]
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}