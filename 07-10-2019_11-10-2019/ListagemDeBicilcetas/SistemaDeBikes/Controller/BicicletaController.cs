using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBikes.Model;
using SistemaDeBikes.Controller;

namespace SistemaDeBikes.Controller
{
   
    public class BicicletaController
    {
         BicicletaContext contextDB = new BicicletaContext();

        public List<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.ToList();
        }
        public void AdicionarBike(Bicicleta bike)
        {
            contextDB.Bicicletas.Add(bike);
            contextDB.SaveChanges();
        }

        public void AlterarBicicleta(Bicicleta BicicletaEditada, int id)
        {
            Bicicleta bicicletaQueEuVouEditar = contextDB.Bicicletas.FirstOrDefault(p => p.Id == id);
            bicicletaQueEuVouEditar = BicicletaEditada;
            contextDB.SaveChanges();
        }

    }
}

