// Ejercicio de fundamentos
using System.Xml;

Console.WriteLine("Hola, Mundo!");
int num1, num2, suma, resta, multi, divi; 
Console.WriteLine("Introduce el primer número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo número");
num2 = int.Parse(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
multi = num1 * num2;
divi = num1 / num2;
Console.WriteLine("La suma es "+suma);
Console.WriteLine("La resta es "+resta);
Console.WriteLine("La multiplicación es "+multi);
Console.WriteLine("La división es "+divi);