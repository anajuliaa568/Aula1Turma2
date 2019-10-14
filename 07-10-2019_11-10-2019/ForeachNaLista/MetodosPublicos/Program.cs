using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MetodosPublicos
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Conversor();
                
        }
        public static void Conversor()
        {
            Console.WriteLine("Sistema conversor de moedas cabuloso");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão: ");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();

        }

        /// <summary>
        /// Metodo que converte moeda em real para um ativo especifico
        /// para converte digite os alvos 
        /// "EURO"
        /// "YEN"
        /// "BTC"
        /// "DOLAR"
        /// </summary>
        /// <param name="minhamoeda">MOEDA EM VALOR REAL </param>
        /// <param name="moedaAlvo">ALVO EM QUE A MOEDA SERÁ CONVERTIDA </param>
        public static void ConvertMoeda(double minhamoeda, string moedaAlvo)
        {
            
            switch (moedaAlvo)
            {
                case "Dolar":
                    Console.WriteLine(formataNumeroDecimalDolar(minhamoeda));
                    break;
                case "Euro":
                    Console.WriteLine(FormatarEmEuro(minhamoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormatarEmYen(minhamoeda));
                    break;
                case"BTC":
                    Console.WriteLine(FormatarBit(minhamoeda));
                    break;
                


            }
        }

      private static string formataNumeroDecimalDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("c2", CultureInfo.CreateSpecificCulture("en-us"));
        }


        private static string FormatarEmEuro(double MeuNumero)
        {
            return (MeuNumero / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR")).Replace("$", "euro");
        }

        private static string FormatarEmYen( double MeuNumero)
         {
            return (MeuNumero / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"));

         }

        private static string FormatarBit(double Meunumero)
        {
            return (Meunumero / 41856.35).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }
    } 
}
