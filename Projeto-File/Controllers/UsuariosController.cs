using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projeto_File.Models;
using Projeto_File.Models.ViewModels;
using System.Threading.Tasks;

namespace Projeto_File.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UserManager<Usuario> _manager;
        private readonly SignInManager<Usuario> _signIn;

        public UsuariosController(UserManager<Usuario> manager, SignInManager<Usuario> signIn)
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
        public async Task<IActionResult> Registrar(RegistroViewModel registro)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    Nome = registro.Nome,
                    Sobrenome = registro.Sobrenome,
                    UserName = registro.NomeUsuario,
                    Email = registro.Email,
                    Cidade = registro.Cidade
                };

                var UsuarioCriado = await _manager.CreateAsync(usuario, registro.Senha);

                if (UsuarioCriado.Succeeded)
                {
                    await _signIn.SignInAsync(usuario, false);

                    return RedirectToAction("Index", "Home");
                }               
            }

            return View(registro);
        }

        public async Task<IActionResult> Sair()
        {
            await _signIn.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        //ATRIBUIÇÃO DE PERMISSÕES
        [HttpGet]
        public IActionResult RegistrarPermissao()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarPermissao(NivelAcesso nivelAcesso)
        {


            return View();
        }
    }
}
