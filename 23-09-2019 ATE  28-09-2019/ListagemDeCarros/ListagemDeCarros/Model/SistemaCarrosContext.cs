using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carros> ListaCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaCarros = new List<Carros>();

            ListaCarros.Add(new Carros() { Id = 1, Marca = "Toyota", Modelo = "Corolla", Ano = 2002, Cilindradas = 1.0, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 2, Marca = "Honda", Modelo = "Civic", Ano = 1998, Cilindradas = 1.2, Portas = 2 });
            ListaCarros.Add(new Carros() { Id = 3, Marca = "Honda", Modelo = "City", Ano = 2011, Cilindradas = 1.1, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 4, Marca = "Toyota", Modelo = "Etios", Ano = 2005, Cilindradas = 1.3, Portas = 2 });
            ListaCarros.Add(new Carros() { Id = 5, Marca = "Toyota", Modelo = "yaris", Ano = 2001, Cilindradas = 1.6, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 6, Marca = "Toyota", Modelo = "Prius", Ano = 2010, Cilindradas = 1.3, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 7, Marca = "Honda", Modelo = "Fit", Ano = 2012, Cilindradas = 1.4, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 8, Marca = "Ford", Modelo = "Fiesta", Ano = 2015, Cilindradas = 1.1, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 9, Marca = "Ford", Modelo = "FOCUS", Ano = 2016, Cilindradas = 1.0, Portas = 4 });
            ListaCarros.Add(new Carros() { Id = 10, Marca = "Ford", Modelo = "ECOSPORT", Ano = 2009, Cilindradas = 1.6, Portas = 4 });


        }
      

    }
}
