using System;
using System.Globalization;
using System.Security.Principal;
class Program
{
    static void Main()
    {
    /*2. Búsqueda de un elemento en un array
    Crea un programa que inicialice un array de 8 números enteros. Pide al usuario que
    ingrese un número para buscar en el array y muestra si el número está presente o no,
    indicando su posición si lo encuentra.*/
    //Declaro el array
    int[] numeros  =  { 23, 2, 15, 95, 17, 9, 86, 74 };
    int num;
    /*Introduzco un valor booleano ya que el programa realmente no sabe 
    si el valor que está introduciendo el usuario realmente está o no en el array*/
    bool numencontrado=false;
    Console.WriteLine("Introduce un valor entero");
    //Recojo los datos del usuario
    num=int.Parse(Console.ReadLine());
    //Introduzco el bucle for para recorrer el array
    for (int i=0; i < numeros.Length; i++)
        {
            //Introduzco un condicional
            if (num == numeros[i])
            {
                numencontrado=true;
                Console.WriteLine("El valor que has introducido está en el array, en la posición "+i);
                //Introduzco el break para que el bucle no siga recorriendo el array cuando haya encontrado la posición
                break;
            }
        }
        if (numencontrado == false)
        {
            Console.WriteLine("El valor que has introducido no está en el array");
        }
        
        
    }
}


