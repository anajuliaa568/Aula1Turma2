using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // iniciando uma constante de um numero inteiro
        const int testeConst = 999;
        
        static void Main(string[] args)
        {
            string testePrimitivo = string.Empty;
            String outrotestePrimitivo;
            bool testComp;
            Boolean testeComp;// primitivos  

            bool? testeBoolNull;// permite informar verdadeiro u falso

            int numerosInteiros = 999;
            long numeroInteirolongo = 85642132394;
            

            var testeFora = string.Empty;
            testeFora = "teste";
            
           
            var teste1 = "string";// texto
            var teste2 = 'C';// Char
            var teste3 = 8; //int
            var teste4 = 3.8;// double
            var teste5 = 0x00;//ex

            // apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();

        }
    }
}
