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
                    "veiculoid," +
                    "marca," +
                    "modelo," +
                    "cor," +
                    "placa )" +
                    "VALUES ({0}, " +
                    "'{1}', " +
                    "'{2}', " +
                    "'{3}', " +
                    "'{4}', " +
                    "'{5}'," +
                    "'{6}'," +
                    "'{7}'," +
                    "'{8}'," +
                    "'{9}' )" ,
                    "null",
                    gastos.Descricao,
                    gastos.Responsavel,
                    gastos.Data,
                    gastos.Valor,
                    gastos.Movimentacao.Cod_Mov_Veiculos,
                    gastos.Marca,
                    gastos.Modelo,
                    gastos.Cor,
                    gastos.Placa));

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

        public DataTable buscarVeiculoPorPlaca(string placa)
        {
            String consultaE = (String.Format(
                     "SELECT * " +
                     "FROM mov_veiculos " +
                     "WHERE placa like '{0}'; ",
                     placa));
            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaE, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }

        public DataTable buscarTodosOsGastos(string dt1, string dt2)
        {
            try
            {
                String consultaE = (String.Format(
                     "SELECT * FROM GASTOS_VEICULOS where DATA >= '{0}' AND DATA <= '{1}'", dt1, dt2));
                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(consultaE, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                ConnectionFactory.Connect().Close();
                return dt;
            }catch(Exception ex)
            {
                throw new Exception("Falha ao Buscar Gastos!" + ex.Message);
            }
            return null;   
        }

    }
}
