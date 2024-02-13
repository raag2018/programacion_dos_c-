//importante indicar que utilizaremos el espacion de nombres Collections
using System.Collections;
//creando un objeto de tipo ArrayList
ArrayList  datos = new ArrayList();
//agregando un dato de tipo entero
Console.WriteLine("\n******** Agregando datos *********");
datos.Add(21);
/*si el dato que deseamos guardar por ejemplo proviene de otro proceso
  se puede almacenar en una variable independiente y adicionarlo
 */
Console.WriteLine("\n******** Agregando datos *********");
string nombre = "Juan Perez";
datos.Add(nombre);
//recorrer el objeto de tipo ArrayList
/*Nota importante el arrayList puede almacenar informacion de varios
 tipos de datos, por lo cual la estructura de control foreach va requerir
que especifiquemos el tipo de dato que utilizaremos en este caso, se tienen
dos datos distintos en nuestro objeto por lo cual no podemos indicar un
solo tipo de dato, para estos casos en especifico utilizaremos una forma
de declaracion especial que es var, la cual define el tipo de dato como 
objeto asi nos evitamos errores en la ejecucion de nuestro proyecto
 */
Console.WriteLine("\n******** Mostrando Datos *********");
foreach (var dato in datos){
    Console.WriteLine(dato);
}
Console.WriteLine("\n******** Accediendo a un elemento *********");
//accediendo al primer elemento del objeto de tipo ArrayList
Console.WriteLine(datos[0]);
Console.WriteLine("\n******** Modificando un elemento *********");
//modificando el primer elemento
datos[0] = 50;
//mostrando el elemento modificado
Console.WriteLine(datos[0]);
Console.WriteLine("\n******** Contando la cantidad total de elementos *********");
//contando la cantidad de elementos que tiene almacenado
Console.WriteLine(datos.Count);
Console.WriteLine("\n******** Insertando un elemento *********");
//insertando un elemento a la objeto datos
datos.Insert(2, 100);
Console.WriteLine("\n******** Eliminando un elemento *********");
Console.WriteLine("\n******** Mostrando los datos *********");
for (int i = 0; i < datos.Count; i++){
    Console.WriteLine(i + ": " + datos[i]);
}
//eliminando un elemento del objeto
datos.RemoveAt(0);
Console.WriteLine("\n################## INCIANDO UN QUEUE ####################");
//se crea un objeto de la clase Queue
Queue fila = new Queue();
Console.WriteLine("\n################## ADICIONANDO UN ELEMENTO A UN QUEUE ####################");
//adicionando un valor a la fila
fila.Enqueue(100);
fila.Enqueue(200);
fila.Enqueue(300);
Console.WriteLine("\n################## EXTRAER UN ELEMENTO A UN QUEUE ####################");
//extraer el primer elemento adiconado a la cola
var salida_queue =  fila.Dequeue();
Console.WriteLine(salida_queue);
//observando el elemento principal de la cola
var salida_peek = fila.Peek();
Console.WriteLine(salida_peek);
//para verificar si existe un elemento dentro de la cola
bool existe_dato = fila.Contains(200);
Console.WriteLine(existe_dato);