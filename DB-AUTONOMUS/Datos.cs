using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DB_AUTONOMUS
{
    internal class Datos
    {

        OracleConnection con;
        private string cadenaConexion = "User Id=ADMIN; " +
            "password=Arquitectura1.;Data Source=ITLDB_high";

        private OracleConnection abrirConexion()
        {
            OracleConfiguration.TnsAdmin = @"C:\Users\Jose Luis\Downloads\Wallet_ITLDB";
            OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
            try
            {
                con = new OracleConnection(cadenaConexion);
                con.Open();
                return con;

            }
            catch (Exception ex) { return null; }

        }

        public bool Comando(String cmd)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand(cmd, abrirConexion());
                oracleCommand.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex) { return false; }
        }
    }
   
}
