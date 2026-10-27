using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        /*Crea un programa en C# que calcule el precio final de un coche aplicando un descuento según su categoría. 
        El programa debe: 
        •	Solicitar al usuario que ingrese el precio base del coche (número decimal positivo). 
        •	Solicitar al usuario que ingrese la categoría del coche (A, B o C). 
        •	Validar que el precio sea positivo. Si no lo es, mostrar un mensaje de error y volver a solicitar el precio. 
        •	Validar que la categoría sea A, B o C. Si no lo es, mostrar un mensaje de error y volver a solicitar la categoría. 
        •	Aplicar el siguiente descuento: 
            o 	Categoría A: 5% de descuento o 	Categoría B: 10% de descuento o 	Categoría C: 15% de descuento 
        •	Calcular el precio final aplicando el descuento correspondiente. 
        •	Mostrar el precio original, el descuento aplicado y el precio final. 
        •	Preguntar al usuario si desea calcular otro precio o salir del programa. 
        Utiliza estructuras de control condicionales (if-else o switch) para la validación y el cálculo, y un bucle para la repetición del programa. */
        
        //Declaro variables

      double precio=0, preciofinal=0;
      String cat="", descuento="", salir="";
        do
        {
            do
        {
            System.Console.WriteLine("Inserta el precio de tu coche");
            precio=double.Parse(Console.ReadLine()!);
            if (precio <= 0)
            {
                System.Console.WriteLine("Error. Has introducido un precio negativo");
            }
        }while(precio<=0);
        System.Console.WriteLine("Precio guardado correctamente");

        do
        {
        System.Console.WriteLine("Inserta la categoria de tu coche");
        cat=Console.ReadLine().ToUpper();
        if (cat!="A" && cat!="B" && cat != "C")
            {
                Console.WriteLine("Error. Categoria incorrecta");
            }
        }while(cat!="A" && cat!="B" && cat != "C");
        System.Console.WriteLine("Categoria guardada");
        switch (cat)
        {
        case "A":
        descuento="5%";
        preciofinal=precio-(precio*0.05);
        break;
        case "B":
        preciofinal=precio-(precio*0.10);
        descuento="10%";
        break;
        case"C":
        preciofinal=precio-(precio*0.15);
         descuento="15%";
        break;
         default:
         break;
        }
        System.Console.WriteLine($"El precio inicial es: {precio}");
        System.Console.WriteLine($"El descuento es: {descuento}");
        System.Console.WriteLine($"El precio final es: {preciofinal}");

        System.Console.WriteLine("¿Deseas realizar otra opcion? (S/N)");
        salir=Console.ReadLine().ToUpper()??"N";
    
    }while(salir=="S");
    }
}