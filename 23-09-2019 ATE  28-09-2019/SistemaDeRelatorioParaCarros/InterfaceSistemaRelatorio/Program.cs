using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();

            MostraMenURelatorio();

        }
        private static void MostraMenURelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de Relatório");
            Console.WriteLine("1 - Relatório por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {

                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");

                            //Obetemos informação do mês 
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //Passamos o mes na mesma função para obter as vendas 
                           // VendasController.GetVendas(mesEscolhido).ForEach(i => ImprimeInformacoes(i));
                           
                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);
                            listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaDoPeriodoEscolhido.Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaDoPeriodoEscolhido.Average(X => X.Valor * X.Quantidade);
                           //var totalmes = VendasController.GetVendas(mesEscolhido).Sum(x => x.Valor * x.Quantidade);
                            Console.WriteLine($"Total do mês {mesEscolhido}é (totalMes)");
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                    
                }

            }
        }
        public static void ImprimeInformacoes (Venda vendas)
        {
            Console.WriteLine(string.Format("Id {0,3} Carro {1,-20}Valor {2,-10} Quantidade {3,3} Data {4,12} "
               ,vendas.Id, 
                vendas.Carro, 
                vendas.Valor.ToString("C"),
                vendas.Quantidade,
                vendas.Data.ToShortDateString()));
        }

    }
}
