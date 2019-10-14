using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Entidade
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
    }
}
