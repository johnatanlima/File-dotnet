using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Projeto_File.Models
{
    public class Especialidade
    {
        public int EspecialidadeId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInclusao { get; set; }

        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
