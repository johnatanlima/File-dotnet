using Microsoft.AspNetCore.Identity;

namespace Projeto_File.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Cidade { get; set; }
    }
}
