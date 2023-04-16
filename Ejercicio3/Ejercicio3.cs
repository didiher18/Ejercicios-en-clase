/*Segun el tiempo que estuvo en un centro comercial se les cobra
60 minutos = 5
2hrs = 15
2+=40*/

const int hora1 = 5;
const int hr2 = 15;
const int mas2hr = 40;

Console.WriteLine("Seleccione la cantidad de tiempo que ha permanecido en este establecimiento");
Console.WriteLine("1. 60 minutos/1hora");
Console.WriteLine("2. 2 horas");
Console.WriteLine("3. Mas de dos horas");
int opc = Convert.ToInt32(Console.Readline());

if(opc == 1){
    Console.WriteLine($"Su monto es de{hora1}");
}
else if (opc == 2){
    Console.WriteLine($"Su monto es de{hr2}");
}
else{
    Console.WriteLine($"Su monto es de{mas2hr}");
}