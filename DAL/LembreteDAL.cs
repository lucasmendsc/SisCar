using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Models;

namespace DAL
{
    public class LembreteDAL
    {
        private static LembreteDAL mySelf;

        private LembreteDAL()
        {

        }

        public static LembreteDAL getInstance()
        {
            if (mySelf == null)
                mySelf = new LembreteDAL();
            return mySelf;
        }


        public void InserirLembrete(Lembrete l)
        {
            try
            {
                String insereL = (String.Format(
                    "INSERT INTO LEMBRETE (ID, " +
                    "DESCRICAO," +
                    "DATA," +
                    "STATUS)" +
                    "VALUES (NULL, " +
                    "'{0}'," +
                    "'{1}'," +
                    "'{2}')",
                    l.Descricao,
                    l.Data,
                    l.Status));

                FbCommand comandoInsert = new FbCommand
                    (insereL, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir LEMBRETE!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirLembrete(Lembrete l)
        {
            try
            {
                int Codigo = Convert.ToInt32(l.Id);

                String excluiL = (String.Format(
                    "DELETE FROM LEMBRETE " +
                    "WHERE ID = {0}",
                    Codigo));

                FbCommand comandoDelete = new FbCommand
                    (excluiL, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir LEMBRETE!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarLembretes(string des)
        {
            try
            {
                String consultaL = (String.Format(
                         "SELECT * " +
                         "FROM LEMBRETE " +
                         "WHERE DESCRICAO LIKE '%{0}%' " +
                         "ORDER BY DESCRICAO",
                         des));

                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(consultaL, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao buscar LEMBRETES!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }
        public DataTable RetornaLembretePorId(int id)
        {
            String retornaL = (String.Format(
                     "SELECT * FROM LEMBRETE WHERE ID = {0}", id));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(retornaL, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void atualiizarLembrete(Lembrete l)
        {
            try
            {
                int Codigo = Convert.ToInt32(l.Id);

                String updateL = (String.Format(
                    "UPDATE LEMBRETE " +
                    "SET DESCRICAO = '{1}', " +
                    "DATA = '{2}', " +
                    "STATUS = {3} " +
                    "WHERE ID = {0} ",
                    Codigo, l.Descricao, l.Data, l.Status));

                FbCommand comandoDelete = new FbCommand
                    (updateL, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar LEMBRETE!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }
    }
}
