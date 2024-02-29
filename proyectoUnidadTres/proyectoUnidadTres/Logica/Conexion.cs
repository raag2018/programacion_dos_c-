using System;
using System.Data.SqlClient;

namespace proyectoUnidadTres.Logica
{
    public class Conexion
    {
        private string BaseDeDatos;
        private static Conexion Con = null;

        private Conexion()
        {
            // Aquí debes especificar la cadena de conexión a tu servidor SQL Server
            this.BaseDeDatos = "Data Source=ROBERT\\UNAB;Initial Catalog=db_tarea;User ID=sa;Password=unab;TrustServerCertificate=True";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = this.BaseDeDatos;
            }
            catch (Exception ex)
            {
                conexion = null;
                throw ex;
            }
            return conexion;
        }

        public static Conexion getConexion()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}