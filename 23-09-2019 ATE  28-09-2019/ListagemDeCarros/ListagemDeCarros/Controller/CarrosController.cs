using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;


namespace ListagemDeCarros.Controller
{
   public class CarrosController
    {
        SistemaCarrosContext carrosContext = new SistemaCarrosContext();
        /// <summary>
        /// metodo que retorna a nossa lista de carros 
        /// </summary>
        /// <returns>Retorna nossa lista de carros </returns>
        public List<Carros> GetCarros()
        {
            
                return carrosContext.ListaCarros;
                        
        }
        
    }
}
