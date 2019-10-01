using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{


    public class LocacaoContext
    {
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Primeiro Livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Segundo Livro"
            });
            ListaDeLivros.Add(new Livro());

            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "Admin",
                Senha = "Admin"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });

        }

        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }
}
