using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metedos de usuario do sistema 
    /// </summary>
   public class UsuarioController
   {
        public UsuarioController()
        {

            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"

            });

            ListaDeUsuarios.Add(new Usuario()                
            {
                Login = "pri22",
                Senha = "1234"
            });
        }
        /// <summary>
        /// metodo que realiza o login dentro do nosso sistema 
        /// para realizar o login padrao use: 
        /// login: Admin
        /// senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome USUARIO com parametro </param>
        /// <param name="senha">Senha do usuario dentro do sistema </param>
        /// <returns>Retorna verdadeiro quando existir o usuario com este login e senha </returns>
        public bool loginSistema(Usuario usuario)
        {
            return ListaDeUsuarios.Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
            
        }
        public List<Usuario> ListaDeUsuarios { get; set; }

   }
}
