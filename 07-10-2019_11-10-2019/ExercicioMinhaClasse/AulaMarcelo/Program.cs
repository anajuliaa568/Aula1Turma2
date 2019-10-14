using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMarcelo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();

           // HashSet<int> dados = new HashSet<int>();
           // dados.Add(10);
           // dados.Add(20);
           // dados.Add(30);

            for (int i = 0; i < 10; i++)
            {
                //Gera um numero aleatório de 0 a 100
                int ValorGeradoAleatoriamente = rdm.Next(100);
                //verifica se a lista não contém este numero gerado
                if (!numeros.Contains(ValorGeradoAleatoriamente))
                {
                    //Adiciona o número gerado pelo random (que não é repetido)

                    numeros.Add(ValorGeradoAleatoriamente);
                }
                else
                {
                    i --;
                }

             //bool ehRepetido =  numeros.Contains(ValorGeradoAleatoriamente)
                //    if (!ehRepetido)
                    
                   
               // numeros.Add(ValorGeradoAleatoriamente);

            }
            Console.ReadLine();
        }
    }
}
