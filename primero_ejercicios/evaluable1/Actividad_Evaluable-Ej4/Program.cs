// Primero declaramos variables con números enteros
int num1;
Console.WriteLine("Introduce el número");
//Pedimos al usuario que introduzca los datos 
//Utilizo int.Parse para que identifique el número entero como string
num1 = int.Parse(Console.ReadLine());
//Introduzco los condicionales
/*Indico al programa que si al dividir un número entre 5, el resto es igual a 0,
el número es múltiplo de 5*/
if (num1%5==0)
{
    Console.WriteLine("Este número es múltiplo de 5");
}
else
{
    Console.WriteLine("Este número no es múltiplo de 5");
}
