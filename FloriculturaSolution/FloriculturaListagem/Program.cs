using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flores.Controller;
using Flores.Model;

namespace FloriculturaListagem
{
    public class Program
    {
        FloresController flores = new FloresController();
        static void Main(string[] args)
        {

            Console.WriteLine("okdopsdkfpskfdp");
            flores.GetFlores();
        }
    }
}
