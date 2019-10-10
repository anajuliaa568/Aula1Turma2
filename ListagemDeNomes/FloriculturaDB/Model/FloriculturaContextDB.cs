using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaDB.Model
{
    public class FloriculturaContextDB : DbContext

    {
        public DbSet<Flores> ListaFlores { get; set; }
    }
}
