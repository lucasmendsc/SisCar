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
    public class LoginDAL
    {
        public bool verificarLogin(Usuario usuario)
        {
            String validaUsuario = (String.Format(
               "SELECT NOME " +
               "FROM USUARIOS " +
               "WHERE LOGIN = '{0}' " +
               "AND SENHA = '{1}' " +
               "AND SN_ATIVO = 'S'",
               usuario.Login,
               usuario.Senha));

            FbDataAdapter da = new FbDataAdapter
                (new FbCommand(validaUsuario, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);
            ConnectionFactory.Connect().Dispose();
            
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
