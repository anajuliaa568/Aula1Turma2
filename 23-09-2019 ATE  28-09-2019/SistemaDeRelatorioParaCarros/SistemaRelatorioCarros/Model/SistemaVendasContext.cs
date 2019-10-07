using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
   public  class SistemaVendasContext
    {
        /// <summary>
        /// nossa massa de dados interna 
        /// </summary>
        private List<Venda> ListaDeVendas { get; set; }
        /// <summary>
        /// Contrutor que prepara nossa massa de dados.
        /// </summary>

        public SistemaVendasContext()
        {
            //criamos nossa lista de vendas em memoria caso contrario ela fica null
            ListaDeVendas = new List<Venda>();

            ListaDeVendas.Add(new Venda() { Id = 1, Carro = "Risus Company", Valor = 7.200, Quantidade = 18, Data = DateTime.Parse("20/01/2019") });
            ListaDeVendas.Add(new Venda() { Id = 2, Carro = "Risus Associate ", Valor = 9.961, Quantidade = 4, Data = DateTime.Parse("26/01/2019") });
            ListaDeVendas.Add(new Venda() { Id = 3, Carro = "Risus Company", Valor = 8.710, Quantidade = 17, Data = DateTime.Parse("20/01/2019") });
        }

        public List<Venda> ListaVendasPublica { get { return ListaDeVendas; } }

    }
}
