using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCarro.Model
{
   public class CarrosContext
    {
        public int IdContadorCarros { get; set; }
       

        public CarrosContext()
        {
            ListaDeCarros = new List<Carros>();
            ListaDeCarros.Add(new Carros() { Id = 1, Nome = "	Risus Company	 "                  , Valor = 7.200, Quantidade = 18, Data = DateTime.Parse("	29/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 2, Nome = "	Risus Associates	 "              , Valor = 9.961, Quantidade = 4, Data = DateTime.Parse("	10/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 3, Nome = "	Et Libero Proin Foundation	 "      , Valor = 8.710, Quantidade = 17, Data = DateTime.Parse("	24/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 4, Nome = "	Cursus Et Ltd	 "                  , Valor = 9.010, Quantidade = 17, Data = DateTime.Parse("	26/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 5, Nome = "	Odio Etiam Ligula Company	 "      , Valor = 5.245, Quantidade = 8, Data = DateTime.Parse("	16/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 6, Nome = "	Eu Nibh Inc.	 "                  , Valor = 7.922, Quantidade = 9, Data = DateTime.Parse("	27/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 7, Nome = "	Tellus Limited	 "                  , Valor = 7.294, Quantidade = 7, Data = DateTime.Parse("	26/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 8, Nome = "	Imperdiet PC	 "                  , Valor = 8.305, Quantidade = 5, Data = DateTime.Parse("	06/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 9, Nome = "	Elit Inc.	 "                      , Valor = 5.398, Quantidade = 18, Data = DateTime.Parse("	09/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 10, Nome = "	Quam A Limited	 "                  , Valor = 5.398, Quantidade = 14, Data = DateTime.Parse("	09/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 11, Nome = "	Adipiscing Institute	 "          , Valor = 8.133, Quantidade = 4, Data = DateTime.Parse("	24/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 12, Nome = "	Posuere At Velit Ltd	 "          , Valor = 5.121, Quantidade = 15, Data = DateTime.Parse("	19/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 13, Nome = "	Nunc In Industries	 "              , Valor = 8.902, Quantidade = 2, Data = DateTime.Parse("	21/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 14, Nome = "	Integer Vitae Nibh Corporation	 "  , Valor = 6.313, Quantidade = 20, Data = DateTime.Parse("	02/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 15, Nome = "	Tellus Nunc Lectus Company	 "      , Valor = 9.650, Quantidade = 2, Data = DateTime.Parse("	20/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 16, Nome = "	Suspendisse LLC	 "                  , Valor = 5.319, Quantidade = 12, Data = DateTime.Parse("	24/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 17, Nome = "	Mauris Vestibulum Corporation	 "  , Valor = 5.790, Quantidade = 5, Data = DateTime.Parse("	14/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 18, Nome = "	Sed Nec Corp.	 "                  , Valor = 8.421, Quantidade = 2, Data = DateTime.Parse("	05/05/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 19, Nome = "	Enim Nisl Elementum Inc.	 "      , Valor = 5.904, Quantidade = 6, Data = DateTime.Parse("	26/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 20, Nome = "	Ac Mattis Semper Corporation	 "  , Valor = 5.110, Quantidade = 4, Data = DateTime.Parse("	14/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 21, Nome = "	Donec Tempus Lorem LLC	 "          , Valor = 8.576, Quantidade = 16, Data = DateTime.Parse("	29/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 22, Nome = "	Tempor Augue Ac Ltd	 "              , Valor = 9.072, Quantidade = 16, Data = DateTime.Parse("	09/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 23, Nome = "	Diam Duis Mi LLC	 "              , Valor = 8.472, Quantidade = 4, Data = DateTime.Parse("	23/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 24, Nome = "	Aliquam Corp.	 "                  , Valor = 6.607, Quantidade = 4, Data = DateTime.Parse("	28/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 25, Nome = "	Montes Institute	 "              , Valor = 6.176, Quantidade = 8, Data = DateTime.Parse("	19/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 26, Nome = "	Hendrerit Institute	 "              , Valor = 8.387, Quantidade = 11, Data = DateTime.Parse("	17/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 27, Nome = "	Erat Etiam Vestibulum Corporatio "  , Valor = 7.584, Quantidade = 9, Data = DateTime.Parse("	02/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 28, Nome = "	Adipiscing Ltd	 "                  , Valor = 7.887, Quantidade = 9, Data = DateTime.Parse("	19/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 29, Nome = "	In Tempus Eu Inc.	 "              , Valor = 5.233, Quantidade = 16, Data = DateTime.Parse("	20/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 30, Nome = "	Elit Institute	 "                  , Valor = 7.359, Quantidade = 11, Data = DateTime.Parse("	12/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 31, Nome = "	Aliquam Erat LLC	 "              , Valor = 8.842, Quantidade = 4, Data = DateTime.Parse("	14/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 32, Nome = "	A Feugiat Tellus PC	 "              , Valor = 9.176, Quantidade = 4, Data = DateTime.Parse("	10/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 33, Nome = "	Aliquet Incorporated	 "          , Valor = 9.057, Quantidade = 8, Data = DateTime.Parse("	26/04/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 34, Nome = "	Dolor Dolor Tempus Institute	 "  , Valor = 8.433, Quantidade = 15, Data = DateTime.Parse("	31/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 35, Nome = "	Risus Odio Auctor PC	 "          , Valor = 8.286, Quantidade = 11, Data = DateTime.Parse("	29/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 36, Nome = "	Aliquet Molestie Tellus Corp.	 "  , Valor = 8.779, Quantidade = 1, Data = DateTime.Parse("	05/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 37, Nome = "	Ipsum Corp.	 "                      , Valor = 5.568, Quantidade = 15, Data = DateTime.Parse("	10/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 38, Nome = "	Mi Lacinia Foundation	 "          , Valor = 7.442, Quantidade = 20, Data = DateTime.Parse("	09/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 39, Nome = "	Cubilia Curae; Corp.	 "          , Valor = 8.421, Quantidade = 7, Data = DateTime.Parse("	26/05/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 40, Nome = "	Velit Sed Malesuada Associates	 "  , Valor = 9.841, Quantidade = 6, Data = DateTime.Parse("	07/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 41, Nome = "	Duis Foundation	 "                  , Valor = 9.849, Quantidade = 6, Data = DateTime.Parse("	08/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 42, Nome = "	Erat Semper Consulting	 "          , Valor = 6.168, Quantidade = 10, Data = DateTime.Parse("	10/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 43, Nome = "	Turpis Inc.	 "                      , Valor = 7.758, Quantidade = 7, Data = DateTime.Parse("	12/08/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 44, Nome = "	Aenean Industries	 "              , Valor = 8.770, Quantidade = 12, Data = DateTime.Parse("	10/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 45, Nome = "	Nulla Industries	 "              , Valor = 8.884, Quantidade = 8, Data = DateTime.Parse("	10/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 46, Nome = "	Semper Egestas Urna Inc.	 "      , Valor = 9.428, Quantidade = 11, Data = DateTime.Parse("	26/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 47, Nome = "	Donec Luctus Aliquet Industries	 "  , Valor = 5.928, Quantidade = 8, Data = DateTime.Parse("	11/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 48, Nome = "	Cum Sociis Natoque Foundation	 "  , Valor = 7.506, Quantidade = 2, Data = DateTime.Parse("	21/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 49, Nome = "	Vitae Sodales Limited	 "          , Valor = 8.912, Quantidade = 8, Data = DateTime.Parse("	22/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 50, Nome = "	Tellus Sem Mollis Ltd	 "          , Valor = 9.615, Quantidade = 20, Data = DateTime.Parse("	30/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 51, Nome = "	Nulla Tincidunt LLC	 "              , Valor = 5.562, Quantidade = 19, Data = DateTime.Parse("	22/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 52, Nome = "	Sed Dictum Institute	 "          , Valor = 9.243, Quantidade = 14, Data = DateTime.Parse("	26/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 53, Nome = "	Sed Turpis Company	 "              , Valor = 7.243, Quantidade = 14, Data = DateTime.Parse("	20/08/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 54, Nome = "	Vitae Diam Proin Associates	 "      , Valor = 6.631, Quantidade = 2, Data = DateTime.Parse("	10/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 55, Nome = "	Curabitur Inc.	 "                  , Valor = 8.090, Quantidade = 3, Data = DateTime.Parse("	09/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 56, Nome = "	Suscipit Est Ac LLC	 "              , Valor = 8.567, Quantidade = 15, Data = DateTime.Parse("	08/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 57, Nome = "	Neque Morbi Industries	 "          , Valor = 5.171, Quantidade = 1, Data = DateTime.Parse("	03/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 58, Nome = "	Non Ltd	 "                          , Valor = 5.102, Quantidade = 19, Data = DateTime.Parse("	14/08/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 59, Nome = "	Arcu Vestibulum Ante Institute	 "  , Valor = 6.128, Quantidade = 1, Data = DateTime.Parse("	08/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 60, Nome = "	Nulla Foundation	 "              , Valor = 7.636, Quantidade = 6, Data = DateTime.Parse("	14/04/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 61, Nome = "	Quis Massa Mauris LLP	 "          , Valor = 5.053, Quantidade = 3, Data = DateTime.Parse("	09/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 62, Nome = "	Ut Incorporated	 "                  , Valor = 6.922, Quantidade = 17, Data = DateTime.Parse("	16/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 63, Nome = "	Aenean Egestas Corp.	 "          , Valor = 8.142, Quantidade = 19, Data = DateTime.Parse("	17/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 64, Nome = "	Fusce Mi Lorem Consulting	 "      , Valor = 8.312, Quantidade = 20, Data = DateTime.Parse("	19/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 65, Nome = "	A Sollicitudin Orci PC	 "          , Valor = 5.864, Quantidade = 1, Data = DateTime.Parse("	20/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 66, Nome = "	Sociosqu Limited	 "              , Valor = 5.985, Quantidade = 12, Data = DateTime.Parse("	28/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 67, Nome = "	Ullamcorper Duis Cursus LLC	 "      , Valor = 5.164, Quantidade = 7, Data = DateTime.Parse("	22/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 68, Nome = "	Nibh Lacinia LLC	 "              , Valor = 7.760, Quantidade = 10, Data = DateTime.Parse("	13/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 69, Nome = "	Eu Dui Institute	 "              , Valor = 7.695, Quantidade = 8, Data = DateTime.Parse("	12/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 70, Nome = "	Fringilla Purus Mauris Consulting " , Valor = 5.845, Quantidade = 6, Data = DateTime.Parse("	01/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 71, Nome = "	Donec Tempus Lorem Industries	 "  , Valor = 8.472, Quantidade = 19, Data = DateTime.Parse("	09/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 72, Nome = "	Auctor Incorporated	 "              , Valor = 6.795, Quantidade = 1, Data = DateTime.Parse("	04/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 73, Nome = "	Enim Etiam Imperdiet Corporation "  , Valor = 6.532, Quantidade = 13, Data = DateTime.Parse("	14/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 74, Nome = "	Non Cursus Non Industries	 "      , Valor = 9.569, Quantidade = 16, Data = DateTime.Parse("	25/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 75, Nome = "	Ut Semper Incorporated	 "          , Valor = 5.760, Quantidade = 18, Data = DateTime.Parse("	14/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 76, Nome = "	Sed Malesuada Corporation	 "      , Valor = 6.561, Quantidade = 4, Data = DateTime.Parse("	06/03/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 77, Nome = "	Sed Neque Consulting	 "          , Valor = 7.308, Quantidade = 2, Data = DateTime.Parse("	31/08/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 78, Nome = "	Nisl Arcu PC	 "                  , Valor = 7.260, Quantidade = 8, Data = DateTime.Parse("	19/06/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 79, Nome = "	Euismod Est Consulting	 "          , Valor = 6.020, Quantidade = 11, Data = DateTime.Parse("	27/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 80, Nome = "	Leo Vivamus Ltd	 "                  , Valor = 5.055, Quantidade = 8, Data = DateTime.Parse("	22/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 81, Nome = "	Tristique Neque Inc.	 "          , Valor = 9.268, Quantidade = 13, Data = DateTime.Parse("	25/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 82, Nome = "	In Lobortis PC	 "                  , Valor = 5.539, Quantidade = 4, Data = DateTime.Parse("	18/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 83, Nome = "	Nunc Ltd	 "                      , Valor = 6.846, Quantidade = 2, Data = DateTime.Parse("	09/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 84, Nome = "	Dictum Proin Limited "              , Valor = 5.543, Quantidade = 12, Data = DateTime.Parse("	05/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 85, Nome = "	Erat Vitae LLP	 "                  , Valor = 5.060, Quantidade = 7, Data = DateTime.Parse("	12/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 86, Nome = "	Pellentesque Ultricies Dignissim PC", Valor = 7.971, Quantidade = 15, Data = DateTime.Parse("	25/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 87, Nome = "	Phasellus Elit Company	 "          , Valor = 5.350, Quantidade = 15, Data = DateTime.Parse("	31/10/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 88, Nome = "	Luctus Felis Ltd	 "              , Valor = 9.872, Quantidade = 13, Data = DateTime.Parse("	06/01/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 89, Nome = "	Dui Suspendisse PC	 "              , Valor = 6.878, Quantidade = 7, Data = DateTime.Parse("	06/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 90, Nome = "	Odio Associates	 "                  , Valor = 7.636, Quantidade = 18, Data = DateTime.Parse("	24/07/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 91, Nome = "	Vel Company	 "                      , Valor = 7.410, Quantidade = 5, Data = DateTime.Parse("	16/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 92, Nome = "	Lobortis Institute	 "              , Valor = 5.110, Quantidade = 8, Data = DateTime.Parse("	27/05/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 93, Nome = "	Scelerisque Company	 "              , Valor = 7.983, Quantidade = 19, Data = DateTime.Parse("	03/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 94, Nome = "	Posuere Enim Company	 "          , Valor = 6.968, Quantidade = 19, Data = DateTime.Parse("	22/04/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 95, Nome = "	Sem Ut Corp.	 "                  , Valor = 6.504, Quantidade = 11, Data = DateTime.Parse("	02/02/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 96, Nome = "	Dui Fusce Aliquam PC	 "          , Valor = 7.837, Quantidade = 2, Data = DateTime.Parse("	08/12/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 97, Nome = "	Nisl Sem Industries	 "              , Valor = 6.835, Quantidade = 5, Data = DateTime.Parse("	14/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 98, Nome = "	Vitae Corp.	 "                      , Valor = 7.669, Quantidade = 7, Data = DateTime.Parse("	09/11/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 99, Nome = "	Malesuada Incorporated	 "          , Valor = 5.960, Quantidade = 4, Data = DateTime.Parse("	26/09/2019	") });
            ListaDeCarros.Add(new Carros() { Id = 100, Nome = "	Mauris Ltd	 "                      , Valor = 8.974, Quantidade = 18, Data = DateTime.Parse("	16/05/2019	") });




        }

        public List<Carros> ListaDeCarros { get; set; }
        
    }
}
