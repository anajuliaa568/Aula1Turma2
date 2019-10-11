using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBikes.Model
{
    public class BicicletaContext : DbContext
    {
        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}
