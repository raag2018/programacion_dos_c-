//se define el arreglo con una longitud de tres elementos
using arrays;

string[] nombres = new string[3];
//se asigna los valores que tendra cada elemento
nombres = [ "Juan", "Regina", "Ana" ];
//para acceder a cada elemento se imprime en consola un ejemplo
Console.WriteLine(nombres[0]);
//esto imprime el primer elemento en este caso el nombre Juan
/*se crea un arreglo llamado persona
se inicializa con dos elementos 
 */
Persona[] personas = {new Persona("Juan"), new Persona("Maria")};
//se muestra en consola la primera persona
Console.WriteLine(personas[0].persona);
Console.WriteLine(personas.Length);
//en  este estructura podemos acceder por medio del indice del array
for(int i = 0; i < personas.Length; i++){
    Console.WriteLine(personas[i].persona);
}
//en esta estructura se lee el arreglo 
foreach(Persona persona in personas){
    Console.WriteLine(persona.persona);
}