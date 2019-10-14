using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    //Não tem o mais não é preso a interface grafics 
    public class CalculandoArea
    {
        /// <summary>
        /// Metodo para retornar a area de um qudrado
        /// </summary>
        /// <param name="ladoDoQuadrado">lado do quadrado precisão inteira </param>
        /// <returns>Retorna area total do quadrado</returns>
        public double CalculaAreaDoQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado* ladoDoQuadrado;

        }
            
    }
}
