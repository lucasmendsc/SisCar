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
    public class ClienteDAL
    {
        public void AtualizarCliente(Cliente cliente) 
        {
            try
            {
                String atualizaC = (String.Format(
                    "UPDATE CLIENTES SET NOME = '{0}', " +
                    "CPF       = '{1}', " +
                    "DATA_NASC = '{2}', " +
                    "ENDERECO  = '{3}', " +
                    "BAIRRO    = '{4}', " +
                    "CEP       = '{5}', " +
                    "CIDADE    = '{6}', " +
                    "ESTADO    = '{7}', " +
                    "FONE1     = '{8}', " +
                    "FONE2     = '{9}', " +
                    "SEXO      = '{10}', " +
                    "RESTRICAO = '{11}', " +
                    "RG        = '{13}' "+
                    "WHERE COD_CLIENTE = '{12}'",
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Data_Nasc,
                    cliente.Endereco,
                    cliente.Bairro,
                    cliente.CEP,
                    cliente.Cidade,
                    cliente.Estado,
                    cliente.Fone1,
                    cliente.Fone2,
                    cliente.Sexo,
                    cliente.Restricao,
                    cliente.Rg,
                    cliente.Cod_Cliente));

                FbCommand comandoUpdate = new FbCommand
                    (atualizaC, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Atualizar os Dados do Cliente!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCliente(Cliente cliente)
        {
            try
            {
                String insereC = (String.Format(
                    "INSERT INTO CLIENTES (COD_CLIENTE, " +
                    "NOME, " +
                    "CPF, " +
                    "DATA_NASC, " +
                    "ENDERECO, " +
                    "BAIRRO, " +
                    "CEP, " +
                    "CIDADE, " +
                    "ESTADO, " +
                    "FONE1, " +
                    "FONE2, " +
                    "SEXO, " +
                    "RESTRICAO, " +
                    "RG) " +
                    "VALUES ({0}," +
                    "'{1}'," + 
                    "'{2}'," + 
                    "'{3}'," + 
                    "'{4}'," + 
                    "'{5}'," + 
                    "'{6}'," + 
                    "'{7}'," + 
                    "'{8}'," + 
                    "'{9}'," +
                    "'{10}'," +
                    "'{11}'," + 
                    "'{12}', " +
                    "'{13}'); ",
                    cliente.Cod_Cliente,
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Data_Nasc,
                    cliente.Endereco,
                    cliente.Bairro,
                    cliente.CEP,
                    cliente.Cidade,
                    cliente.Estado,
                    cliente.Fone1,
                    cliente.Fone2,
                    cliente.Sexo,
                    cliente.Restricao,
                    cliente.Rg));

                FbCommand comandoInsert = new FbCommand
                    (insereC, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Cliente!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
            try
            {
                int Codigo = Convert.ToInt32(cliente.Cod_Cliente);

                String excluiC = (String.Format(
                    "DELETE FROM CLIENTES " +
                    "WHERE COD_CLIENTE = '{0}'",
                    Codigo));

                FbCommand comandoDelete = new FbCommand
                    (excluiC, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Cliente!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCodigo(Cliente cliente)
        {
            try
            {
                String insereCo = (String.Format(
                    "SELECT MAX(COD_CLIENTE) " +
                    "FROM CLIENTES "));

                FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(insereCo, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                cliente.Cod_Cliente = dt.Rows[0]["max"].ToString();

                if (cliente.Cod_Cliente == "")
                    cliente.Cod_Cliente = "0";

                int Codigo = Convert.ToInt32(cliente.Cod_Cliente);
                Codigo = Codigo + 1;
                cliente.Cod_Cliente = Codigo.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao incluir campo na base de dados!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable consultarClienteCpf(string cpf)
        {
            String consultaC = (String.Format(
                    "SELECT *                 " +
                    "  FROM CLIENTES          " +
                    " WHERE CPF LIKE '%{0}%' ",
                    cpf));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaC, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            ConnectionFactory.Connect().Close();
            return dt;
        }

        public DataTable ConsultarCliente(String NomeCliente) 
        {
            try
            {
                String consultaC = (String.Format(
                    "SELECT *                 " +
                    "  FROM CLIENTES          " +
                    " WHERE NOME LIKE '%{0}%' ",
                    NomeCliente));

                FbDataAdapter da = new FbDataAdapter
                       (new FbCommand(consultaC, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao consultar cliente: "+ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void PesquisarCliente(Cliente cliente)
        {
            String pesquisaC = (String.Format(
                     "SELECT COD_CLIENTE " +
                     "  FROM CLIENTES " +
                     " WHERE NOME = '{0}' ",
                     cliente.Nome));

            FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(pesquisaC, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            cliente.Cod_Cliente = dt.Rows[0]["COD_CLIENTE"].ToString();

            ConnectionFactory.Connect().Close();
        }


        public Cliente GetCliente(int codigo)
        {
            Cliente cliente = new Cliente();
            String pesquisaC = (String.Format(
                    "SELECT * " +
                    "  FROM CLIENTES " +
                    " WHERE COD_CLIENTE = {0} ",
                    codigo));

            FbDataAdapter da = new FbDataAdapter(new FbCommand(pesquisaC, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                cliente.Cod_Cliente = dt.Rows[0]["COD_CLIENTE"].ToString();
                cliente.Nome = dt.Rows[0]["NOME"].ToString();
                cliente.CPF = dt.Rows[0]["CPF"].ToString();
                cliente.Data_Nasc = dt.Rows[0]["DATA_NASC"].ToString();
                cliente.Endereco = dt.Rows[0]["ENDERECO"].ToString();
                cliente.Bairro = dt.Rows[0]["BAIRRO"].ToString();
                cliente.CEP = dt.Rows[0]["CEP"].ToString();
                cliente.Cidade = dt.Rows[0]["CIDADE"].ToString();
                cliente.Estado = dt.Rows[0]["ESTADO"].ToString();
                cliente.Fone1 = dt.Rows[0]["FONE1"].ToString();
                cliente.Fone2 = dt.Rows[0]["FONE2"].ToString();
                cliente.Sexo = dt.Rows[0]["SEXO"].ToString();
                cliente.Restricao = dt.Rows[0]["RESTRICAO"].ToString();
                cliente.Rg = dt.Rows[0]["RG"].ToString();

                return cliente;
            }
            else
            {
                return null;
            }
            


            ConnectionFactory.Connect().Close();

           
        }
    }
}
