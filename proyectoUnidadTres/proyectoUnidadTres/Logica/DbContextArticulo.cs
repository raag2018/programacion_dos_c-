using proyectoUnidadTres.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace proyectoUnidadTres.Logica
{
    public class DbContextArticulo{
        public DataTable ListadoArticulos(string param){
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try{
                sqlCon = Conexion.getConexion().CrearConexion();
                param = "%" + param.Trim() + "%";
                string sentencia = "select a.codigo_ar, a.descripcion_ar, a.marca_ar, c.descripcion_ca," +
                    "b.descripcion_me, c.codigo_ca, b.codigo_me from tb_articulos a " +
                    "inner join tb_categoria c on c.codigo_ca = a.codigo_ca " +
                    "inner join tb_medida b on b.codigo_me = a.codigo_me " +
                    "where a.descripcion_ar like @param;";

                SqlCommand comando = new SqlCommand(sentencia, sqlCon);
                comando.Parameters.AddWithValue("@param", param);

                sqlCon.Open();
                SqlDataReader resultado = comando.ExecuteReader();
                table.Load(resultado);
                return table;
            }catch (Exception ex){
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }finally{
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string RegistrosArticulo(int param, Articulo articulo){
            SqlConnection sqlCon = new SqlConnection();
            string resultado = "";
            string sentencia = "";
            try{
                sqlCon = Conexion.getConexion().CrearConexion();
                if (param == 1){
                    sentencia = "INSERT INTO tb_articulos (descripcion_ar, marca_ar, codigo_me, codigo_ca) " +
                                "VALUES (@descripcion_ar, @marca_ar, @codigo_me, @codigo_ca);";
                }else if (param == 2){
                    sentencia = "UPDATE tb_articulos SET descripcion_ar = @descripcion_ar, " +
                                "marca_ar = @marca_ar, codigo_me = @codigo_me, codigo_ca = @codigo_ca " +
                                "WHERE codigo_ar = @codigo_ar;";
                }
                SqlCommand comando = new SqlCommand(sentencia, sqlCon);
                comando.Parameters.AddWithValue("@descripcion_ar", articulo.descripcion_ar);
                comando.Parameters.AddWithValue("@marca_ar", articulo.marca_ar);
                comando.Parameters.AddWithValue("@codigo_me", articulo.codigo_me);
                comando.Parameters.AddWithValue("@codigo_ca", articulo.codigo_ca);
                comando.Parameters.AddWithValue("@codigo_ar", articulo.codigo_ar);

                sqlCon.Open();
                resultado = comando.ExecuteNonQuery() >= 1 ? "ok" : "Error al registrar";
                return resultado;
            }catch (Exception ex){
                return resultado = ex.Message;
            }finally{
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public string EliminarArticulo(int param)
        {
            SqlConnection sqlCon = new SqlConnection();
            string resultado = "";
            string sentencia = "";
            try
            {
                sqlCon = Conexion.getConexion().CrearConexion();
                sentencia = "DELETE FROM tb_articulos " +
                               "WHERE codigo_ar = @codigo_ar;";
                SqlCommand comando = new SqlCommand(sentencia, sqlCon);
                comando.Parameters.AddWithValue("@codigo_ar", param);
                sqlCon.Open();
                resultado = comando.ExecuteNonQuery() >= 1 ? "ok" : "Error al eliminar";
                return resultado;
            }
            catch (Exception ex)
            {
                return resultado = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable ListadoMedida(){
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try{
                sqlCon = Conexion.getConexion().CrearConexion();
                string sentencia = "select  descripcion_me, codigo_me" +
                    " from tb_medida; ";
                SqlCommand comando = new SqlCommand(sentencia, sqlCon);
                sqlCon.Open();
                SqlDataReader resultado = comando.ExecuteReader();
                table.Load(resultado);
                return table;
            }catch (Exception ex){
                throw new Exception("Error al consultar tabla: " + ex.Message);
            }finally{
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable ListadoCategoria()
        {
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getConexion().CrearConexion();
                string sentencia = "select  descripcion_ca, codigo_ca" +
                    " from tb_categoria; ";
                SqlCommand comando = new SqlCommand(sentencia, sqlCon);
                sqlCon.Open();
                SqlDataReader resultado = comando.ExecuteReader();
                table.Load(resultado);
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar tabla: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
