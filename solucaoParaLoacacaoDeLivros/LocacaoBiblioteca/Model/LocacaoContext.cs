using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext  : DbContext
    {
        public DbSet<Livro> ListaDeLivros { get; set; } 
        public DbSet<Usuario> ListaDeUsuarios { get; set; }
        
    }
}
