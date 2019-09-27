﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCarro.Model
{
    class Carros
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
