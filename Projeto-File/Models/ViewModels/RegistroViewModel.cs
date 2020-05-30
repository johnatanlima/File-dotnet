using System.ComponentModel.DataAnnotations;

namespace Projeto_File.Models.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage ="Nome é obrigatório!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Seu sobrenome")]
        public string Sobrenome { get; set; }
        
        [DisplayFormat(DataFormatString ="Nome de Usuário")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Email é obrigatório!")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Formato de e-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória!")]
        public string Senha { get; set; }

        public string Cidade { get; set; }

    }
}
