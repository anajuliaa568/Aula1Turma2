using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;
using System;
using System.Linq;


namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();

        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();
            MostrarMenuRelatorio();
        }
        private static void MostrarMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de Relatório");
            Console.WriteLine(" 1 - Mostrar Menu");
            Console.WriteLine(" 0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mes para realizar o filtro");
                            var mesEscolhido = int.Parse(Console.ReadLine());

                            var listaPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            listaPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaPeriodoEscolhido.Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaPeriodoEscolhido.Average(x => x.Valor * x.Quantidade);

                            Console.WriteLine($"TOTAL DO MES {mesEscolhido} É {totalMes.ToString("C")}");
                            Console.WriteLine($"MEDIA DO MES {mesEscolhido} É {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();

                        }
                        break;
                }
            }
        }
        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(
                string.Format("Id {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,3} Data {4,12}", 
                vendas.Id, 
                vendas.Carro, 
                vendas.Valor.ToString("C"), 
                vendas.Quantidade, 
                vendas.Data.ToShortDateString()));
        }
    }
}
