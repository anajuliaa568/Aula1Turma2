using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Model;

 namespace ListandoPessoas2.Controller
{
   public class PessoasController
    {
        private List<Pessoa> listaDePessoas { get; set; }
        /// <summary>
        /// o metodo construtor ajuda a iniciar nosssa classe para utilizarmos de maneira 
        /// correta as informações internas, com isso podemos iniciar nossa lista de pessoas.
        /// </summary>
        public PessoasController()
        {
            //iniciamos a lista de pessoas dentro do nosso metodo construtor 
            listaDePessoas = new List<Pessoa>();


            
            Id = 1, Nome = Spears, DataNascimento = 07 / 11 / 2004, Carteira = 846.96;
            Id = 2,    Nome = Swanson      , DataNascimento = 20 / 06 / 2003, Carteira = 233.09;
            Id = 3,    Nome = Gay          , DataNascimento = 03 / 12 / 2001, Carteira = 911.92;
            Id = 4,    Nome = Gregory      , DataNascimento = 02 / 01 / 2000, Carteira = 469.01;
           Id = 5,    Nome = Olson        , DataNascimento = 18 / 07 / 2001, Carteira = 261.90;
            Id = 6,    Nome = Garza        , DataNascimento = 01 / 04 / 2000, Carteira = 360.41;
            Id = 7,    Nome = Sweet        , DataNascimento = 12 / 03 / 2003, Carteira = 312.76;
            Id = 8,    Nome = Cline        , DataNascimento = 26 / 03 / 2002, Carteira = 484.51;
            Id = 9,    Nome = Oliver      , DataNascimento = 05 / 07 / 2004, Carteira = 513.76;
            Id = 10,    Nome = Vang         , DataNascimento = 10 / 07 / 2000, Carteira = 271.05;
            Id = 11,    Nome = Maddox       , DataNascimento = 29 / 05 / 2004, Carteira = 783.97;
            Id = 12,    Nome = Garrett      , DataNascimento = 03 / 06 / 2006, Carteira = 154.11;
            Id = 13,    Nome = Mcintosh     , DataNascimento = 06 / 07 / 2006, Carteira = 902.80;
            Id = 14,    Nome = Yang         , DataNascimento = 29 / 04 / 2005, Carteira = 550.48;
            Id = 15,    Nome = Hendricks    , DataNascimento = 05 / 09 / 2003, Carteira = 410.56;
            Id = 16,    Nome = Cain         , DataNascimento = 12 / 01 / 2002, Carteira = 221.13;
            Id = 17,    Nome = Blackburn    , DataNascimento = 10 / 05 / 2000, Carteira = 135.67;
            Id = 18,    Nome = Howe         , DataNascimento = 27 / 09 / 2005, Carteira = 360.14;
            Id = 19,    Nome = Pratt        , DataNascimento = 18 / 09 / 2000, Carteira = 991.83;
            Id = 20,    Nome = Sherman      , DataNascimento = 20 / 02 / 2003, Carteira = 667.00;
           



        }
        /// <summary>
        /// temos uma propriedade agora que nos retorna nossa lista com essa propriedade
        /// temos a lista completa sem regras da lista de pessoas, mas ao liberar somento o "GET" não damos 
        /// acessos para alterar fora da classe a lista apenas visualização.
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            //No get podemos retornar propriedades privada e calculo
            //de metodos quando necesario
            get { return listaDePessoas; }
        }

    }
}
