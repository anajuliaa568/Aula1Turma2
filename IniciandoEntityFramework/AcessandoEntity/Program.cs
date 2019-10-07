using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa(// Aqui utilizamos o metodo de controler 
               
                new Pessoa()// adicionar a pessoa na nossa lista 
                {
                    Nome = "Priscilla"//Novo reegistro 
                });// O metodo Addpessoa tem o SaveChanges que Realiza a gravação das 
            //informaçoes em nosso banco de dados 
                
                
            pessoa.GetPessoas()//Adicionamos a lista de pessoas 
                .ToList<Pessoa>()//Convertemos para uma lsita de pessoas 
                .ForEach(x => Console.WriteLine(x.Nome));// Mostramos em nosso console

            Console.ReadKey();

        }
    }
}
