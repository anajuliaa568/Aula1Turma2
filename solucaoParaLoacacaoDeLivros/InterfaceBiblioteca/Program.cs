using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO.Internal;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    
    class Program
    {
        static LivrosController livrosController = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Locação de Livro 1.0");
            //while é só precisa de true ou false 
            //! se for invalido vai repetir o processo varias vezes 
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha invalida: ");

            MostraMenuSistema();

            Console.ReadKey();
        }


        /// <summary>
        /// mostrar no console o menu disponivel.
        /// </summary>
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
           {  

                Console.Clear();
                Console.WriteLine("Sistema de Locação de Livro 1.0");
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuario");
                Console.WriteLine("2 - listar livro");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - cadastro de usuario");
                Console.WriteLine("5 - remover usuario");
                Console.WriteLine("6 - Remover Livro");
                Console.WriteLine("7 - Trocar Usuario");           
            
              //aqui definimos se for diferente de 0 mantemos o sistema  aberto se não finalizamos 
              // var resposta = int.Parse(Console.ReadLine());                                   
                //aqui vamos pegar numero digitado

                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (menuEscolhido)
                {
                    case 1:
                        MostrarUsuarios();
                        MostraMenuSistema();
                        break;
                    case 2:
                        
                        //Livro livro = new Livro();
                        // Console.WriteLine(livro.Nome);
                        MostrarLivro();
                        MostraMenuSistema();
                        break;
                    case 3:
                        //Livro livro = new Livro();
                        // Console.WriteLine(livro.Nome);
                        //MostrarLivro();
                        // MostraMenuSistema();
                        AdicionarLivro();
                        break;
                    case 4:
                        AdicionarUsuarios();
                        break;
                    case 5:
                        RemoverUsuarioPeloId();
                        break;
                    case 6:
                        RemoverLivroPeloId();
                        break;
                    case 7:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e Senha Invalidas");
                        //RealizaLoginSistema();
                       // MostraMenuSistema();
                        break;
                    default:
                        break;

                }
            }
               //Aqui vamos pegar número digitado 
               // var menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
               //Execetar a proxima função
        }
        private static void RemoverUsuarioPeloId()
        {
            Console.WriteLine("Remover o usuário pelo Id no sistema");
            MostrarUsuarios();
            Console.WriteLine("Informe o ID para desativar dosistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            usuarioController.RemoverUsuarioPorId(usuarioID);

            Console.WriteLine("Usuário desativado com sucesso!");
            Console.ReadKey();
        }
       
        /// <summary>
        /// Metodo que adiciona dentro da nossa lista um novo resgitro de livro 
        /// </summary>
        public static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema 
            Console.WriteLine("Cadastrar livro dentro do sistema");
            //informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            var nomeDoLivro = Console.ReadLine();
            //"LivrosController" livros controle é nosso objeto em memoria 
            //Com isso temos nele disponivel ferramentas que nos ajudam a realiazar as tarefas 
            //como adicionar um item a nossa lista de livros 
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui atribuimos o nome que damos ao livro na prioridade Nome de nosso livro 
                //Com sinal de apenas "=" temos contribuição, passagem de valor.
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.ReadKey();
        }
            

        private static void MostrarUsuarios()
        {
           usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id: {i.Id} Login Usuario:{i.Login}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza os procedimentos  completos de login dentro do sistema 
        /// como solitação de login e senha pelo console assim como as respectivas 
        /// validaçães que o mesmo precisa para entrar no sistema 
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha forem informados estiverem corretos </returns>
        private static bool RealizaLoginSistema()
        {
            Console.Clear();
            Console.WriteLine("Informe seu login e senha para acessar o sistema");

            Console.WriteLine("Login:");
            var senhadoUsuario = Console.ReadLine();
            Console.WriteLine("Senha: ");
            var LoginDoUsuario = Console.ReadLine();

            

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = LoginDoUsuario,
                Senha = senhadoUsuario

            });


        }
        public static void MostrarLivro()
        {
            livrosController.RetorneListaDeLivros().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome do Livro:{i.Nome}"));

            Console.ReadKey();

        }
        private static void AdicionarUsuarios()
        {
            Console.WriteLine("Cadastrar usuario dentro do sistema:");

            Console.WriteLine("Informe seu login:");            
            var loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua senha:");
            var senhaUsuario = Console.ReadLine();

            usuarioController.CadastroUsuario(new Usuario()
            {
               Login= loginUsuario,
               Senha = senhaUsuario
            });

            Console.WriteLine("Usuario Cadastrado com sucesso!");
            Console.ReadKey();
        }   
        /// <summary>
        /// Metodo que remove o livro pelo id 
        /// </summary>

        private static  void RemoverLivroPeloId()
        {
            Console.WriteLine("Remover livro");
            MostrarLivro();
            Console.WriteLine("Informe Id para remover livro");
            var livroId = int.Parse(Console.ReadLine());

            livrosController.RemoverLivroPeloId(livroId);

            Console.WriteLine("Livro removido com sucesso!");
            Console.ReadKey();

        }
       
      

        
            
        

    }
}
