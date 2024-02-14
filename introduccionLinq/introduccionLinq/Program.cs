/*#################### OPERADORES DE COMPARACION ######################*/
int a = 20;
int b = 20;
int c = 41;
//en el momento de realizar comparaciones siempre se devuelve un valor
//booleano, ya sea true para verdader = 1 o false para falso = 0
/**************************/
//comparacion de mayor que
if (c > b){
    Console.WriteLine("C es mayor que B");
}
//en esta condicion se verifica que c sea mayor que b, esto da como 
// resultado true
/*****************************/
//comparacion de menor que <
if (a < c) {
    Console.WriteLine("A es menor que c");
}
//en esta condicion se verifica si a es menor que b, lo cual da true
/********************************/
//comparacion de igualdad
if (a == b){
    Console.WriteLine("A es igual a b");
}
//en esta condicion se verifica si la variable a es igual a la 
// variable b, lo cual da como resultado true
/***************************************/
//comparacion de negacion
if (b != c){
    Console.WriteLine("B no es igual a c");
}
//en esta condicion se verifica si b no es igual a c
/*************************************/
//comparacion de menor o igual que
if (a <= c){
    Console.WriteLine("A es menor que c, pero no es igual");
}
//en esta condicion verificamos si a es menor o igual que c, esto
//da como resultado true, ya que a es menor que c, pero no igual
/**********************************************/
//comparacion de mayor o igual que
if (c >= b){
    Console.WriteLine("C es mayor que b, pero no es igual");
}
//en esta condicion se verifica si c es mayor o igual que b, 
//el resultado es true

/******************************************/
//creando una coleccion de datos enteros
int[] numeros = { 1, 2, 3,  5, 1000, 0};
// Obtener el primer número mayor que 3
int numeroMayorQue3 = numeros.FirstOrDefault(x => x > 3);
Console.WriteLine("El primer número mayor que 3 es: " + numeroMayorQue3);

//creamos una coleccion llamada frutas
var frutas = new string[]{
    "Sandia", "Fresa", "Mango",
    "Mango de Azucar", "Mango Tony"
};
//realiazaremos un filtro con la condicon where de linq
var MangoList = 
   frutas.Where(
       fruta => 
       fruta.StartsWith("Mango")).ToList();
//en este punto hay una serie de procesos que se deben exponer
/*
 1. se esta filtrando la coleccion segun aquellos elementos que coincidan con la palabra mango
 2. se utiliza la funcion Where de linq para expresar la condicion de que coincidan con "Mango"
 3. Dentro de Where se expresa una funcion anonima, para
 indicar que se buscara a los elementos que inicien con la palabra Mango
 4. Luego de encontrar estos elementos se creara una lista con los elementos encontrados
 */
MangoList.ForEach(mango => Console.WriteLine(mango));
//en este momento estamos recorriendo nuestra lista creada segun el filtro
//aplicado y se crea un objeto llamado mango con una funcion anonima y si 
// posee informacion se mostrara en la consola
/*####################### EJEMPLO DE EXPRESION LAMBDA ####################*/
// Ejemplo 1: Expresión lambda que suma dos números
Func<int, int, int> sumar = (x, y) => x + y;
// El tipo de delegado se infiere automáticamente
// var sumar = (int x, int y) => x + y; 
int resultadoSuma = sumar(3, 5);
Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

// Ejemplo 2: Expresión lambda que verifica si un número es par
Predicate<int> esPar = n => n % 2 == 0;
// El tipo de delegado se infiere automáticamente
// var esPar = (int n) => n % 2 == 0; 
int numero = 6;
if (esPar(numero)){
    Console.WriteLine(numero + " es par.");
}else{
    Console.WriteLine(numero + " no es par.");
}
delegate int Suma(int x, int y);