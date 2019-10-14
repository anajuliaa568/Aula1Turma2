using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCeverjas.Model
{
    public class SistemaCervejaContext
    {
        private List<Cerveja> ListaDeCervejas { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>();

            ListaDeCervejas.Add(new Cerveja() { Id = 1, Nome = "Budweiser", Litros = 600, Alcool = 5.0, Valor = 9.0 });
            ListaDeCervejas.Add(new Cerveja() { Id = 2, Nome = "Brahma", Litros = 350, Alcool = 0.0, Valor = 3.5 });
            ListaDeCervejas.Add(new Cerveja() { Id = 3, Nome = "Bohemia", Litros = 990, Alcool = 5.0, Valor = 8.0 });
            ListaDeCervejas.Add(new Cerveja() { Id = 4, Nome = "Antarctica", Litros = 600, Alcool = 4.7, Valor = 7.0 });
            ListaDeCervejas.Add(new Cerveja() { Id = 5, Nome = "Original", Litros = 600, Alcool = 4.9, Valor = 6.0 });

        }

        public List<Cerveja> ListaDeCervejasPublica { get { return ListaDeCervejas; } }
    }
   
}
