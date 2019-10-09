using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
   public class Livro : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]//definição de tamanho maximo do campo 
        [Required]//Definindo campo obrigatorio
        public string Nome { get; set; } = "Senhor dos aneis";
      
    }
}
