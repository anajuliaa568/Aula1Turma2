using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCarro.Model;

namespace VendasCarro.Controller
{
   public class VendasController
    {
        private CarrosContext carrosContext = new CarrosContext();

            private VendasController()
            {

            }

        public List<Carros> RetornarListaDeCarros()
        {
            return carrosContext.ListaDeCarros.Where(x => x.Ativo).ToList<Carros>();
        }
    }
}
