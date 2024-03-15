using System;
using System.Data.SqlClient;

namespace Datos{
    public class Conexion{
        private string basededatos;
        private string servidor;
        private string usuario;
        private string password;
        private static Conexion con = null;
        private Conexion(){
            this.basededatos = "ArticulosDB";
            this.servidor = "ROBERT\\UNAB";
            this.usuario = "sa";
            this.password = "unab";
        }
        public SqlConnection CrearConexion(){
            SqlConnection cadena = new SqlConnection();
            try{
                cadena.ConnectionString += "Server="+this.servidor;
                cadena.ConnectionString += "; Database=" + this.basededatos;
                cadena.ConnectionString += "; User Id=" + this.usuario;
                cadena.ConnectionString += "; Password=" + this.password;
                // cadena.ConnectionString = $"Server={servidor};Database={basededatos};User Id={usuario};Password={password}";
            }
            catch (Exception ex){
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static Conexion GetInstance()
        {
            if (con == null){
                 con = new Conexion();
            }
            return con;
        }
    }
}
