using Datos;
using Entidades;
using System.Data;

namespace Negocio{
    public class Negocio_Categoria{
        public DataTable ListadoCategoria(string cTexto){
            Datos_Categoria datos_Categoria = new Datos_Categoria();
            return datos_Categoria.ListadoCategoria(cTexto);
        }
        public static string Guardar_ca(int opcion, Entidad_Categoria categoria){
            Datos_Categoria datos = new Datos_Categoria();
            return datos.Guardar_ca(opcion, categoria);
        }
        public static string Eliminar_ca(int opcion){
            Datos_Categoria datos = new Datos_Categoria();
            return datos.Eliminar_ca(opcion);
        }
    }
}
