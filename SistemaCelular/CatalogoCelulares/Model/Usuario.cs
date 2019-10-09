using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
   public class Usuario : ControleUsuario
    {
        [Key] //Definido como primary Key e Identity
        public int Id { get; set; }
        [MaxLength(50)] //definimos um tamanho maximo para o campo string 
        public string Nome { get; set; }
        [MaxLength(30)]//Definimos tamanho do campo
        [Required]//Definimos que este campo é obrigatorio
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha  { get; set; }
    }
}
