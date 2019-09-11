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
            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";// primitivos  
        
            


            var testeFora = string.Empty;
            
           
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
