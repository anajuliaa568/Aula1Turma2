using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoCarro.Model
{
    class Carro
    {
        private int Id { get; set; } = 1;
        private int Quantidade { get; set; }
        private string Nome { get; set; }
        private DateTime Data { get; set; }
        public List<Carro> ListaDeCarro { get; set; }
        
    }
}
