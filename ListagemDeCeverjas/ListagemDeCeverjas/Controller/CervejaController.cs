using ListagemDeCervejas.Model;
using ListagemDeCeverjas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListagemDeCeverjas.Controller
{
   public class CervejaController
    {
        /// <summary>
        /// METODO QUE RETORNA NOSSA LISTA COMPLETA DE CERVEJAS 
        /// </summary>
        SistemaCervejaContext sistemaCerveja = new SistemaCervejaContext();

        public List<Cerveja> GetCervejas()
        {
            return sistemaCerveja.ListaDeCervejasPublica;
        }

        public void AdicionarCerveja(Cerveja cerveja)

        {
            sistemaCerveja.ListaDeCervejasPublica.Add(cerveja);
        }
        public float RetornarValor()
        {
            var total = float.Parse(sistemaCerveja.ListaDeCervejasPublica.Sum(x => x.Valor).ToString());
            return total;
            //Console.WriteLine(string.Format("Valor Total", cerveja.Valor.ToString("C")));
        }
        public float RetornarLitros()
        {
            // Console.WriteLine(string.Format("Total de Litros", cerveja.Litros));
            var totalLitros = float.Parse(sistemaCerveja.ListaDeCervejasPublica.Sum(x => x.Litros).ToString());
            return totalLitros;
        }
        
    }
}
