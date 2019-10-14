using SistemaDeBikes.Controller;
using SistemaDeBikes.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletaa
{
    public class Program
    {
        static BicicletaController bibliotecaContext = new BicicletaController();
        static void Main(string[] args)
        {
            Console.WriteLine("o que tu quer fazer truta??????");
            Console.WriteLine("1 - Cadastrar uma bike");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            switch (opcaoEscolhida)
            {
                case 1:
                    bibliotecaContext.AdicionarBike(new Bicicleta() { Marca = "TESTE" , Modelo = "TESTE" , Valor = 205});
                        break;

                default:
                    break;
            }
        }
    }
}
