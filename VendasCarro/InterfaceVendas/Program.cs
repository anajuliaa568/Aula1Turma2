using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCarro.Controller;
using VendasCarro.Model;

namespace InterfaceVendas
{
    class Program
    {
        static  VendasController vendasController = new VendasController();
        

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de vendas de carros:");
            vendasController.().ForEach(i => i.MostrarMenu(i));

            Console.ReadKey();

        }
        private static void MostrarMenu()
        {




        }

        
        
            
          
    }
}
