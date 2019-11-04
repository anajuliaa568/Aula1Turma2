using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {/// <summary>
     /// 
     /// </summary>
     /// <returns>Retorna o que o nosso app faz</returns>
        public string get()
        {
            return "App para poder beber hoje";
        }

        public string get(int anoNascimento, string nomeUsuario = "Default")
        {

            if ((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $" Olá {nomeUsuario} De acordo com os calculos realizados em nosso servidor" +
                    "o sistema identifica que voce poderar desfrutar de "
                    + " rescursos hidrics alcoolicos";
            }
            else
            {
                return $" Olá {nomeUsuario} Felizmente as fazendas em nosso territorio ainda produzem"
                    + "leite e sucos naturais para voce desfrutar";
            }
        }
    }
}
