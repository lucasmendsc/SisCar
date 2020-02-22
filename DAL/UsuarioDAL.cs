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
    public class UsuarioDAL
    {
        public void AtualizarUsuario(Usuario usuario)
        {
            try
            {
                //Atualiza dados na tabela USUARIOS
                String atualizaU = (String.Format(
                    "UPDATE USUARIOS SET LOGIN = '{0}', " +
                    "NOME = '{1}', " +
                    "SENHA = '{2}', " +
                    "SN_ATIVO = '{3}' " +
                    "WHERE LOGIN = '{0}'",
                    usuario.Login,
                    usuario.Nome,
                    usuario.Senha,
                    usuario.Ativo));

                FbCommand comandoUpdate = new FbCommand
                    (atualizaU, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Atualizar os Dados do Usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }        

        public void InserirUsuario(Usuario usuario)
        {
            try
            {
                //Inserir dados na tabela USUARIOS
                String insereU = (String.Format(
                    "INSERT INTO USUARIOS (LOGIN, " +
                    "NOME, " +
                    "SENHA, " +
                    "SN_ATIVO) " +
                    "VALUES ('{0}', " +
                    "'{1}', " +
                    "'{2}', " +
                    "'{3}') ",
                    usuario.Login,
                    usuario.Nome,
                    usuario.Senha,
                    usuario.Ativo));

                FbCommand comandoInsert = new FbCommand
                    (insereU, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirUsuarioConfig(Usuario usuario)
        {
            try
            {    
                //Inserir dados na tabela USUARIOS_CONFIG
                String insereC = (String.Format(
                    "INSERT INTO USUARIOS_CONFIG (LOGIN, " +
                    "PLANO_DE_FUNDO, " +
                    "DS_CONFIG, " +
                    "VALOR) " +
                    "VALUES ('{0}', " +
                    "'{1}', " +
                    "'{2}', " +
                    "'{3}') ", usuario.Login, null, "Papel de Parede e Cor",null));

                FbCommand comandoInsert = new FbCommand
                    (insereC, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Configurações do Usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirUsuario(Usuario usuario)
        {
            try
            {
                //Excluir dados da tabela USUARIOS
                String excluiU = (String.Format(
                    "DELETE FROM USUARIOS " +
                    "WHERE LOGIN = '{0}'",
                    usuario.Login));

                FbCommand comandoDelete = new FbCommand
                    (excluiU, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirUsuarioConfig(Usuario usuario)
        {
            try
            {
                //Excluir dados da tabela USUARIOS_CONFIG
                String excluiUC = (String.Format(
                    "DELETE FROM USUARIOS_CONFIG " +
                    "WHERE LOGIN = '{0}'",
                    usuario.Login));

                FbCommand comandoDelete = new FbCommand
                    (excluiUC, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Configurações do Usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public bool VerificarUsuario(Usuario usuario)
        {
            try
            {
                String verificaU = (String.Format(
                    "SELECT LOGIN " +
                    "FROM USUARIOS " +
                    "WHERE LOGIN = '{0}'",
                    usuario.Login));

                FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(verificaU, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Verificar existencia do usuário!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarUsuario(String NomeUsuário)
        {
            String consultaU = (String.Format(
                     "SELECT * " +
                     "FROM USUARIOS " +
                     "WHERE NOME LIKE '%{0}%' ",
                     NomeUsuário));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaU, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }
    }
}
