Console.WriteLine("**********************************************");
Console.WriteLine("********** CONVERSION IMPLICITA **************");
// Conversión implícita de int a decimal
int numeroEntero = 10;
decimal numeroDecimal = numeroEntero;
Console.WriteLine("Numero entero {0}, Numero Decimal {1}", numeroEntero, numeroDecimal);
Console.WriteLine("**********************************************");
Console.WriteLine("********** CONVERSION EXPLICITA **************");
// Conversión explícita de double a int
double precio = 10.5;
int entero = (int) precio;
Console.WriteLine("Numero decimal {0}, Numero entero {1}", precio, entero);
Console.WriteLine("**********************************************");
Console.WriteLine("****** CONVERSION INT, DOUBLE A STRING *******");
string s1, s2;
int num = 44;
double d = 1.234;
s1 = Convert.ToString(num);
s2 = Convert.ToString(d);
Console.WriteLine("Numero entero {0} string {1}, Numero decimal {2} string {3}",num, s1,d, s2);
Console.WriteLine("**********************************************");
Console.WriteLine("****** CONVERSION STRING A INT Y DOUBLE*******");
int s1_numero = Convert.ToInt32(s1);
double s2_numero = Convert.ToDouble(s2);
Console.WriteLine("Texto {0} numero entero {1}, texto {2} numero decimal {3}", s1,s1_numero, s2, s2_numero);
Console.WriteLine("**********************************************");
Console.WriteLine("********* VALORES DE PUNTO FLOTANTE **********");
//aplicando formato al precio de los zapatos
int precio_zapatos = 123;
Console.WriteLine("Precio Zapatos");
Console.WriteLine(String.Format("{0:D}", precio_zapatos));
Console.WriteLine("Promocion de aplicacion de descuento del 9%");
double promocion = precio_zapatos * 0.09;
Console.WriteLine(String.Format("{0:N}", promocion));
Console.WriteLine("Precio Pantalon");
double precio_pantalon = 13.99;
Console.WriteLine(String.Format("{0:F2}", precio_pantalon));
Console.WriteLine("Número de bacterias que puede haber en un gramo de suelo");
double gramo_suelo = 3000000000000;
Console.WriteLine(String.Format("{0:E1}", gramo_suelo));
Console.WriteLine("El precio del pantalon es: {0}", 
    String.Format("{0:C}", precio_pantalon));
Console.WriteLine("**********************************************");
Console.WriteLine("*********** FUNCIONES MATEMATICAS ************");
Console.WriteLine("ABS(X)***************************************");
int numero = -10;
int valorAbsoluto = Math.Abs(numero);
Console.WriteLine("El valor absoluto de {0} es {1}", 
    numero, valorAbsoluto);
double num1 = 5.5;
double num2 = 8.2;
double diferenciaAbsoluta = Math.Abs(num1 - num2);
Console.WriteLine("La diferencia absoluta entre {0} y {1} es {2}", 
    num1, num2, diferenciaAbsoluta);
Console.WriteLine("CEILING(X)***************************************");
double metros = 3.7;
double redondeadoArriba = Math.Ceiling(metros);
Console.WriteLine("El número {0} redondeado hacia arriba es {1}", 
    metros, redondeadoArriba);
/* Calcular la cantidad mínima de paquetes necesarios 
 * para cierta cantidad de productos,
 * si solo se pueden vender en paquetes completos:*/
int cantidadTotal = 25;
int cantidadPorPaquete = 6;
int paquetesNecesarios = (int) 
    Math.Ceiling((double)cantidadTotal / cantidadPorPaquete);
Console.WriteLine("Se necesitan {0} paquetes para {1} productos", 
    paquetesNecesarios, cantidadTotal);
Console.WriteLine("COS(X)***************************************");
// Supongamos que el día tiene 24 horas y
// el pico de productividad ocurre al mediodía.
const double horasPorDia = 24.0;
const double amplitud = 0.5; 
// Amplitud de la variación de productividad
// Iterar a lo largo del día y calcular la productividad del equipo en cada hora
for (int hora = 0; hora < horasPorDia; hora++){
    // Calcular el ángulo correspondiente a la hora del día (0 a 2*pi)
    double angulo = (hora / horasPorDia) * 2 * Math.PI;
    // Calcular la productividad utilizando la función coseno
    double productividad = Math.Cos(angulo) * amplitud + 1;
    // Agregar 1 para asegurar que la productividad sea siempre positiva
    // Imprimir la productividad en esta hora
    if(hora > 9 && hora <= 23){
        Console.WriteLine("Hora {0}: Productividad = {1}", hora, 
            String.Format("{0:F2}", productividad));
    }else{
        Console.WriteLine("Hora {0}:  Productividad = {1}", hora, 
            String.Format("{0:F2}", productividad));
    }
}
Console.WriteLine("FLOOR(X)***************************************");
double nota = 6.8;
double resultado = Math.Floor(nota);
Console.WriteLine("El mayor número entero menor o igual que {0} es {1}",
    nota, resultado);
Console.WriteLine("LOG(X)***************************************");
double x = 1000;
double log = Math.Log(x);
Console.WriteLine("El logaritmo de {0} es {1}",x, log);
double log10 = Math.Log10(x);
Console.WriteLine("El logaritmo en base 10 de {0} es {1}", x, log10);
Console.WriteLine("MAX(X,Y)***************************************");
int[] numeros = { 10, 20, 5, 30, 15 };
int maximo = numeros[0]; 
// Inicializamos el máximo con el primer elemento del array
// Iteramos por el array y actualizamos el máximo si encontramos un valor mayor
for (int i = 1; i < numeros.Length; i++){
    maximo = Math.Max(maximo, numeros[i]);
}
Console.WriteLine("El máximo en la colección es {0}", maximo);
Console.WriteLine("MIN(X,Y)***************************************");
int minimo = numeros[0]; 
// Inicializamos el mínimo con el primer elemento del array
// Iteramos por el array y actualizamos el mínimo si encontramos un valor menor
for (int i = 1; i < numeros.Length; i++){
    minimo = Math.Min(minimo, numeros[i]);
}
Console.WriteLine("El mínimo en la colección es {0}", minimo);
Console.WriteLine("POW(X,Y)***************************************");
double lado = 5;
double area = Math.Pow(lado, 2);
Console.WriteLine("El área de un cuadrado con lado {0} es {1}", lado, area);
Console.WriteLine("ROUND(X)***************************************");
double pi = 3.14159;
int decimales = 2;
double numeroRedondeado = Math.Round(pi, decimales);
Console.WriteLine("El número {0} redondeado a {1} decimales es {2}",
    pi, decimales, numeroRedondeado);
Console.WriteLine("SQRT(X)***************************************");
double ladoA = 3;
double ladoB = 4;
double hipotenusa = Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2));
Console.WriteLine("La longitud de la hipotenusa en un triángulo " +
    "rectángulo con lados de {0} y {1} es {2}", ladoA, ladoB, hipotenusa);