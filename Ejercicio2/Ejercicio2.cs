//Determina si es par o impar

Console.WriteLine("Ingrese un numero para determinar si es par om impar");
int num = Convert.ToInt32(Console.Readline());

if(num%2 == 0){
    Console.WriteLine("El numero ingresado es par");
}
else{
    Console.WriteLine("El numero ingresado es impar");
}