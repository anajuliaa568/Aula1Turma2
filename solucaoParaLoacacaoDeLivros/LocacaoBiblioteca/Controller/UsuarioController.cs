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
        private LocacaoContext contextDB = new LocacaoContext();

           
        public UsuarioController()
        {

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
        public bool LoginSistema(Usuario usuario)
        {
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
            
        }
        
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema 
        /// </summary>
        /// <param name="parametro">Novo usuario que será adicionado a lista</param>
        public void CadastroUsuario(Usuario parametro )
        {
            //parametro.Id = contextDB.IdContadorUsuarios++;
            //adicionar o meu usuario a minha lista 
            contextDB.ListaDeUsuarios.Add(parametro);
        }
     
        /// <summary>
        /// Metodo que retonar nossa lista interna de usuario
        /// </summary>
        /// <returns>Lista Contendo os usuarios</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "where"...
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista 
        /// </summary>
        /// <param name="identificandoID"></param> parametro que identifica o usuario que será desativado
        public void RemoverUsuarioPorId(int identificandoID)
        {
            // Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista 
            // com isso conseguimos acessar as prioridades 
           contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificandoID).Ativo = false;
        }
    }
}
