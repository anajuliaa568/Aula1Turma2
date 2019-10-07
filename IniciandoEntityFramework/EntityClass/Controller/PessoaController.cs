using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
    
    public class PessoaController
    {
        //realizo minha conexão com o banco de dados 

        EntityContextDB ContextDB = new EntityContextDB();

        public IQueryable// aqui temos nossa primeira interface com a classe 
            // IQueryable essa classe contem varias funcionalidades prontas 
            // para usar igual ao banco de dados como os selects 
            <Pessoa> GetPessoas()
        {
            return ContextDB.ListaDePessoas;
        }
        /// <summary>
        /// Metodo adiciionar pessoa no banco de dados 
        /// </summary>
        /// <param name="item">Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            ContextDB // Noso banco de dados 
                .ListaDePessoas//nossa tabela pessoa 
                .Add(item);// Adicionamos o item 

            ContextDB.SaveChanges();// Salvamos o banco 
        }
    }
}
