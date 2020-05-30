using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projeto_File.Models;
using Projeto_File.Models.ViewModels;
using System.Threading.Tasks;

namespace Projeto_File.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UserManager<Usuario> _manager;
        private readonly SignInManager<Usuario> _signIn;

        public UsuarioController(UserManager<Usuario> manager, SignInManager<Usuario> signIn)
        {
            _manager = manager;
            _signIn = signIn;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(RegistroViewModel registro)
        {

            return View();
        }
    }
}
