﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim3Semestre.util
{
    public class Usuario
    {
        public int id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public int Nivel { get; set; }
    }
}
