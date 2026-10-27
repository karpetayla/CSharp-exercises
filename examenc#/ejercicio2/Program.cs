using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main()
    {
     /*Desarrolla un programa en C# que permita a un profesor ingresar las calificaciones de sus
        estudiantes y realizar un análisis básico de las mismas. El programa debe:
        • Solicitar al usuario que ingrese el número de estudiantes en la clase.
        • Crear una lista para almacenar las calificaciones.
        • Pedir al usuario que ingrese las calificaciones una por una, asegurándose de que cada
        calificación esté entre 0 y 10.
        Una vez ingresadas todas las calificaciones, el programa debe calcular y mostrar:
        • El promedio de las calificaciones.
        • La calificación más alta.
        • La calificación más baja*/ 

        List<double>listacalificaciones = new List<double>();
        int num=0;

        System.Console.WriteLine("¿Cuantos estudiantes son?");
        num=int.Parse(Console.ReadLine()!);

            if (num == 0)
            {
                System.Console.WriteLine("Has introducido un numero incorrecto.");
            }
            else
            {
                for (int i=0; i < num; i++)
                {
                    Console.WriteLine($"Introduce el estudiante {i+1}:");
                    double n = double.Parse(Console.ReadLine()!);
                    listacalificaciones.Add(n);
                    if (n<0 || n > 10)
                    {
                        System.Console.WriteLine("La calificacion introducida no es valida");
                    }
                    else
                    {
                         System.Console.WriteLine("Nota guardada correctamente.");
                    }
            
                }
            }

            double promedio = listacalificaciones.Average();
            double notamin = listacalificaciones.Min();
            double notamax = listacalificaciones.Max();
            System.Console.WriteLine("El promedio de calificaciones es "+promedio);
            System.Console.WriteLine("La calificación más baja es "+notamin);
            System.Console.WriteLine("La calificación más alta es "+notamax);




       
        
    }
}
