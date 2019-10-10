﻿using LocacaoBiblioteca.Model;
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
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o lista na nossa lista
            contextDB.ListaDeLivros.Add(parametroLivro);

            //Salvamos em nosso banco de dados as informaçoes
            contextDB.SaveChanges();

            
        }
        public void DeletarLivro(int id)
        {
            //Achei o LIVRO
            var LivroQueEuAcheiNoSQL = contextDB.ListaDeLivros.FirstOrDefault(p => p.Id == id);
            //Setei o ativo do livro como falso
            LivroQueEuAcheiNoSQL.Ativo = false;
            //Salvei as alteracoes.
            contextDB.SaveChanges();

        }

        public void AtualizarLivro(Livro NovoLivro, int id)
        {
            //Achei o LIVRO
            var LivroQueEuAcheiNoSQL = contextDB.ListaDeLivros.FirstOrDefault(p => p.Id == id);
            //Setei o ativo do livro como falso
            LivroQueEuAcheiNoSQL.Nome = NovoLivro.Nome;

            //Salvei as alteracoes.
            contextDB.SaveChanges();

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

        public string ListarLivros()
        {
            string retorno ="Lista de livros /n";
            contextDB.ListaDeLivros.ToList().ForEach(x => retorno = ($"Id:{x.Id} Nome:{x.Nome}"));
            return retorno;
        }
    }
}









































