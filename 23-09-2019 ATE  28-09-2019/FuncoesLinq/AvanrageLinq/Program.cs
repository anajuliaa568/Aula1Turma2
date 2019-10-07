using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanrageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "xiaomi Lite 6 quand Core 120gb 32 px frontal",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Venda()
                {
                    Produto = "SLIM 3500 app",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Venda()
                {
                    Produto = "Iphone fogão 3 bocas",
                    Quantidade = 1,
                    Valor = 9999.99
                }

            };
            Console.WriteLine("Media de produtos vendidos neste mês");
            Console.WriteLine(vendas.Average(x=>x.Quantidade));
            Console.WriteLine("Media Total de vendas neste mês em R$");
            Console.WriteLine(vendas.
                //AQUI REALIZAMOS O CALCULO DE QUANTIDADE * VALOR = TOTAL DE VENDAS DO PRODUTO 
                Average(X=>(X.Quantidade * X.Valor)));
            //Average divide o valor total pela quantidade de itens em nossa lista 

            Console.ReadKey();
        }
    }
}
