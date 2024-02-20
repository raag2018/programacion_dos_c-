using System;
Console.WriteLine("*************************************");
Console.WriteLine("*********** DATETIME ****************");
//creando objeto de la clase DateTime
DateTime miTiempo = DateTime.Now;
Console.WriteLine("Fecha y hora actual: {0}", miTiempo.ToString());
string formato;
formato = String.Format("La fecha es: {0:dddd yyyy M}",DateTime.Now);
Console.WriteLine(formato);
DateTime specificDate = new DateTime(2024, 2, 20);
Console.WriteLine(specificDate.ToString());
DateTime today = DateTime.Today;
string formattedDate = today.ToString("yyyy-MM-dd");
Console.WriteLine(formattedDate);
DateTime futureDate = DateTime.Now.AddHours(24);
Console.WriteLine(futureDate.ToString());
DateTime startDate = new DateTime(2024, 2, 10);
DateTime endDate = new DateTime(2024, 2, 20);
TimeSpan difference = endDate - startDate;
//Console.WriteLine("La diferencia es: {0} días",difference.ToString("dd"));
Console.WriteLine("La diferencia es: {0} días", difference.Days);
DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
Console.WriteLine(dayOfWeek.ToString());
int year = 2024;
bool isLeapYear = DateTime.IsLeapYear(year);
Console.WriteLine("El año {0}, es {1}", 
    year, isLeapYear ? "Si es bisiesto" : "No es bisiesto");
DateTime utcTime = DateTime.UtcNow;
TimeZoneInfo targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
DateTime targetTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, targetTimeZone);
Console.WriteLine(targetTime.ToString());
DateTime date1 = new DateTime(2024, 2, 20);
DateTime date2 = new DateTime(2024, 2, 20);
int comparisonResult = DateTime.Compare(date1, date2);
Console.WriteLine(comparisonResult);
if (comparisonResult == -1){
    Console.WriteLine("La fecha {0} es menor que {1}", date1,date2);
}else if(comparisonResult == 0){
    Console.WriteLine("Ambas fechas son iguales: {0} es igual a {1}", date1, date2);
}else if(comparisonResult == 1){
    Console.WriteLine("La fecha {0} es mayor que {1}", date1, date2);
}