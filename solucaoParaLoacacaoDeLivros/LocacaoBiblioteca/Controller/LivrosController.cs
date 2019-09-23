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
        private int IdContador = 1;
        public LivrosController()
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Primeiro Livro"
            }) ;

            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro"
            }) ;
        }

        public List<Livro> ListaDeLivros { get; private set; }
        private List<Livro> Livros { get; set; }

        public void AdicionarLivro(Livro parametroLivro )
        {
            Livros.Add(parametroLivro);
        }
        public List<Livro> RetorneListaDeLivros()
        {
            return ListaDeLivros;
        }
    }
   
    

    
}



    

    
    






    

















    

    


