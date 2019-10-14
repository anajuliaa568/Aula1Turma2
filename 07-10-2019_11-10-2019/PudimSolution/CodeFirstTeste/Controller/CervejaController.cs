using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
   public class CervejaController
    {
        CervejaContextDb contextDb = new CervejaContextDb("string conexao");

        public void AddCerveja(Cerveja cerveja)
        {
            contextDb.Cervejas.Add(cerveja);
            contextDb.SaveChanges();
        }
    }
    
}
