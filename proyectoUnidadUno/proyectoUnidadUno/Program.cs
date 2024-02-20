using proyectoUnidadUno;

LinqQueries queries = new LinqQueries();
//toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());
//todos los libros despues del año 2000
ImprimirValores(queries.LibrosDespuesDel200());
void ImprimirValores(IEnumerable<Book> ListaDeLibros){
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in ListaDeLibros){
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
