using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_File.Data;
using Projeto_File.Models;
using Projeto_File.Models.ViewModels;
using System.Threading.Tasks;

namespace Projeto_File.Controllers
{

    public class UsuariosController : Controller
    {
        private readonly UserManager<Usuario> _manager;
        private readonly SignInManager<Usuario> _signIn;
        private readonly RoleManager<NivelAcesso> _role;
        private readonly AppDbContext _dbContext;

        public UsuariosController(AppDbContext dbContext, RoleManager<NivelAcesso> role, UserManager<Usuario> manager, SignInManager<Usuario> signIn)
        {
            _manager = manager;
            _signIn = signIn;
            _role = role;
            _dbContext = dbContext;
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
            if (ModelState.IsValid)
            {
                bool permissaoExiste = await _role.RoleExistsAsync(nivelAcesso.Name);

                if (!permissaoExiste)
                {
                    await _role.CreateAsync(nivelAcesso);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View(nivelAcesso);
        }

        [HttpGet]
        public async Task<IActionResult> AssociarPermissao()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["UsuarioId"] = new SelectList(await _dbContext.Usuarios.ToListAsync(), "Id", "UserName");
                ViewData["NivelAcessoId"] = new SelectList(await _dbContext.NiveisAcessos.ToListAsync(), "Name", "Name");

                return View();
            }

            return StatusCode(403);
        }

        [HttpPost]
        public async Task<IActionResult> AssociarPermissao(UsuarioRoleViewModel usuarioRole)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _dbContext.Usuarios.FindAsync(usuarioRole.UsuarioId);

                await _manager.AddToRoleAsync(usuario, usuarioRole.NomeRole);

                return RedirectToAction("Index", "Home");
            }

            return View(usuarioRole);

        }
    }
}
