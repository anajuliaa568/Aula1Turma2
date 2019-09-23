using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            menuSistema();
        }

        private static void menuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar animação");
            Console.WriteLine("3 - Mostrar classe carro");
            Console.WriteLine("4 - Mostrar classe cervejas");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1: { CalculandoArea(); menuSistema(); } break;
                //case 2: {
                //        var minhaclasseAnimacao = new AnimacoesEmFrames();
                //        minhaclasseAnimacao.Arvore(); menuSistema(); }break;
                //case 2 usando o metodo sem static  tem que colocar var e new 
                //case 2 usando com o static apenas chamar por exemplo: AnimaçõesEmFrames.Arvore(); menuSistema();
                //não esquecer de fazer rebuild sempre que houver uma alteração.

                case 2:
                    {
                        AnimacoesEmFrames.Arvore(); menuSistema();
                    }
                    break;

                case 3:
                    {
                        MostrarListas.MarcaCarros(); menuSistema();

                    }
                    break;
                case 4:
                    {
                        MostrarListaCerveja.ListaCervejas(); menuSistema();

                    }
                    break;
                case 5:
                    {
                        Console.WriteLine();
                    }
                    break;
               
               

            }

        }
        public static void CalculandoArea()
        {
            Console.WriteLine("Informa o lado do quadrado");

            var ladoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecadeCalculos = new CalculandoArea();

            Console.WriteLine($"Minha Area é:{bibliotecadeCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadLine();

        }

    }
}
