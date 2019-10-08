using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RevisandoEntity.Controller
{
    //Primeiro passo deixar ela publica 
    public class CervejaController1
    {
        CervejaContextDB contextDb = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDb.Cervejas.Add(item);
                contextDb.SaveChanges();
            }

        }
        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDb.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
