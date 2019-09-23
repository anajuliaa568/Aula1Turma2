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
        private int IdContador = 0;
        public UsuarioController()
        {

            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                //Adicionar o Id contador incrementando o memso com  ele +1 "++" 
                Id = IdContador++,
                Login = "Admin",
                Senha = "Admin"

            });

            ListaDeUsuarios.Add(new Usuario()                
            {
                Id = IdContador++,
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
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema 
        /// </summary>
        /// <param name="parametro">Novo usuario que será adicionado a lista</param>
        public void CadastroUsuario(Usuario parametro )
        {
            parametro.Id = IdContador++;
            //adicionar o meu usuario a minha lista 
            ListaDeUsuarios.Add(parametro);
        }

        public static bool LoginSistema(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo que retonar nossa lista interna de usuario
        /// </summary>
        /// <returns>Lista Contendo os usuarios</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "where"...
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista 
        /// </summary>
        /// <param name="identificandoID"></param> parametro que identifica o usuario que será desativado
        public void RemoverUsuarioPorId(int identificandoID)
        {
            // Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista 
            // com isso conseguimos acessar as prioridades 
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificandoID).Ativo = false;
        }
    }
}
