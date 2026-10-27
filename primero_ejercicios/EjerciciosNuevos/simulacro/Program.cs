using System;
class Program
{
    static void Main()
    {
        int opcion;
        double precio;
        String cat;
      
            Console.WriteLine("Inserta el precio del coche");
            precio=double.Parse(Console.ReadLine()!);
            if (precio <= 1)
            {
            Console.WriteLine("Debes utilizar un valor positivo");
            }
            Console.WriteLine("Inserta la categoría del coche");
            cat=Console.ReadLine()!.ToUpper;
            if (cat!="A" && cat!="B" && cat != "C")
        {
            Console.WriteLine("La categoría que has introducido es incorrecta.");
        }
            
        
        

    }
}
