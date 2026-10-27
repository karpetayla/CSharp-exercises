using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
class Program
{
    static void Main()
    {
    /*3. Lista de calificaciones
    Desarrolla un programa que permita al usuario crear una lista de calificaciones. El programa debe:
    - Permitir ingresar calificaciones
    - Calcular el promedio de las calificaciones*/
    //Declaración de variables
    List <double> notas = new List <double> ();
    double suma=0, media=0;
    int numnotas=0, opcion=0;
        //Petición de datos al usuario
        do
        {
            Console.WriteLine("==MENU DE OPCIONES==");
            Console.WriteLine("1. Introducir notas");
            Console.WriteLine("2. Ver notas");
            Console.WriteLine("3. Calcular media");
            Console.WriteLine("4. Salir");
            opcion=int.Parse(Console.ReadLine()!);
            switch (opcion)
            {
                case 1: Console.WriteLine("Introduce el numero de notas");
                        numnotas=int.Parse(Console.ReadLine()!);
                        //Introduzco un condicional por si el usuario introduce 0 notas
                        if(numnotas==0)
                        {
                        Console.WriteLine("Tienes que introducir un numero de notas");
                        }
                        else
                        {
                        //Introducción del bucle for para recorrer la lista de las notas
                        for ( int i=0; i<numnotas; i++)
                        {
                        double nota;
                        Console.WriteLine($"Introduce la nota en la posición {i+1}:");
                        nota=double.Parse(Console.ReadLine()!);
                        notas.Add(nota);
                        }
                        }
                break;
                case 2: 
                        if(notas.Count==0)
                        {
                        Console.WriteLine("No hay notas introducidas aun. Introduce tus notas");
                        }
                        else
                        {
                        Console.WriteLine("Las notas introducidas son: ");
                        //Introducción del bucle foreach para mostrar todas las notas introducidas
                        foreach(double nota in notas)
                        {
                            Console.WriteLine(nota);
                        }
                        }
                break;
                case 3: if (notas.Count==0)
                        {
                        Console.WriteLine("No hay notas introducidas previamente. Tienes que introducir tus notas");
                        }
                        else
                        {
                        /*Introducción del bucle for para calcular la media. 
                         *Recorre toda la lista de notas, las suma y las divide entre el numero de notas*/
                        for (int i=0; i<numnotas; i++)
                        {
                            suma+=notas[i];
                        }
                        //Muestra del resultado.
                        Console.WriteLine("La media de tus notas es: "+(media=suma/numnotas));
                        }
                break;
                case 4: Console.WriteLine("¡Hasta pronto!");
                break;
                default: Console.WriteLine("Has introducido una opción incorrecta. Por favor, introduce una opcion");
                break;
            }
        }while(opcion!=4);
    }
    
    
    
}



