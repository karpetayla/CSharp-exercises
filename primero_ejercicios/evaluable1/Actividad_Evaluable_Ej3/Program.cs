// Declaración de variables con números decimales
double num1, num2;
//Pido los datos al usuario
Console.WriteLine("Introduce el primer número");
/*Introduzco el double.parse porque necesitamos 
que se identifique el número como string*/
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo número");
num2 =double.Parse(Console.ReadLine());
//Introduzco las condicionales con if/else
if (num1>num2)
{
    Console.WriteLine("El número "+num1+" es mayor que el número "+num2);
}
if (num2>num1)
{
    Console.WriteLine("El número "+num2+" es mayor que el número "+num1);
}
else
{
    Console.WriteLine("Estos números son iguales.");
}
