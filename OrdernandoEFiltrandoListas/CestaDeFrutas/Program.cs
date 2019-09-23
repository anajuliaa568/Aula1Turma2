using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region carregando minha cesta
            var cestaDeFruta = new List<Fruta>();
            //vamos no mercado
            cestaDeFruta.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212

            });
            cestaDeFruta.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            cestaDeFruta.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion
            //neste ponto ordenamos os valores de forma decrescente pelo nome 
            cestaDeFruta.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome:{ i.Nome}"));

            Console.WriteLine("-----------------------------------");
            // aqui ordenamos os valores pelo id de forma crescente 
            cestaDeFruta.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome:{ i.Nome}"));

            Console.WriteLine("-----------------------------------Filtro peso");
            var filtroCesta = cestaDeFruta.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            //aqui filtramos os registros maiores de 100g


            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));
            //frutinha recebe  cada fruta de nossa cesta
            (from frutinha in cestaDeFruta //aqui temos a coleção de frutas 
             where frutinha.Peso > 100 // aqui escolhemos somente uma das frutas com mais de 100g
             select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));


            Console.WriteLine("--------------------------------------Filtro cores");

            var mostrandoFind = cestaDeFruta.Find(x => x.Cor == "Amarelo" || x.Cor == "vermelho");

            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");
            //aqui criamos uma variavel que receberá a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFruta.FindAll(x => x.Cor == "Amarelo" || x.Cor == "vermelho");
            //Find all com esta condição tras frutas de cor amarela  "ou" vermelha 
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));
            //aqui ordenamos lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            // Como agora ele não é mais um list<fruta> usamos o forEach para apresentar os valores 
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");
            Console.WriteLine("---------------------------------Find com Orderby");
            var cestaDeFrutaFindOrder = cestaDeFruta.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermalho");
            Console.WriteLine($"Id {cestaDeFrutaFindOrder.Id} Nome {cestaDeFrutaFindOrder.Nome}");

            
            Console.ReadKey();

        }
    }
}
