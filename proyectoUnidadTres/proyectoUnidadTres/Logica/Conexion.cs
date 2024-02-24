using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace proyectoUnidadTres.Logica{
    public class Conexion {
        private string BaseDeDatos;
        private static Conexion Con = null;
        private Conexion(){
            this.BaseDeDatos = "./db_tarea.db";
        }
        public SQLiteConnection CrearConexion(){
            SQLiteConnection Cadena = new SQLiteConnection();
            try{
                Cadena.ConnectionString = "Data Source = "+this.BaseDeDatos;
            }catch(Exception ex){
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getConexion(){
            if(Con == null){
                Con = new Conexion();
            }
            return Con;
        }
    }
}
