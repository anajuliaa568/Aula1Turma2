using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Model;
using ListandoPessoas2.Controller;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoasController pessoaController = new PessoasController();

            pessoaController.ListaDePessoasPublica
              //usamos o forEach do linq para percorrer a lista 
              .ForEach(i => mostrarInformacoes(i));

            Console.ReadKey();
        }
        private static void mostrarInformacoes(Pessoa pessoa)
        {
            string templete = "Id {0:3} Nome: {4:10}";
            string testoFormatado = string.Format(templete, pessoa.Id, pessoa.Nome);
            Console.WriteLine(testoFormatado);
        }
    }
}
