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
    public class MarcaDAL
    {
        public void InserirMarca(Marca marca)
        {
            try
            {
                String insereM = (String.Format(
                    "INSERT INTO MARCAS (COD_MARCA, " +
                    "DS_MARCA)" +                    
                    "VALUES ('{0}', " +
                    "'{1}')",                    
                    marca.Cod_Marca,
                    marca.Ds_Marca));                    

                FbCommand comandoInsert = new FbCommand
                    (insereM, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Marca!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirMarca(Marca marca)
        {
            try
            {
                int Codigo = Convert.ToInt32(marca.Cod_Marca);

                String excluiM = (String.Format(
                    "DELETE FROM MARCAS " +
                    "WHERE COD_MARCA = '{0}'",
                    Codigo));

                FbCommand comandoDelete = new FbCommand
                    (excluiM, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir MARCA!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCodigo(Marca marca)
        {
            try
            {
                String insereCo = (String.Format(
                    "SELECT MAX(COD_MARCA) " +
                    "FROM MARCAS "));

                FbDataAdapter da = new FbDataAdapter
                    (new FbCommand(insereCo, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                marca.Cod_Marca = dt.Rows[0]["max"].ToString();

                if (marca.Cod_Marca == "")
                    marca.Cod_Marca = "0";

                int Codigo = Convert.ToInt32(marca.Cod_Marca);
                Codigo = Codigo + 1;
                marca.Cod_Marca = Codigo.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao inserir Código!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarMarca(String NomeMarca)
        {
            String consultaM = (String.Format(
                     "SELECT * " +
                     "FROM MARCAS " +
                     " WHERE DS_MARCA LIKE '%{0}%' " +
                     "ORDER BY DS_MARCA",
                     NomeMarca));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(consultaM, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RetornaMarca()
        {
            String retornaM = (String.Format(
                     "SELECT COD_MARCA, " +
                     "DS_MARCA " +
                     "FROM MARCAS " +
                     "ORDER BY DS_MARCA "));                     

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(retornaM, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RetornaMarcaPorId(int id)
        {
            String retornaM = (String.Format(
                     "SELECT * FROM MARCAS WHERE COD_MARCA = {0}", id));

            FbDataAdapter da = new FbDataAdapter
                   (new FbCommand(retornaM, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
