using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, altura, area;
           

            Base = int.Parse(Console.ReadLine());
            altura = int.Parse(Console.ReadLine());
            area = int.Parse(Console.ReadLine());

            area = (Base * altura) / 2;

            Console.WriteLine("AREA " + area);
            Console.ReadKey();


        }
    }
}
