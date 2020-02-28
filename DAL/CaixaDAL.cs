using FirebirdSql.Data.FirebirdClient;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CaixaDAL
    {

        public void novoCaixa(Caixa caixa)
        {
            try
            {
                String insereCaixa = (String.Format(
                    "INSERT INTO CAIXA (" +
                    "ID,"+
                    "OPERADOR, "+
                    "DATA, "+
                    "SALDO," +
                    "SITUACAO)"+
                    "VALUES ({0}," +
                    "'{1}',"+
                    "'{2}',"+
                    "{3},"+
                    "'{4}')",
                    "null",
                    caixa.Operador,
                    caixa.Data,
                    caixa.Saldo,
                    caixa.Situacao));

                FbCommand comandoInsert = new FbCommand(insereCaixa, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Abrir Caixa!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void fechamentoCaixa(int id)
        {
            try
            {
                String fechar = (String.Format(
                    "UPDATE CAIXA SET SITUACAO = '{0}' " +
                    "WHERE ID = {1}",
                    "F",
                    id));

                FbCommand comandoInsert = new FbCommand
                    (fechar, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Falha ao fechar o caixa!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void inserirLancamento(Lancamentos lancamentos)
        {
            try
            {
                String inserelancamento = (String.Format(
                    "INSERT INTO LANCAMENTOS (" +
                    "ID," +
                    "TIPO, " +
                    "DESCRICAO, " +
                    "DATA, "+
                    "VALOR, "+
                    "ID_CAIXA," +
                    "PLACA," +
                    "RESPONSAVEL)" +
                    "VALUES ({0}," +
                    "'{1}'," +
                    "'{2}'," +
                    "'{3}',"+
                    "{4},"+
                    "{5}," +
                    "'{6}'," +
                    "'{7}')",
                    "null",
                    lancamentos.Tipo,
                    lancamentos.Descricao,
                    lancamentos.Data,
                    lancamentos.Valor,
                    lancamentos.Caixa,
                    lancamentos.Placa,
                    lancamentos.Responsavel));

                FbCommand comandoInsert = new FbCommand
                    (inserelancamento, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao inserir lançamento no caixa!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable consultarLancamentos(int id)
        {
            try
            {
                String consultaLanc = (String.Format(
                    "SELECT *                 " +
                    "  FROM LANCAMENTOS          " +
                    " WHERE ID_CAIXA = {0}" +
                    "AND TIPO <> 'FECHAMENTO'", id));

                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(consultaLanc, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao buscar lancamentos :"+ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
            
        }
        public DataTable consultarLancamentos()
        {
            try
            {
                String consultaLanc = (String.Format(
                    "SELECT *                 " +
                    "  FROM LANCAMENTOS"));

                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(consultaLanc, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar lancamentos :" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }

        }

        public DataTable consultarCaixaPorData(string data)
        {
            String consultaCaixa = (String.Format(
                    "SELECT *                 " +
                    "  FROM CAIXA          " +
                    " WHERE DATA = '{0}'", data));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaCaixa, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;

        }
        public DataTable recuperarUltimoCaixa()
        {
            String consultaCaixa = (String.Format(
                   "SELECT * FROM CAIXA " +
                   " WHERE id = (select max(id) from CAIXA)"));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaCaixa, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }

        public DataTable recuperarCaixaAtual()
        {
            String consultaCaixa = (String.Format(
                   "SELECT * FROM CAIXA " +
                   " WHERE SITUACAO = 'A'"));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaCaixa, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }

        public void reabrirCaixa(int id)
        {
            try
            {
                String reabrirCaixa = (String.Format(
                  "UPDATE CAIXA " +
                  "SET SITUACAO = 'A'" +
                  " WHERE ID = {0}", id));

                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(reabrirCaixa, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);
            }catch(Exception ex)
            {
                throw new Exception("Erro ao reabrir caixa: "+ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
            
        }
    }
}
