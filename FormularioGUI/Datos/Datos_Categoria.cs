using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos{
    public class Datos_Categoria{
        public DataTable ListadoCategoria(string cTexto){
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try{
                con = Conexion.GetInstance().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("USP_listado_ca", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                con.Open();
                resultado = sqlCommand.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }catch (Exception ex){
                throw ex;
            }finally{
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public string Guardar_ca(int opcion, Entidad_Categoria categoria){
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try{
                con = Conexion.GetInstance().CrearConexion();
                SqlCommand cmd = new SqlCommand("USP_Guaedar_ca", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("@id_ca", SqlDbType.Int).Value = categoria.id_ca;
                cmd.Parameters.Add("@descripcion_ca", SqlDbType.VarChar).Value = categoria.descripcion_ca;
                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al guardar";
            }catch (Exception ex) {
                respuesta = ex.Message;
            }finally{
                if(con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }
        public string Eliminar_ca(int opcion){
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try{
                con = Conexion.GetInstance().CrearConexion();
                SqlCommand cmd = new SqlCommand("USP_eliminar_ca", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = opcion;
                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar";
            }catch (Exception ex){
                respuesta = ex.Message;
            }finally{
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }
    }
}
