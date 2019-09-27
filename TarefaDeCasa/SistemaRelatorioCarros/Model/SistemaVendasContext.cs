using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class SistemaVendasContext
    {
        private List<Venda> ListaDeVendas { get; set; }

        public SistemaVendasContext()
        {
            ListaDeVendas = new List<Venda>();
            //o que tem dentro das classes são as propriedades e a classe é um objeto 
            //instanciando,= atribuir valor 
            ListaDeVendas.Add(new Venda() { Id = 1, Carro = "Risus Company", Valor = 7200, Quantidade = 18, Data = DateTime.Parse("29/01/2019") });
            ListaDeVendas.Add(new Venda() { Id = 2, Carro = "Risus Associates", Valor = 9961, Quantidade = 4, Data = DateTime.Parse("10/02/2019") });
            ListaDeVendas.Add(new Venda() { Id = 3, Carro = "Et Libero Proin Foundation", Valor = 8710, Quantidade = 17, Data = DateTime.Parse("24/01/2019") });
            ListaDeVendas.Add(new Venda() { Id = 4, Carro = "Uno", Valor = 8564, Quantidade = 15, Data = DateTime.Parse("26/10/2019") });
        }

        public List<Venda> ListaVendasPublica { get { return ListaDeVendas; } }
    }
}

