using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate autoGenerate = new DocumentsAutoGenerate();
        static HoraDoShow horaDoShow = new HoraDoShow();
        static void Main(string[] args)
        {
            autoGenerate.CriarPastaMeusDocumentos("MEU NOME É PRISCILLA");

            autoGenerate.DeletarPastaMeusDocumentos("MEU NOME É PRISCILLA", true);

         
            autoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(x=> Console.WriteLine(x));

            horaDoShow.Birllllllllll();
            Console.ReadKey();


            // var menu = int.MinValue;
            // while (menu != 0)
            //{
            // Console.Clear();
            // Console.WriteLine("1 - Criar pasta em MeusDocumentos"); 
            // Console.WriteLine("0 - sair");

            // menu = int.Parse(Console.ReadLine());

            // switch (menu)
            // {
            //case 1: var nomePasta = Console.ReadLine();
            //  DocumentsAutoGenerate.CriarPastaMeusDocumentos(nomePasta);

            //  break;
            //}

            //}


        }
    }
}
