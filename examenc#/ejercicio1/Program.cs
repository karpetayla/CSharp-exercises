using System;


class Program
{
    static void Main()
    {
     /*Crea un programa en C# que calcule el factorial de un número entero positivo ingresado por el usuario. 
     El factorial de un número n (representado como n!) es el producto de todos los enteros positivos desde 1 hasta n. 
     Por ejemplo, 5! = 5 x 4 x 3 x 2 x 1 = 120.

    El programa debe:

        •	Solicitar al usuario que ingrese un número entero positivo.

        •	Validar que el número ingresado sea positivo. Si no lo es, mostrar un mensaje de error y volver a solicitar el número.

        •	Calcular el factorial del número utilizando un bucle (puedes elegir entre for o while).

        •	Mostrar el resultado del cálculo.

        •	Preguntar al usuario si desea calcular otro factorial o salir del programa.

    Utiliza estructuras de control condicionales (if-else) para la validación 
    y un bucle para el cálculo del factorial y la repetición del programa.*/

    int numero=0;
    int factorial=0;
    String salir="";
        while(salir=="S");
            do
            {
                Console.WriteLine("Ingresa un numero entero");
                numero=int.Parse(Console.ReadLine()!);

                if (numero<=0)
                {
                System.Console.WriteLine("Error. Has introducido un numero negativo, por favor ingresa un numero positivo");
                }
                else
                {
                System.Console.WriteLine("Numero guardado correctamente");
                }

                for(int i=(numero-1); i<numero; i--)
                {
                Console.WriteLine("El resultado del factorial es "+ (factorial=numero*i));
                }

            }while(numero<=0);

        System.Console.WriteLine("¿Deseas realizar otra opcion? (S/N)");
        salir=Console.ReadLine().ToUpper()??"N";

   
    }
}

