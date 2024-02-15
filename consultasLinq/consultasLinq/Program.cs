// Creación de una lista de personas
using consultasLinq;

// Creación de una lista de personas con amigos
List<Persona> personas = new List<Persona>
 {
    new Persona { Nombre = "Juan", Edad = 30, Amigos = new List<string> { "María", "Pedro","ElizabethS" } },
    new Persona { Nombre = "María", Edad = 25, Amigos = new List<string> { "Juan", "Pedro", "Sofia" } },
    new Persona { Nombre = "Pedro", Edad = 35, Amigos = new List<string> { "Juan", "María", "Bryan" } }
 };
// Consulta LINQ con select para seleccionar solo los
// nombres de las personas
var nombres = from persona in personas
              select persona.Nombre;
Console.WriteLine("Mostrando los nombres obtenidos con el operador SELECT");
// Iterar sobre los nombres y mostrarlos en la consola
foreach (var nombre in nombres){
    Console.WriteLine(nombre);
}
Console.WriteLine("*******************************************");
// Consulta LINQ con SelectMany para obtener una lista plana de todos los amigos
var todosAmigos = personas.SelectMany(persona => persona.Amigos).Distinct().ToList();
Console.WriteLine("Utilizando el operador SelectMany");
// Iterar sobre los amigos y mostrarlos en la consola
foreach (var amigo in todosAmigos){
    Console.WriteLine(amigo);
}
Console.WriteLine("*******************************************");
Console.WriteLine("Mostrando amigos con nombres de mas de 5 caracteres");
// Consulta LINQ con SelectMany y Where para obtener una
// lista plana de amigos que tienen nombres con más de 5 letras
var amigosConNombresLargos = personas.SelectMany(persona => persona.Amigos)
                                     .Where(amigo => amigo.Length > 5);
// Iterar sobre los amigos filtrados y mostrarlos en la consola
foreach (var amigo in amigosConNombresLargos){
    Console.WriteLine(amigo);
}
Console.WriteLine("*******************************************");
Console.WriteLine("Mostrando amigos ordenados alfabeticamente");
// Consulta LINQ con SelectMany, Where y OrderBy
// para obtener una lista plana de amigos con nombres
// ordenados alfabéticamente
var amigosOrdenados = personas.SelectMany(persona => persona.Amigos)
                              .Where(amigo => amigo.Length > 4)
                              .OrderBy(amigo => amigo);
// Iterar sobre los amigos ordenados y mostrarlos en la consola
foreach (var amigo in amigosOrdenados){
    Console.WriteLine(amigo);
}
Console.WriteLine("*******************************************");
Console.WriteLine("Contando el total de amigos que tienen mas de 4 letras");
// Consulta LINQ con SelectMany, Where y Count para contar el número de amigos con nombres que contienen más de 4 letras
int cantidadAmigosConNombresLargos = 
    personas.SelectMany(persona => persona.Amigos)
   .Count(amigo => amigo.Length > 4);
// Mostrar el número total de amigos con nombres largos en la consola
Console.WriteLine("El número total de amigos con nombres largos es: " + cantidadAmigosConNombresLargos);
Console.WriteLine("*******************************************");
Console.WriteLine("Determina el nombre más largo entre los amigos");
// Consulta LINQ con SelectMany y Max para encontrar
// el nombre más largo entre los amigos
int amigoMasLargo =  personas.SelectMany(persona => persona.Amigos)
                     .Max(amigo => amigo.Length);
// Mostrar el nombre más largo en la consola
Console.WriteLine("El valor maximo del nombre más largo es: " + amigoMasLargo);
Console.WriteLine("*******************************************");
Console.WriteLine("Determina el nombre más corto entre los amigos");
// Consulta LINQ con SelectMany y Min para encontrar el nombre más corto entre los amigos
int amigoMasCorto = personas.SelectMany(persona => persona.Amigos)
                    .Min(amigo => amigo.Length);
// Mostrar el nombre más corto en la consola
Console.WriteLine("El nombre más corto entre los amigos es: " + amigoMasCorto);
Console.WriteLine("*******************************************");
Console.WriteLine("Se sumara la longitud de caracteres de todos los amigos");
// Consulta LINQ con SelectMany y Sum para calcular la suma
// de las longitudes de todos los nombres de los amigos
int sumaLongitudes = personas.SelectMany(persona => persona.Amigos)
                     .Sum(amigo => amigo.Length);
// Mostrar la suma de longitudes en la consola
Console.WriteLine("La suma de las longitudes de todos los nombres de los amigos es: " + sumaLongitudes);
Console.WriteLine("*******************************************");
Console.WriteLine("Mostrar todos los amigos que el nombre sea de 5 caracteres o menos");
// Consulta LINQ con SelectMany y TakeWhile para seleccionar
// los nombres de los amigos mientras la longitud del nombre
// sea menor o igual a 5 caracteres
var amigosCortos = personas.SelectMany(persona => persona.Amigos)
                   .TakeWhile(amigo => amigo.Length <= 5);
// Mostrar los nombres de los amigos cortos en la consola
Console.WriteLine("Los nombres de los amigos cortos son:");
foreach (var amigo in amigosCortos){
    Console.WriteLine(amigo);
}