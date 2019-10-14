using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
   public class CelularesContextDB : //aqui definimos nossa herança
        DbContext //aqui definimos que vamos herdar toda a caixa de ferramentas de EntityFramework
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Celular> Celulares { get; set; }
        

    }
}
