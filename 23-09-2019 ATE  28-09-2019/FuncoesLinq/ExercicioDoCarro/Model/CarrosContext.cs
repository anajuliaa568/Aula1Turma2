using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoCarro.Model
{
   public class CarrosContext
    {
        private int IDContadorCarros { get; set; } = 1;
        private int IDContadorUsuarios { get; set; } = 1;

        public CarrosContext()
        {
           ListaDeCarro = new List<Carro>();

            ListaDeCarro.Add(new Carro()
            {
                Id = IDContadorCarros++,


            });




        }

        private List<Carro> ListaDeCarro { get; set; }
        private List<>

    }
}
