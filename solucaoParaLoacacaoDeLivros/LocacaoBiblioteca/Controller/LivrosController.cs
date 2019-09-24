using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private LocacaoContext contextDB = new LocacaoContext();

        public LivrosController()
        {
           
        }

       // public List<Livro> ListaDeLivros { get; private set; }
        //private List<Livro> Livros { get; set; }

        public void AdicionarLivro(Livro parametroLivro )
        {
            
            parametroLivro.Id = contextDB.IdContadorLivros++;

           
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetorneListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// metodo para desativar o registro de livro pelo id 
        /// </summary>
        /// <param name="livroId"></param>
        public void RemoverLivroPeloId(int livroId)
        {
            var Livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == livroId);
            if (Livro != null)
                Livro.Ativo = false;
        }
    }
   
    

    
}



    

    
    






    

















    

    


