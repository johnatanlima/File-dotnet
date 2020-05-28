﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_File.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }

        public string Nome { get; set; }

        public string Diretor { get; set; }

        public byte[] Foto { get; set; }

        public ICollection<Especialidade> Especialidades { get; set; }

        
    }
}