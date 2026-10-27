using System;
using System.Colletion.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml;
namespace Bucles
{
    class Program
    {
         static void Main() 
         {
List <string> nombres = new List<string> ();

         for (int i = 0; i < 5; i++)
         {
            Console.WriteLine($"Introduce el nombre {i+1}:");
            string n = Console.ReadLine();
            nombres.Add(n);
         }
         Console.WriteLine("Los nombres introducidos son: ");
         foreach (string nom in nombres)
         {
            Console.WriteLine(nom);
         }
         }

         
    }
}
