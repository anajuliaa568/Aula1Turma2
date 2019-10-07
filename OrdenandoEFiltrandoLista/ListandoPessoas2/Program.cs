using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas 
            //podemos agora listar e demais funcionalidades
            PessoaController pessoaController 
                //Nesta parte ao iniciar em memoria 
                //Iniciamos o contrutor
                = new PessoaController();

            //Aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublica
                //Usamos o ForEach do linq para percorrer a lista
                .ForEach(i => //criamos a variavel i para receber o item da nossa lista
                //Imprimimos a informação de cada item da nossa lista
                MostraInformacoes(i));

         

            Console.WriteLine("");
            Console.WriteLine("_________________________LISTA ORDENADA POR NOME______________________________");
            Console.WriteLine("");

            pessoaController
                .GetPessoaOrdenadaAsc()
                .ForEach(i => MostraInformacoes(i));

            Console.WriteLine("");
            Console.WriteLine("_________________________LISTA ORDENADA POR DATA_____________________________");
            Console.WriteLine("");

            pessoaController
                .GetPessoasOrdenadasDescPelaDataNascimento()
                .ForEach(i => MostraInformacoes(i));


            Console.WriteLine("");
            Console.WriteLine("___________________________LISTAR MAIS RICO______________________________________");
            Console.WriteLine("");

            pessoaController
                .GetPessoaComMaisPilasNaCarteira(500)

                .ForEach(i=> MostraInformacoes(i));
            Console.WriteLine("");
            Console.WriteLine("_________________________________Lista maiores de 18__________________________");
            Console.WriteLine("");
            pessoaController
                .GetPessoasComIdadeMaiorA()
                .ForEach(i => MostraInformacoes(i));

            Console.WriteLine("_________________________Lista meiores de 18___________________________________");
            pessoaController
                .GetPessoasComIdadeMenorQue()
                .ForEach(i => MostraInformacoes(i));

            Console.ReadKey();
        }
        /// <summary>
        /// metodo para mostrar a informação inicisl de cada listagem 
        /// </summary>
        /// <param name="nomeAcao">Identificador de listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("----{0,20}----", nomeAcao));
        }
            

        private static void MostraInformacoes(Pessoa pessoa)

        {
            //Nosso templete que apresenta as informaçoes bonitinhas
            string template = "Id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";
            // Recebemos as informaçoes bonitinhas com o string fomart
            string textoFormatado = string.Format(template,
            //string.format e usado para formatar as strings deixando nosso texto padrao e apresentavel 

            //Nosso primeiro parametro é o templete que usamos 
            //após informar o templete,temos os parametros 
            //este metodo espera um array de parametros ou seja podemos passar muitos parametros.
            pessoa.Id,
            pessoa.Nome,
            pessoa.DataNascimento.ToShortDateString(),
            pessoa.Carteira.ToString("C"));
            
            Console.WriteLine(textoFormatado);
        }

    }
}
