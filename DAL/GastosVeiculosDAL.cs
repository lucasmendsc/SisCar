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

        public DataTable buscarTodosOsGastos()
        {
            try
            {
                String consultaE = (String.Format(
                     "SELECT g.data, g.descricao, g.responsavel, c.ds_marca, mod.ds_modelo, m.cor, g.valor" +
                     " FROM  gastos_veiculos as g " +
                     "join mov_veiculos as m " +
                     "on g.veiculoid = m.cod_mov_veiculos " +
                     "join marcas c " +
                     "on c.cod_marca = m.cod_marca " +
                     "join modelos mod " +
                     "on mod.cod_modelo = m.cod_modelo ; "));
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
