//variables necesarias
using System.Collections;
using System.Collections.Generic;

int opcion = 0;
string valor = "";
int numero = 0;
bool encontrado = false;
// creamos Queue
Queue queue = new Queue();
do{
    //mostramos meno
    Console.WriteLine("1- Enqueue");
    Console.WriteLine("2- Dequeue");
    Console.WriteLine("3- Clear");
    Console.WriteLine("4- Contains");
    Console.WriteLine("5- Salir");
    Console.WriteLine("Input to option");
    valor = Console.ReadLine();
    opcion =  Convert.ToInt32(valor);
    if (opcion == 1){
        //pedimos el valor a introducir
        Console.WriteLine("Ingrese un dato");
        valor = Console.ReadLine();
        numero = Convert.ToInt32(valor);
        //adicionamos el valor al queue
        queue.Enqueue(valor);
    }
    if(opcion == 2){
        //obtenemos el numero
        numero = Convert.ToInt32(queue.Dequeue());
        //mostramos el elemento
        Console.WriteLine("El valor obtenido es: {0}", numero);
    }
    if(opcion == 3){
        //limpiamos todos los contenidos
        queue.Clear();
    }
    if(opcion == 4){
        //pedimos el valor a encontrar
        Console.WriteLine("ingrese el valor a encontrar");
        valor = Console.ReadLine();
        //vemos si el elemento esta 
        encontrado = queue.Contains(valor);
        //mostramos el resultado
        Console.WriteLine("encontrado - {0}", encontrado);
    }
    //mostramos la informacion de la cola
    Console.WriteLine("el queue tiene {0} elementos", queue.Count);
    foreach (object obj in queue){
        Console.WriteLine(obj);
    }

    Console.WriteLine("");
    Console.WriteLine("--------------");
}while(opcion != 7);
