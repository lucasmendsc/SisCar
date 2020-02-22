using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class GastosBLL
    {

        public void inserirGastos(Gastos gastos)
        {
            GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
            gastosVeiculosDAL.InserirGastosVeiculos(gastos);
        }


        public DataTable consultarGastosVeiculos(int id)
        {
            GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
            return gastosVeiculosDAL.ConsultarGastosVeiculos(id);
        }

    }
}
