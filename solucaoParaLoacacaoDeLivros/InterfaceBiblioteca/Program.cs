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
        static LivrosController listaLivros = new LivrosController();

        static UsuarioController ListaDeUsuarios = new UsuarioController();
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
            Console.Clear();
            Console.WriteLine("Sistema de Locação de Livro 1.0");
            Console.WriteLine("Menu sistema");
            Console.WriteLine("1 - Listar usuario");
            Console.WriteLine("2 - listar livro");
            Console.WriteLine("3 - Cadastrar Livro");
            Console.WriteLine("4 - Trocar Usuario");
            var menuEscolhido = int.MinValue;
            
            //aqui definimos se for diferente de 0 mantemos o sistema  aberto se não finalizamos 

            // var resposta = int.Parse(Console.ReadLine());
            while (menuEscolhido != 0)
            {
               
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
                     
                    case 4:
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

        private static void MostrarUsuarios()
        {
           ListaDeUsuarios.ListaDeUsuarios.ForEach(i => Console.WriteLine($"Login Usuario:{i.Login}"));

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
            Console.WriteLine("Informe seu login e senha para acessar:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha: ");
            var senhadoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario
            {
                Login = loginDoUsuario,
                Senha = senhadoUsuario
            };
            return usuarioController.loginSistema(usuario);


        }
        private static void MostrarLivro()
        {
            listaLivros.Livros.ForEach(i => Console.WriteLine($"Nome do Livro:{i.Nome}"));

            Console.ReadKey();

        }

    }
}
