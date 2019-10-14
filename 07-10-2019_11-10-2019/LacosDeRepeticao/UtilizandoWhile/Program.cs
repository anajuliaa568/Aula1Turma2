using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (count < 1000000)
            {
                //interno
                // se tiver uma alta interação não é necessario a operação abaixo, apenas count++; que vai muito mais rapido.
                Console.WriteLine($"Número: {count}");
                count++;

            }

            Console.WriteLine("Terminou  loop");
            Console.ReadKey();
        }    

    }
}
