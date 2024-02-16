Console.WriteLine("*******************************************");
//Ejemplo de literales de un solo caracter
char letra = 'a';
char salto = '\n';
char numCaracter = '1';
Console.WriteLine("Ejemplo de literales de un solo caracter");
Console.WriteLine("{0} {1} {2}",  letra, salto, numCaracter);
Console.WriteLine("*******************************************");
//ejemplo de literales de cadena
string text = "Esto es una cadena de caracteres";
string piText = "3.1415926";
string lenguaje = "Lenguaje \"C#\"";
Console.WriteLine("{0} {1} {2} {3} {4}", text, salto, piText, salto, lenguaje);
Console.WriteLine("*******************************************");
Console.WriteLine("***************CONCATENACION*********************");
//ejemplo de concatenacion
string cancion = "Un nuevo amanecer y un sol que ya brillo\r\nun triunfo hay que obtener en el camino de la verdad\r\nllegando más allá, del horizonte que,\r\nespera nuestros pasos con ideas de triunfar.\r\nCon profesión, calidad y honor vamos forjando un futuro mejor.\r\nSabiduría que viene de Dios pues él nos guía a un mundo mejor";
cancion += "\nCoro:\r\nUniversidad Andrés Bello de gente con capacidad,\r\neres el refugio de los valores, memoria de inmortalidad\r\nUniversidad Andrés Bello, abriste las puertas al bien\r\ntu mensaje nunca olvidaremos, Andrés Bello tu eres inmortal";
Console.WriteLine(cancion);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Arreglo de cadenas*********************");
string[] ciudades = new string[10] {
    "San Salvador", "Mejicanos", "Cojutepeque", "Santa Ana", "San Miguel",
    "Sonsonate", "Chalatenango", "Ilobasco", "San Vicente", "Usulutan"
};
foreach(string ciudad in ciudades){
    Console.WriteLine(ciudad);
}
Console.WriteLine("*******************************************");
Console.WriteLine("***************Conversion de cadenas*********************");
//conversion de cadenas que contienen numeros a tipo de dato numerico
//convertiremos la variable piText a piNumber 
double piNumber = Convert.ToDouble(piText);
string edadText = "20";
int edadNumber = Convert.ToInt32(edadText);
Console.WriteLine("Ejemplo de literales de un solo caracter");
Console.WriteLine("{0} {1} {2}", piNumber, salto, edadNumber);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function CompareTo*********************");
string cabecera = "San Miguel";
if (cabecera.CompareTo(ciudades[0]) == 0) {
    Console.WriteLine("Esta comparacion devuelve {0}", cabecera.CompareTo(ciudades[0]));
    Console.WriteLine("La ciudad {0} es igual a, {1}", cabecera, ciudades[0]);
} else if (cabecera.CompareTo(ciudades[4]) == 0) {
    Console.WriteLine("Esta comparacion devuelve {0}", cabecera.CompareTo(ciudades[4]));
    Console.WriteLine("La ciudad {0}, es igual a {1}", cabecera, ciudades[4]);
} else {
    Console.WriteLine("La ciudad {0}, no esta en el primer elemento del arreglo", cabecera);
}
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function ToLower*********************");
//correcion de cadenas
string cadenaMinuscula = cabecera.ToLower();
Console.WriteLine("Se convirtio la cadena {0} en minuscula {1}"
    ,cabecera,cadenaMinuscula);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function ToUpper*********************");
string cadenaMayuscula = cabecera.ToUpper();
Console.WriteLine("Se convirtio la cadena {0} en mayuscula {1}"
    , cabecera, cadenaMayuscula);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function Trim*********************");
string saludo = " ¡Hola! ";
string saludoSinEspacios = saludo.Trim();
Console.WriteLine("Se eliminan espacios en la cadena,{0}, --{1}--",
    saludo, saludoSinEspacios);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function Insert*********************");
string nombre = "Juan Prez";
string nombreCorrecto = nombre.Insert(6, "e");
Console.WriteLine("Se inserta una letra al nombre,{0}, --{1}--",
    nombre, nombreCorrecto);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Function Remove*********************");
string apellido = nombreCorrecto.Remove(0,5);
Console.WriteLine("Se elimina el nombre y se almacena solo el apellido,{0}, --{1}--",
    apellido, nombre);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Propiedad Length*********************");
int totalCaracteres = nombreCorrecto.Length;
Console.WriteLine("Se obtiene la cantidad total de caracteres de,{0}, --{1}--",
    nombreCorrecto, totalCaracteres);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Funcion Substring*********************");
string file = "muarchivo.txt";
string extension = file.Substring(file.Length - 3, 3);
Console.WriteLine("Se sustrae solo el tipo de extension de,{0},-{1}-",
    file, extension);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Funcion IndexOf*********************");
string trabalengua = "Pablito clavó un clavito en la calva de un calvito. " +
    "En la calva de un calvito, " +
    "un clavito clavó Pablito. Pablito clavó un clavito.";
int palabraEncontrada = trabalengua.IndexOf("calvito");
Console.WriteLine("En el trabalengua,{0}, se indica que a partir" +
    " del caracter -{1}- se encuentra la primera ocurrencia de la palabra calvito",
    trabalengua, palabraEncontrada);
Console.WriteLine("*******************************************");
Console.WriteLine("***************Funcion Split*********************");
string[] palabras;
char separador = ',';
string cadena = "Guitarra, bajo, bateria";
palabras = cadena.Split(separador);
for(int i = 0; i < palabras.Length; i++){
    palabras[i] = palabras[i].Trim();
    Console.WriteLine(palabras[i]);
}
