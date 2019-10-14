using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB :
        DbContext // Dbcontext classe pronta que contem todos os processos de conexão 
        //com o banco de dados listagem das tabelas 
    {
        public DbSet// palavra reservada para o entity que indica que vamos definir 
            // uma tabela do nosso banco de dados 
            <Pessoa> // aqui definimos nossa tabela pessoa ou seja especificamos 
            // em qual de nossas classes será uma referencia de uma tabela no banco de dados 
            ListaDePessoas { get; set; }
    }
}
