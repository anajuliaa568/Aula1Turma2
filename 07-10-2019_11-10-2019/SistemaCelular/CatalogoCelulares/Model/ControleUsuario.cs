using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
  public class ControleUsuario
    {
        //Definimos o campo com o valor default 'true' para nossos registros
        public bool Ativo { get; set; } = true;
        //Definimos 0 para usuario criado pelo sistema sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;
        //Definimos para alteração do sistema quando não logado usuario 0
        public int UsuarioAlteracao { get; set; } = 0;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
