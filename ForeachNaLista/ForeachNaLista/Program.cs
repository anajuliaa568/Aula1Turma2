using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaParaConverter();
            Console.ReadKey();

        }

        /// <summary>
        /// mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            // o new serve para abrir um novo "projeto dentro do projeto"
            //com data pra colocar o add 
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData =>
            Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));

        }

        /// <summary>
        /// mostra lista de string definidas
        /// </summary>

        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAMI");
            minhaLista.Add("iPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));//função que usa a expressão lâmbda, pode usar somente essa expressão para a lista aparacer  

            Console.ReadKey();

        }
        /// <summary>
        /// minha lista de numeros decimais 
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C2")));

        }
        /// <summary>
        /// minha lista numeros inteiros 
        /// </summary>
        private static void ListaDeNumerosInteiros()
        {

            var minhalista = new List<int>();

            minhalista.Add(17);
            minhalista.Add(18);
            minhalista.Add(19);
            minhalista.Add(20);

            minhalista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
        private static void ListaParaConverter()
        {
            var minhalista = new List<double>();

            minhalista.Add(17.00);
            minhalista.Add(18.00);
            minhalista.Add(19.00);
            minhalista.Add(10.00);

            //minhalista.ForEach(i => Console.WriteLine(i.ToString("C2", CultureInfo.CurrentCulture)));
             
            minhalista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " " +
                FormatarNumeroDecimalEmDolar(meuDecimal) + " " +
                FormatarEmEuro(meuDecimal)+ " "+
                FormatarEmyen(meuDecimal)+ " " +
                FormatarBit(meuDecimal)));
        }

        private static string FormatarNumeroDecimalEmDolar(double MeuNumero)
        {
            return (MeuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// METODO QUE CONVERTE REAL PARA EURO
        /// </summary>
        /// <param name="MeuNumero"></param>
        /// <returns></returns>
        private static string FormatarEmEuro(double MeuNumero)
        {
            return (MeuNumero / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR")).Replace("$","euro");
        }
        /// <summary>
        /// METODO QUE CONVERTE PARA YEN
        /// </summary>
        /// <param name="Meunumero"></param>
        /// <returns></returns>
        private static string FormatarEmyen(double Meunumero)
        {
            return (Meunumero / 0.038).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// METODO QUE CONVERTE PARA BITCOIN
        /// </summary>
        /// <param name="Meunumero"></param>
        /// <returns></returns>
        private static string FormatarBit(double Meunumero)
        {
            return (Meunumero / 41856.35).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }

    }
}













