using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Controller
{
    public class AlunoController
    {
        EntityContextDBAlunos contextDb = new EntityContextDBAlunos();

        public IQueryable<Alunos> GetAlunos()
        {
            return contextDb.ListaDeAlunos;
        }
        public void AddAlunos(Alunos Item)
        {
            contextDb.ListaDeAlunos.Add(Item);

            contextDb.SaveChanges();
        }

    }
}
