using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_File.Data;
using Projeto_File.Models;

namespace Projeto_File.Controllers
{
    public class HospitaisController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HospitaisController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult AdicionarHospital()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarHospital(Hospital hospital, IFormFile Imagem)
        {
            if (ModelState.IsValid) {
             
                if (Imagem != null)
                {
                    byte[] fotoHexa;

                    using (var open = Imagem.OpenReadStream())
                    {
                        using(var memory = new MemoryStream())
                        {
                            open.CopyTo(memory);

                            fotoHexa = memory.ToArray();
                        }
                    }

                    hospital.Foto = fotoHexa;
                }

                _dbContext.Hospitais.Add(hospital);
                    await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Home");

            }

            //Caso o modelo esteja inconsistente.
            return View(hospital);
        }
    }
}
