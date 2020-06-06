using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
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

        public IActionResult BuscarHospital()
        {
            var lista = _dbContext.Hospitais.ToList(); 
            
            int objeto = lista.Last().HospitalId;

            byte[] imagem = _dbContext.Hospitais.Find(objeto).Foto;
            
            return File(imagem, "image/jpg");

        }
    }
}
