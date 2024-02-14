// Creación de una lista de personas
using consultasLinq;

List<Persona> personas = new List<Persona>
{
    new Persona { Nombre = "Juan", Edad = 30 },
    new Persona { Nombre = "María", Edad = 25 },
    new Persona { Nombre = "Pedro", Edad = 35 }
};

// Consulta LINQ con select para seleccionar solo los
// nombres de las personas
var nombres = from persona in personas
              select persona.Nombre;

// Iterar sobre los nombres y mostrarlos en la consola
foreach (var nombre in nombres){
    Console.WriteLine(nombre);
}
