using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaBalasListaDeCriancas();
            SomaInteirosLista();
            SomarInteiroPrimitivos();
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo 
        /// </summary>

        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção desses valores 
            int[] colecaoInteiros = new int[5]
            //Colocamos memoria para nossa coleção de valor e informamos a quantidade de memoria que vamos 
            //ocupar
            //aqui carregamos nossa coleção de valores 
            { 1,2,3,4,5 };


            //aqui somamos os valores da nossa lista 
            Console.WriteLine(colecaoInteiros.Sum());

        }
        /// <summary>
        /// Metodo que soma todos os valoires em uma lista 
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {//nossa coleção de valores
                1,2,3,4,5,6,7,8,9,10,11,12
            };
            Console.WriteLine( listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma a quantidade de balas das crianças 
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "jõazinho",
                    Balas = 9
                },//virgula separamos um objeto de outro 
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            Console.WriteLine("quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine(
                //Somoa nossa quantidade de balas 
                criancas.Sum(x=> x.Balas));
        }
    }
}
