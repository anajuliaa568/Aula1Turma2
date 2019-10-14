using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace InterfaceAlunos
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {

            MenuPrincipal();
            Console.ReadKey();


        }
        private static void MenuPrincipal()
        {

            Console.WriteLine("1 - lista de Alunos");
            Console.WriteLine("2 - Incluir aluno");
            Console.WriteLine("3 - sair");

            int menuPrincipal = int.Parse(Console.ReadLine());

            switch (menuPrincipal)
            {
                case 1:
                    MostraAlunos();
                    MenuPrincipal();
                    break;
                case 2:
                    AdicionaAluno();
                    MenuPrincipal();
                    break;
                        
                default: break;
            }
        }
        public static void MostraAlunos()
        {
            aluno.GetAlunos().ToList<Alunos>()
                .ForEach(x => Console.WriteLine($"Nome:{x.Nome}  Idade:{x.Idade}"));

            Console.ReadKey();
            Console.Clear();
        }
        public  static void  AdicionaAluno()
        {
            Console.WriteLine("Informe o nome do Aluno ");
            var nomeAluno = Console.ReadLine();
            Console.WriteLine("Informe a idade");
            var idadeAluno = int.Parse(Console.ReadLine());



            aluno.AddAlunos(new Alunos()
            {
                Nome = nomeAluno,
                Idade = idadeAluno
            });
            Console.ReadKey();
            Console.Clear();

        }


    }
}
