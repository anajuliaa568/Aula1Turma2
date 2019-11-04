using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioMinhaClasse02.Model;
using System.Globalization;


namespace ExercicioMinhaClasse02.model

{
    public class Program
    {
        static List<Pessoa> listaPessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para inserir:");
            var opcao = Console.ReadLine();

            while (opcao == "1")
            {
                AdicionarLista();
                Console.WriteLine("Digite 1 para inserir");
                opcao = Console.ReadLine();
            }
            
            Listar();
            Console.ReadKey();
        }

        public static void AdicionarLista()
        {
            Pessoa objetoPessoa = new Pessoa();

           
            Console.WriteLine("Informe o nome:");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

           Console.WriteLine("Informe o sexo:");
            char.TryParse(Console.ReadLine(), out char sexo);
            objetoPessoa.Sexo = sexo;

            Console.WriteLine("Informe a altura:");
            // objetoPessoa.Altura = double.Parse(Console.ReadLine());

            double.TryParse(Console.ReadLine(), out double altura );
            objetoPessoa.Altura = altura;

            listaPessoas.Add(objetoPessoa);

        }
        public static void Listar()
        {
            listaPessoas.ForEach(ob => Console.WriteLine($"Nome:  {ob.Nome} Idade: {ob.Idade} Sexo: {ob.Sexo} Altura: {ob.Altura}"));
        }

    }
}
    
