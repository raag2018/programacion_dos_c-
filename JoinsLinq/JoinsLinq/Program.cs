using JoinsLinq;
// Definir una lista de ventas
List<Venta> ventas = new List<Venta>{
    new Venta { Id = 1, Monto = 100, Fecha = new DateTime(2023, 1, 10) },
    new Venta { Id = 2, Monto = 150, Fecha = new DateTime(2023, 3, 15) },
    new Venta { Id = 3, Monto = 200, Fecha = new DateTime(2024, 2, 20) },
    new Venta { Id = 4, Monto = 120, Fecha = new DateTime(2024, 5, 5) },
    new Venta { Id = 5, Monto = 180, Fecha = new DateTime(2021, 7, 12) }
};
Console.WriteLine("********************************");
Console.WriteLine("UTILIZANDO GROUPBY");
// Consulta con GroupBy
var consulta = from venta in ventas
               group venta by venta.Fecha.Year into ventasPorAnio
               select new{
                   Anio = ventasPorAnio.Key,
                   TotalVentas = ventasPorAnio.Sum(v => v.Monto)
               };
// Mostrar resultados
foreach (var item in consulta){
    Console.WriteLine($"Año: {item.Anio}, Total de ventas: " +
                      $"{item.TotalVentas}");
}
Console.WriteLine("********************************");
Console.WriteLine("UTILIZANDO JOIN");
// Definir listas de estudiantes y cursos
List<Estudiante> estudiantes = new List<Estudiante>{
    new Estudiante { Id = 1, Nombre = "Juan" },
    new Estudiante { Id = 2, Nombre = "María" },
    new Estudiante { Id = 3, Nombre = "Pedro" }
};
List<Curso> cursos = new List<Curso>{
    new Curso { Id = 101, Nombre = "Matemáticas", EstudianteId = 1 },
    new Curso { Id = 102, Nombre = "Historia", EstudianteId = 1 },
    new Curso { Id = 103, Nombre = "Literatura", EstudianteId = 2 }
};
// Consulta con join
var consultaJoin = from estudiante in estudiantes
               join curso in cursos on estudiante.Id equals curso.EstudianteId
               select new
               {
                   EstudianteNombre = estudiante.Nombre,
                   CursoNombre = curso.Nombre
               };
// Mostrar resultados
foreach (var item in consultaJoin){
    Console.WriteLine($"Estudiante: {item.EstudianteNombre}, Curso: {item.CursoNombre}");
}