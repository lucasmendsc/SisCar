using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Models;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace DAL
{
    public class GastosVeiculosDAL
    {

        public void InserirGastosVeiculos(Gastos gastos)
        {
            try
            {
                String insereS = (String.Format(
                    "INSERT INTO gastos_veiculos " +
                    "(id, " +
                    "descricao, " +
                    "responsavel, " +
                    "data, " +
                    "valor, " +
                    "veiculoid )" +
                    "VALUES ({0}, " +
                    "'{1}', " +
                    "'{2}', " +
                    "'{3}', " +
                    "'{4}', " +
                    "'{5}' )" ,
                    "null",
                    gastos.Descricao,
                    gastos.Responsavel,
                    gastos.Data,
                    gastos.Valor,
                    gastos.Movimentacao.Cod_Mov_Veiculos));

                FbCommand comandoInsert = new FbCommand
                    (insereS, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Gastos!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarGastosVeiculos(int id)
        {
            String consultaE = (String.Format(
                     "SELECT * " +
                     "FROM gastos_veiculos " +
                     "WHERE veiculoid = {0}; ",
                     id));
            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaE, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }


    }
}
