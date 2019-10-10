using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flores.Model;

namespace Flores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public IQueryable<Flor> GetFlores()
        {
            return contextDB.Flores.Where(i => i.Ativo == true);
        }
        public bool InserirFlor(Flor item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            if (item.Quantidade <= 0) return false;

            contextDB.Flores.Add(item);
            contextDB.SaveChanges();

            return true;
        }


    }
}
