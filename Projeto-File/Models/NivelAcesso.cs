using Microsoft.AspNetCore.Identity;

namespace Projeto_File.Models
{
    public class NivelAcesso : IdentityRole
    {
        public string Permissao { get; set; }
    }
}
