﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityClass.Model
{
    public class Alunos
    {
        [Key]

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        
    }
}
