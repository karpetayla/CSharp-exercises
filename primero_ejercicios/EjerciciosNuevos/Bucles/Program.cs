using System;
namespace Bucles
{
    class Program
    {
        static void Main(String[] args)
        {
            /*Declaracion de variables
            int numero=0;
            //Introduccion del bucle while
            while (numero<=10)
            {
                Console.WriteLine(numero);
                numero++;
            }*/

            //BUCLE FOR
            //Declaracion de variables
            /*int numero;
            for (numero = 0; numero <= 30;numero=numero+2)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("-----FIN DEL BUCLE-----");*/
    //BUCLE DO WHILE

    //Declaracion de variables
    int numero=0, limite;

    Console.WriteLine("Introduce el limite");
    limite=int.Parse(Console.ReadLine());
    Console.WriteLine("---INICIO---");

            do
            {
                if (numero%2==0)
                {
                    Console.WriteLine(numero+" ES PAR");
                }
                else
                {
                    Console.WriteLine(numero+" ES IMPAR");
                }
               
                numero++;
            }while (numero<limite);

            Console.WriteLine("---FIN---");



        }
            
    }
}