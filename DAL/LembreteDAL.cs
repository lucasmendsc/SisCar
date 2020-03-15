using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Models;

namespace DAL
{
    public class LembreteDAL
    {
        public void InserirLembrete(Lembrete l)
        {
            try
            {
                String insereL = (String.Format(
                    "INSERT INTO LEMBRETE (ID, " +
                    "DESCRICAO," +
                    "DATA," +
                    "STATUS)" +
                    "VALUES ('NULL', " +
                    "'{0}')" +
                    "'{1}'" +
                    "'{2}'" +
                    "{3}",
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

                String excluiM = (String.Format(
                    "DELETE FROM LEMBRETE " +
                    "WHERE ID = '{0}'",
                    Codigo));

                FbCommand comandoDelete = new FbCommand
                    (excluiM, ConnectionFactory.Connect());
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
    }
}
