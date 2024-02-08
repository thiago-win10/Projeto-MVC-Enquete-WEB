using System.ComponentModel.DataAnnotations;

namespace ProjetoEnqueteMvcNetCore.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo email é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo email não é um endereço válido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "O campo Sim é obrigatório")]
        public bool? Sim { get; set; }
        

    }
}