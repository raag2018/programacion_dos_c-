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
        public IEnumerable<Book> Libros250pagInAction(){
            //metodo de extension
            //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));
            //metodos de queries
            return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }
        public IEnumerable<Book> LibrosDePython(){
            //metodo de extension
            //return librosCollection.Where(p =>  p.Categories.Contains("Python"));
            //metodos de queries
            return from l in librosCollection where  l.Categories.Contains("Python") select l;
        }
        public IEnumerable<Book> LibrosDeJava(){
            //metodo de extension
            return librosCollection.Where(p =>  p.Categories.Contains("Java")).OrderBy(p => p.Title);    
        }
        public IEnumerable<Book> LibrosRecientesJava(){
            //metodo de extension
            return librosCollection.Where(p => p.Categories.Contains("Java"))
                .OrderByDescending(p => p.PublishedDate.Year).Take(3);
        }
        public IEnumerable<Book> LibrosDe450p(){
            //metodo de extension
            return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
        }
        public IEnumerable<Book> LibrosDe400p(){
            //metodo de extension
            return librosCollection.Where(p => p.PageCount > 400)
                .Take(4).Skip(2);
        }
        public bool TodosLosLibrosTienenStatus(){
            //metodo de extension
            return librosCollection.All(p => p.Status != string.Empty);
        }
        public bool libroPublicado2005(){
            //metodo de extension
            return librosCollection.Any(p => p.PublishedDate.Year ==  2005);
        }
        public IEnumerable<Book> primeroTresLibros(){
           return librosCollection.Take(3)
                .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
        }
        public int CantidadLibros200a500p(){
            return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
        }
        public DateTime FechaMenorPublicacion() {
            return librosCollection.Min(p => p.PublishedDate);
        }
        public int LibroConMasPag(){
            return librosCollection.Max(p => p.PageCount);
        }
        public Book LibroConMenorPag(){
            return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
        }
        public Book LibroMasReciente(){
            return librosCollection.MaxBy(p => p.PublishedDate);
        }
        public int sunaTodosLosLibrosDe200a500p(){
            return librosCollection.Where(p => p.PageCount > 0 && p.PageCount <= 500)
                .Sum(p => p.PageCount);
        }
        public string titulosConcatenados(){
            return librosCollection.Where(p => p.PublishedDate.Year > 2015)
                    .Aggregate("", (TitulosLibros, next) =>
                    {
                        if (TitulosLibros != string.Empty)
                            TitulosLibros += " - " + next.Title;
                        else
                            TitulosLibros += next.Title;
                        return TitulosLibros;
                    });
        }
        public double promedioCaracteresTitulo(){
            return librosCollection.Average(p => p.Title.Length);
        }
        public IEnumerable<IGrouping<int, Book>> librosPublicados2000(){
            return librosCollection.Where(p => p.PublishedDate.Year > 2000)
                .GroupBy(p => p.PublishedDate.Year);
        }
        public ILookup<char, Book> IndiceLibros(){
            return librosCollection.ToLookup(p => p.Title[0], p => p);
        }
        public IEnumerable<Book> librosDespuesdel2000(){
            var libros2005 = librosCollection.Where(p => p.PublishedDate.Year > 2005);
            var librosCon400p = librosCollection.Where(p => p.PageCount > 500);
            return libros2005.Join(librosCon400p, p => p.Title, x => x.Title, (p, x) => p);
        } 
    } 
}
