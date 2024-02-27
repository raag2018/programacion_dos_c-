using proyectoUnidadTres.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace proyectoUnidadTres.Logica{
    public class DbContextArticulo{
        public DataTable ListadoArticulos(string param){
            SQLiteDataReader resultado;
            DataTable table = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try{
                SqlCon = Conexion.getConexion().CrearConexion();
                param = "%"+param.Trim()+"%";
                string sentencia = "select a.codigo_ar, a.descripcion_ar, a.marca_ar, c.descripcion_ca," +
                    "b.descripcion_me, c.codigo_ca, b.codigo_me from tb_articulos a " +
                    "inner join tb_categoria c on c.codigo_ca = a.codigo_ca " +
                    "inner join tb_medida b on b.codigo_me = a.codigo_me " +
                    "where a.descripcion_ar like '"+param+"';";
                SQLiteCommand comando = new SQLiteCommand(sentencia, SqlCon);
                SqlCon.Open();
                resultado = comando.ExecuteReader();
                table.Load(resultado);
                return table;
            }catch (Exception ex){
                throw ex;
            }finally{
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string registrosArtituclo(int param, Articulo articulo){
            SQLiteConnection SqlCon = new SQLiteConnection();
            string resultado = "";
            string sentencia = "";
            try{
                if (param == 1){
                    sentencia = "insert into " +
                        "tb_articulos(descripcion_ar, marca_ar, codigo_me, codigo_ca)" +
                        " values('"+articulo.descripcion_ar+"', '"+articulo.marca_ar+"', " +
                        "'"+articulo.codigo_me+"', '"+articulo.codigo_ca+"');";
                }else if(param == 2){
                    sentencia = "update tb_articulo set where ";
                }
                
                SqlCon = Conexion.getConexion().CrearConexion();
                SQLiteCommand comando = new SQLiteCommand(sentencia, SqlCon);
                SqlCon.Open();
                resultado = comando.ExecuteNonQuery() >= 1 ? "ok" : "Error al registrar";
                return resultado;
            }catch (Exception ex){
               return resultado =  ex.Message;
            }finally{
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}