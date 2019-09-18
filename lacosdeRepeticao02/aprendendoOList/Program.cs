using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoOList
{
    class Program
    {
       static List<string> minhaListaPulgmatica = new List<string>()
            {
                 "PRISCILLA",
                "iRINEU",
                "Serilop",
                "MARLON"
            };

        static void Main(string[] args)
        {
            AdicionarItemALista();

            ListaInformacao();

            Console.ReadKey();
        }   
        /// <summary>
        /// Metodo que adiciona um item a lista 
        /// </summary>
        private static void AdicionarItemALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            minhaListaPulgmatica.Add(nome);
            Console.Clear();
            
            Console.WriteLine($"Nome: {nome} selecionados a lista");

            Console.WriteLine("Deseja informar mais valores? sim(S) não(N)");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "S")
                AdicionarItemALista();
           
            
        }
          
          private static void ListaInformacao()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista");
            foreach (var item in minhaListaPulgmatica)
            {
                Console.WriteLine(item.ToUpper());
            }
        }  
          

           
                           
        
    }
}
