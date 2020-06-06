using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_File.Data;

namespace AspNetCore
{
    public class UsuariosViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public UsuariosViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await _appDbContext.Usuarios.ToListAsync());
        }

    }
}