using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExrcicioTextinho
{
    class Program
    {
        static void Main(string[] args)

        {

            ForeachComSplitLista();


            Console.WriteLine("Informe o seu nome");

            var texto = @"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto{Console.ReadLine()};para;depois;usar;com;o;replace";

            var textoInicial = Console.ReadLine();

            var textoInicial01 = texto.Split(';');

            foreach (var item in textoInicial01)
            {
                if (textoInicial == item)
                {
                    Console.WriteLine("texto encontrado");
                }
            }
            Console.ReadKey();


        }



        /// <summary>
        /// 
        /// </summary>
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Priscilla,idade:26;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuarios cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe o nome do sistema:");
            var nomebusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (item == nomebusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }

            Console.ReadKey();
        }

        private static void ConsultaCarros()
        {
            var conteudo = @" carro:Gol,marca: volkswagen,ano: 2000; carro: Jetta,marca: volkswagen,ano: 2012;
            carro: Sportage,marca: Kia,ano: 2011;carro: Hb20,marca: hyundai,ano: 2015";

            listarInformacoesPorNome(conteudo);

            Console.WriteLine("Digite o nome do carro para a busca:");
            var nomeDoCarro = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomeCarro = separandoInformacoes[0].Split(':')[1];

                Console.WriteLine($"Nome do Carro:{nomeCarro}");
            }
        }

        private static string[] RetornaVeiculo(string conteudo, string nomeVeiculo)
        {
            var listaDeInformacoes = conteudo.Split(';');
            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeDoCarro = obterValor(separandoInformacoes[0]);
                if (true)
                {

                }
                return separandoInformacoes;
            }
        }
    }
}
