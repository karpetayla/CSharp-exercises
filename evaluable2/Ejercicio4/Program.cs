using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
    /*4. Gestión de lista de compras
    Crea un programa de lista de compras que permita:
    - Agregar elementos a la lista
    - Mostrar todos los elementos de la lista*/
    List <string> compra = new List<string> ();
    int num, opcion=0;
        /*Introduzco bucle do-while para la inserción 
        de un menú en el que el usuario elija cuando salir*/
        do
        {
            Console.WriteLine("1. Agregar elementos a mi lista de la compra");
            Console.WriteLine("2. Ver lista de la compra");
            Console.WriteLine("3. Salir");
            opcion=int.Parse(Console.ReadLine()!);
            //Introduzco el switch para asignarle una tarea a cada caso del menú
            switch (opcion)
            {
                case 1: 
                        Console.WriteLine("¿Cuántos elementos vas a introducir?");
                        num=int.Parse(Console.ReadLine()!);
                        //Introduzco un condicional por si el usuario no introduciese ningun elemento.
                        if (num == 0)
                        {
                        Console.WriteLine("Tienes que introducir una cantidad en tu lista");
                        }
                        else
                        {
                        //Introduzco bucle for para recorrer la lista de los elementos
                         for (int i=0; i<num; i++)
                        {
                        Console.WriteLine($"Introduce el elemento {i+1}:");
                        string c = Console.ReadLine()!;
                        compra.Add(c);
                        }
                        }
                       
                break;
                case 2:
                    /*Introduzco un condicional para indicar que 
                    la lista está vacía si no hubiera ningun elemento*/
                        if (compra.Count==0)
                    {
                        Console.WriteLine("La lista de la compra está vacía. Añade elementos a tu lista");
                    }
                        else
                    {
                        Console.WriteLine("Aquí tienes tu lista de la compra: ");
                        //Introduzco el bucle foreach para que me muestre mi lista de la compra una vez hecha
                        foreach (string c in compra)
                        {
                        Console.WriteLine(c);
                        }
                    }
                        
                break;
                case 3: Console.WriteLine("¡Hasta pronto!");
                break;
                /*Introduzco el default por si el usuario introdujese otra opcion diferente a un 3
                le salte este mensaje*/
                default: Console.WriteLine("Has marcado una opción incorrecta");
                break;
            }
        }while(opcion!=3);
    }
}

