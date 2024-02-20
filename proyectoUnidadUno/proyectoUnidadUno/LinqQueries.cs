using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace proyectoUnidadUno{
    class LinqQueries{
        private List<Book> librosCollection = new List<Book>();
        public LinqQueries() {
            try{
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libros.json");
                if (File.Exists(filePath)){
                    string json = File.ReadAllText(filePath);
                    this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }else{
                    Console.WriteLine("Error: El archivo libros.json no se encontró en la ubicación especificada.");
                }
            }catch (Exception ex){
                Console.WriteLine($"Error al leer el archivo libros.json: {ex.Message}");
            }
        }
        public IEnumerable<Book> TodaLaColeccion(){
            return librosCollection;
        }
        public IEnumerable<Book> LibrosDespuesDel200(){
            //metodo de extension
            //return librosCollection.Where(p => p.PublishedDate.Year > 2000);
            //metodos de queries
            return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }
    }
}
