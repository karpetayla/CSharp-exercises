/*Console.WriteLine("Introduce un numero");
int numero = int.Parse(Console.ReadLine());

//Verifica si el numero está entre 10 y 20

if (numero>=10 && numero<=20)
{
    Console.WriteLine("El número está entre 10 y 20");
}

else
{
    Console.WriteLine("El número no está entre 10 y 20");
}*/

/*Console.WriteLine ("Introduce un numero");
int numero = int.Parse(Console.ReadLine());
// Verifica si el numero está entre 10 y 20

if (numero >=10 || numero == 0)
{
    Console.WriteLine("Contraseña correcta");
}
else
{
    Console.WriteLine("Contraseña incorrecta");
}*/

//Declaración de variables
int edad;
Console.WriteLine("Introduce tu edad");

//Parseo la edad de entero a string
edad=int.Parse(Console.ReadLine());

if (!(edad >= 18))
{
    Console.WriteLine("No puedes pasar");
}
else
{
    Console.WriteLine("Pasas");
}
