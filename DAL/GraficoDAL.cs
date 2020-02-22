using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace DAL
{
    public class GraficoDAL
    {
        public DataTable ConsultarMarca()
        {
            String ConsultaMa = (String.Format(
                "SELECT MA.DS_MARCA X, " +
                "COUNT(1) Y " +
                "FROM MOV_VEICULOS MV, " +
                "MARCAS MA " +
                "WHERE MV.COD_MARCA = MA.COD_MARCA " +
                "GROUP BY MA.DS_MARCA"));                     

            FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(ConsultaMa, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable ConsultarModelo()
        {
            String ConsultaMo = (String.Format(
                "SELECT MO.DS_MODELO X, " +
                "COUNT(1) Y " +
                "FROM MOV_VEICULOS MV, " +
                "MODELOS MO " +
                "WHERE MV.COD_MODELO = MO.COD_MODELO " +
                "GROUP BY MO.DS_MODELO"));

            FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(ConsultaMo, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
