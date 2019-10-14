using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    //1- Usar nossa pasta model 'using CatalogoCelulares.Model;'
    //2 - Criar uma instancia nova da nossa context 
   public class CelularController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
        //listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas 
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo /returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true);
        }      
        //Atualização
        /// <summary>
        /// METODO QUE ATUALIZA UM REGISTRO VALIDO DO NOSSO SISTEMA 
        /// </summary>
        /// <param name="item">ITEM QUE VAMOS ATUALIZAR</param>
        /// <returns>RETORNA VERDADEIRO CASO O ITEM EXISTA</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular =//definimos uma variavel para o celular
                contextDB.//usamos o banco de dados 
                Celulares.//Nossa tabela que tem os celulares 
                FirstOrDefault(x => x.Id == item.Id);

            if (celular == null)

                return false;
            else
            {       
                      celular.DataAlteracao = DateTime.Now;

            }
            contextDB.SaveChanges();//salvamos a informação no banco

            return true; //retornamos que foi atualizado 
        }

        //Inserção
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema 
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string //Nosso tipo que contem varios metodos prontos para string
                .IsNullOrWhiteSpace//Metodo que identifica espaços em branco
                                   //apenas ou valor null
                (item.Marca))  //nosso campo que vamos avaliar
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Valor <= 0)//Verificamos se o valor informado é maior que 0
                return false;

            //Salvamos nossa item dentro de nossa tabela em memoria 
            contextDB.Celulares.Add(item);
            //Salvamos agora no banco esta informação
            contextDB.SaveChanges();
            //retornamos verdadeiro para indicar sucesso quando inserir o registro
            return true;
        }
        //'Remoção'
        /// <summary>
        /// Metodo utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">ide que vamos desativar </param>
        /// <returns>Retornar verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //nossa variavel 
                contextDB.//Nossa base de dados 
                Celulares.//Tabela de celular
                FirstOrDefault// buscamos o item para desativar 
                (x => x.Id == id);// informamos a regra de budca por Id 

            if (celular == null)//verificamos se este item existe 
                return false;//Caso não ele sai de nosso metodo

            celular.Ativo = false;//desativamos o item 

            contextDB.SaveChanges();//salvamos em nosso banco
            return true;
        }

        
    }
}
