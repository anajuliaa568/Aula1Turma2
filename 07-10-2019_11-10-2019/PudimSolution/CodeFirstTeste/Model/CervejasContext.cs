using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTeste.Model
{
   
        public partial class CervejaContextDb : DbContext
        {
            public CervejaContextDb(string conexao)
                : base(conexao)// aqui alteramos nosso construtor de 
            {
            }

            public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
            public virtual DbSet<Cerveja> Cervejas { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            }
        }
    
}

