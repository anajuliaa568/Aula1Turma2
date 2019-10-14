using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe publica
  public  class Cerveja
    {
        //chamada pelo (control + ".")
        [Key]// chave primaria, auto incrementada
        public int Id { get; set; }
        //Aqui definimos a quantidade maxima de caracteres 
        //para nosso campo "Nome" dentro do banco 
        [StringLength(50)]
        [Required]//IDENTIFICA QUE ESTE CAMPO É OBRIGATÓRIO
        public string Nome { get; set; }
        [StringLength(30)]//Tamanho maximo de caracteres para o tipo

        public string Tipo { get; set; }
        public double Teor { get; set; }


    }
}
