using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_File.Models;

namespace Projeto_File.Controllers
{
    public class HospitaisController : Controller
    {
        [HttpGet]
        public IActionResult AdicionarHospital()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarHospital()
        {

            return View();
        }
    }
}
