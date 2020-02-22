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
    public class PerfilDAL
    {
        public void SalvarImagem(Perfil perfil)
        {
            try
            {
                String salvaI = (String.Format(
               "UPDATE USUARIOS_CONFIG " +
               "SET VALOR = '{0}', " +
               "PLANO_DE_FUNDO = '{1}' " +
               "WHERE LOGIN = '{2}' ", perfil.Imagem, 'I', perfil.Login));

                FbCommand comandoUpdate = new FbCommand
                    (salvaI, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao salvar o caminho da Imagem!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close(); 
            }
        }

        public void SalvarCor(Perfil perfil)
        {
            try
            {
                String salvaC = (String.Format(
                   "UPDATE USUARIOS_CONFIG " +
                   "SET VALOR = '{0}', " +
                   "PLANO_DE_FUNDO = '{1}' " +
                   "WHERE LOGIN = '{2}' ", perfil.Cor, 'C', perfil.Login));

                FbCommand comandoUpdate = new FbCommand
                    (salvaC, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar a COR!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public String VerificarCoreFundo(Perfil perfil)
        {
            try
            {
                String verifica = (String.Format(
                  "SELECT PLANO_DE_FUNDO " +
                  "FROM USUARIOS_CONFIG " +
                  "WHERE LOGIN = '{0}'", perfil.Login));

                FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(verifica, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["plano_de_fundo"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao verificar campo na base de dados!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public String RetornarCoreFundo(Perfil perfil)
        {
            try
            {
                String retorna = (String.Format(
                  "SELECT VALOR " +
                  "FROM USUARIOS_CONFIG " +
                  "WHERE LOGIN = '{0}'", perfil.Login));

                FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(retorna, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["valor"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao retornar valor do campo!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }
    }
}
