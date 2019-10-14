using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class AnimacoesEmFrames
    {



        // public  void Arvore()
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
                //Console.ReadKey();
        }
    


    }
    
}
