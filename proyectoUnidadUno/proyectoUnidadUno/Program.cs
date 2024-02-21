using proyectoUnidadUno;
using System.Text.RegularExpressions;

LinqQueries queries = new LinqQueries();
//toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());
//todos los libros despues del año 2000
//ImprimirValores(queries.LibrosDespuesDel200());
//todos los libros que tengan 250 pagina y en el titulo in Action
//ImprimirValores(queries.Libros250pagInAction());
Console.WriteLine(queries.TodosLosLibrosTienenStatus() ? "Todos los libros tienen status":"Hay libros sin status");
Console.WriteLine(queries.libroPublicado2005() ? "Si hay libros publicados en el 2005" : "No hay libros publicados en el 2005");
//ImprimirValores(queries.LibrosDePython()); 
//ImprimirValores(queries.LibrosDeJava());
//ImprimirValores(queries.LibrosDe450p());
//ImprimirValores(queries.LibrosRecientesJava());
//ImprimirValores(queries.LibrosDe400p());
ImprimirValores(queries.primeroTresLibros());
Console.WriteLine("La cantidad total de libros de 200 a 500 paginas son: {0}", queries.CantidadLibros200a500p());
Console.WriteLine("El libro con la fecha menor de publicacion es: {0}", queries.FechaMenorPublicacion());
Console.WriteLine("El libro con mas paginas {0}", queries.LibroConMasPag());
var libroMenorPag = queries.LibroConMenorPag();
Console.WriteLine($"{libroMenorPag.Title} - {libroMenorPag.PageCount}");
var libroReciente = queries.LibroMasReciente();
Console.WriteLine($"{libroReciente.Title} - {libroReciente.PublishedDate}");
Console.WriteLine("Total de paginas de libros de 0 a 500p {0}", queries.sunaTodosLosLibrosDe200a500p());
Console.WriteLine("Titulos concatenados de los libros {0}", queries.titulosConcatenados());
Console.WriteLine("El promedio de los caracteres de los titulos es: {0}", queries.promedioCaracteresTitulo());
var indiceLookup = queries.IndiceLibros();
ImprimirIndice(indiceLookup,'A');
//ImprimirGrupo(queries.librosPublicados2000());
ImprimirValores(queries.librosDespuesdel2000());
void ImprimirValores(IEnumerable<Book> ListaDeLibros){
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in ListaDeLibros){
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
void ImprimirGrupo(IEnumerable<IGrouping<int, Book>> ListadeLibros){
    foreach (var grupo in ListadeLibros){
        Console.WriteLine("");
        Console.WriteLine($"Grupo: {grupo.Key}");
        Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha");
        foreach (var item in grupo){
            Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate);
        }
    }
}

void ImprimirIndice(ILookup<char, Book> ListadeLibros, char letra){
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha");
    foreach (var item in ListadeLibros[letra]){
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.Date);
    }
}




