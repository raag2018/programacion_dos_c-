double lado = 3;
try{
    double area = lado * lado;
    Console.WriteLine("El area del cuadrado mide: {0}", area);
}catch (FormatException objExcepcion){
    Console.WriteLine(objExcepcion.Message);
}