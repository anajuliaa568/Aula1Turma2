using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {

            //MinhaBiBlioteca.AnimacoesEmFrames.Arvoree();

            //var metodoAreaAmiguinho = MinhaBiBlioteca.Metodo.CalcularAreaDoQuadrado();

            var calculo = new AreaCalculator();
            var retorno = calculo.SquareAreaCalculator(15);

            //only be static
           // AreaCalculator.SquareAreaCalculator()
           // {retorno} vai retornar o valor do quadrodo 
            Console.WriteLine($" o quadrado {retorno}");
           
            Console.ReadKey();

        }
    }
}
