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
    public static class ConnectionFactory
    {
        private const string ConnectionString = "Server=localhost; Port=3050;User id=sysdba;password=masterkey;Database=C:\\Program Files (x86)\\Connecta Tecnologia\\Connecta Automotivo\\BASE.FDB;Pooling=false;";

        public static FbConnection Connect()
        {
            FbConnection conn = new FbConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
