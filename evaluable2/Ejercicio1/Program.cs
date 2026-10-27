/*Suma de elementos en un array
Escribe un programa que cree un array de 5 números enteros, solicite al usuario que
ingrese los valores manualmente, y luego calcule y muestre la suma de todos los
elementos del array.*/

// Declaro las variables con el array indicando las posiciones
int [] notas = new int [5];
//Declaro la variable suma que usaremos más tarde y la inicializo
int suma=0;

//Pido al usuario que introduzca los números
Console.WriteLine("Inserta 5 valores enteros");
//Introduzco bucle for para recorrer el array y pedir los datos al usuario
for (int i=0; i<5; i++)
{
    //Muestro por pantalla los valores que me ha introducido el usuario 
    Console.WriteLine($"Introduce el valor en la posición {i+1}:"); 
    //Parseo el array para que recoja los datos y los trasforme a string
    notas [i] = int.Parse(Console.ReadLine()!);   
}
//Para sumar todas las notas vuelvo a recorrer el array con el bucle for
for (int i=0; i<5; i++)
{
    //Realizo la suma de las notas
    suma+=notas[i];
}
Console.Write("La suma de las notas es: "+suma);
