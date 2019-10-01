﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
   public class VendasController
    {
        SistemaVendasContext VendasContext = new SistemaVendasContext();

        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return VendasContext.ListaVendasPublica;
            else
                return VendasContext.ListaVendasPublica.FindAll(X => X.Data.Month == mes);
        }

        
    }
}
