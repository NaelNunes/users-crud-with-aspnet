using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastroUsuarios.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200)]
        public string Endereco { get; set; } = string.Empty;
    }
}