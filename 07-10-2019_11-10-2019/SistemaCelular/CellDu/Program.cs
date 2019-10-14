using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    public class Program
    {
        // 1 - colocar console app para startar o projeto 
        // 2 - adicionar referencia CatalagoCelulares
        // 3 - Adicionar Entity em nosso projeto 'tools - Nuget pack...'
        // 4 - Adicionar using ao nosso projeto Model, Controller
        static CelularController celulares = new CelularController();
        static void Main(string[] args)
        {
            //Definimos uma opção de menu inicial 
            var opcao = int.MinValue;
            //definimos que enquanto for diferente de zero ele continua em  nosso loop 
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine(" 1 - Inserir Celular");
                Console.WriteLine(" 2 - Atualizar celular");
                Console.WriteLine(" 3 - Remover celular");
                Console.WriteLine("4 - Listar Celular");
                Console.WriteLine(" 0 - para sair");

                //Obtemos o menu escolhido pelo usuario 
                opcao = int.Parse(Console.ReadLine());
                //Swich nos ajuda com a ecolha da opcao 
                switch (opcao)
                {
                    //Caso for opção 1 ele inserir um celular 
                    case 1:
                        InserirCelular();
                        break;
                        //Caso for a opção 2 ele atualiza um celular cadastrado 
                    case 2: AtualizarCelular();
                        break;
                    case 3: RemoverCelular();
                        break;
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema");
                        break;
                    default:
                        Console.WriteLine("opção invalida ");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();

            }

        }
        //Inserir
        static public void InserirCelular()
        {
            //Apresentamos a tela em que estamos 
            Console.WriteLine(" -- Inserir Celular --");
            Console.WriteLine("Informe o marca do celular");
            //Obtenos A marca do aparelho
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");
            var modelo = Console.ReadLine();
            //obtemos o valor do aparelho 
            Console.WriteLine("Infome o valor do aparelho");
            var valor = double.Parse(Console.ReadLine());

            var resultado = celulares.// Nossa controler pelo nome que damos a ela 
                InserirCelular(new CatalogoCelulares.Model.Celular()//um novo celular
                {
                    Marca = marca,
                    Modelo = modelo,
                    Valor = valor
                });
            //Verificamos se o resultado é verdadeiro ou falso 
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else// caso falso apresenta o aviso 
                Console.WriteLine("Erro ao cadastrar aparelho");

        }
        //Atualizar 
        public static void AtualizarCelular()
        {
            //Apresentamos a tela em que estamos 
            Console.WriteLine(" -- Atualizar Celular --");
            //Listamos aqui para identificar o item que vamos alterar 
            ListarCelular();
            //Obtemos o Id informado 
            Console.WriteLine("Informe o Id para alteração de registro");
            var celularId = int.Parse(Console.ReadLine());

            //Obtivemos do banco o item completo que vamos atualizar
            var celular = celulares.GetCelulares().FirstOrDefault(x => x.Id == celularId);

            if (celular == null)
            {
                //Informo que esse Id não encontrou um registro 
                Console.WriteLine("Id Informado Invalido");
                return;
            }

            Console.WriteLine("Informe o marca do celular");
            //Obtenos A marca do aparelho
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");
            celular.Modelo = Console.ReadLine();

            //obtemos o valor do aparelho 
            Console.WriteLine("Infome o valor do aparelho");
            celular.Valor = double.Parse(Console.ReadLine());

            var resultado = celulares.AtualizarCelular(celular);

            if (resultado)

                Console.WriteLine("Celular atualizado com sucesso");

            else
                Console.WriteLine("Erro aoa atualizar aparelho");
           
        }


        //Remover 
        public static void RemoverCelular()
        {

            //Apresentamos a tela em que estamos 
            Console.WriteLine(" -- Remover Celular --");
            //Listamos aqui para identificar o item que vamos alterar 
            ListarCelular();

            //Obtemos o Id informado 
            Console.WriteLine("Informe o Id para remoção de registro");
            var celularId = int.Parse(Console.ReadLine());
            //metodo que remove o celular de nosso sistema 

            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao renovar aparelho");

        }

        //Listar
        static public void ListarCelular()
        {
            Console.WriteLine(" -- Lista de Celulares --");
            //Listamos aqui para identificar o item que vamos alterar 
            celulares.GetCelulares().ToList<Celular>().ForEach(x => Console.WriteLine
            ($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Valor{x.Valor}"));

        }

    }
}
