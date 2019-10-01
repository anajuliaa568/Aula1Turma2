using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtividadeDeTerca
{
    public class Program
    {
        static void Main(string[] args)
        {


            MarcaCarros();
            Cervejas();
            Arvore();
            AreaQuadrado();
        }
        public static void AreaQuadrado()
        {
            Console.WriteLine("informe o valor do lado do quadrado:");
            double lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = lado * lado;
            Console.WriteLine($"A area do quadrado é:" + area.ToString(CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
        public static void Arvore()
        {
            var arvore = new[]
            {
                   @"                           vv                                ",
                   @"                       vvv^^^^vvvvv                          ",
                   @"                   vvvvvvvvv^^vvvvvv^^vvvvv                  ",
                   @"          vvvvvvvvvvv^^^^^^^^^^^^^vvvvv^^^vvvvv              ",
                   @"      vvvvvvv^^^^^^^^^vvv^^^^^^^vvvvvvvvvvv^^^vvv            ",
                   @"    vvvv^^^^^^vvvvv^^^^^^^vv^^^^^^^vvvv^^^vvvvvv             ",
                   @"   vv^^^^^^^^vvv^^^^^vv^^^^vvvvvvvvvvvv^^^^^^vv^             ",
                   @"   vvv^^^^^vvvv^^^^^^vvvvv^^vvvvvvvvv^^^^^^vvvvv^            ",
                   @"    vvvvvvvvvv^^^v^^^vvvvvv^^vvvvvvvvvv^^^vvvvvvvvv          ",
                   @"     ^vv^^^vvvvvvv^^vvvvv^^^^^^^^vvvvvvvvv^^^^^^vvvvvv       ",
                   @"       ^vvvvvvvvv^^^^vvvvvv^^^^^^vvvvvvvv^^^vvvvvvvvvv^v     ",
                   @"          ^^^^^^vvvv^^vvvvv^vvvv^^^v^^^^^^vvvvvv^^^^vvvvv    ",
                   @"   vvvv^^vvv^^^vvvvvvvvvv^vvvvv^vvvvvv^^^vvvvvvv^^vvvvv^     ",
                   @"  vvv^vvvvv^^vvvvvvv^^vvvvvvv^^vvvvv^v##vvv^vvvv^^vvvvv^v    ",
                   @"   ^vvvvvv^^vvvvvvvv^vv^vvv^^^^^^_____##^^^vvvvvvvv^^^^      ",
                   @"      ^^vvvvvvv^^vvvvvvvvvv^^^^/\@@@@@@\#vvvv^^^             ",
                   @"           ^^vvvvvv^^^^^^vvvvv/__\@@@@@@\^vvvv^v             ",
                   @"              ^^vvvvvvvvvvv / ____\@@@@@@\vvvvvvv            ",
                   @"                       \_ ^\|[-:] || --| |                   ",
                   @"                        \   |[  :]||_ /| |                   ",
                   @"                         \\ ||___:]____| |                   ",
                   @"                           \   ;=; /                         ",
                   @"                              |;=;|                          ",
                   @"                           ; ();=;|                          ",
                   @"                            || ;=;|                          ",
                   @"                          / / \;=;\                          ",
            };
            foreach (string line in arvore)
                Console.WriteLine(line);
            Console.ReadKey();
        }
        public static void Cervejas()
        {
            var lista = new List<string>();
            lista.Add("Skol");
            lista.Add("Antarctica");
            lista.Add("Original");
            lista.Add("Budweiser");

            lista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
        public static void MarcaCarros()
        {
            var lista = new List<string>();
            lista.Add("Ferrari");
            lista.Add("Fiat");
            lista.Add("Toyota");
            lista.Add("Honda");
            lista.Add("Dodge");

            lista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
