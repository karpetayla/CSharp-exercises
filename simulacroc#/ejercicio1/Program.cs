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
class Program
{
    static void Main()
    {
        double precio=0, preciofinal=0;
        int opcion;
        String categoria="", descuento="", salir="";
        do
        {
            do
             {
            Console.WriteLine ("Inserta el precio del vehiculo");
            precio = double.Parse(Console.ReadLine()!);

            if (precio <= 0)
            {
                System.Console.WriteLine("Error. Has introducido un precio negativo");
            }
            else
            {
                System.Console.WriteLine("Precio guardado correctamente.");
            }
             }while (precio<=0);

            do
            {
            System.Console.WriteLine("Inserta la categoria de tu coche");
            categoria = Console.ReadLine().ToUpper;
            if (categoria !="A" || categoria !="B" || categoria != "C")
            {
                System.Console.WriteLine("Error.Has introducido una categoria inexistente");
            }

            else
            {
                System.Console.WriteLine("Categoría guardada correctamente.");
            }
        

        }while(categoria !="A" || categoria !="B" || categoria != "C");

        switch (categoria)
        {
            case "A": preciofinal=precio*0.95;
                      descuento="5%";
            break;
            case "B": preciofinal=precio*0.90;
                      descuento="10%";
            break;
            case "C": preciofinal=precio*0.85;
                      descuento="15%";
            break;
            default:
            break;

            System.Console.WriteLine($"El precio inicial es: {precio}");
            System.Console.WriteLine($"El descuento es: {descuento}");
            System.Console.WriteLine($"El precio final es: {preciofinal}");

            System.Console.WriteLine("¿Deseas realizar otra opcion? (S/N)");
            salir=Console.ReadLine().ToUpper()??"N";
            }
    }while(salir=="S");
    }
}