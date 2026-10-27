//Declaramos las variables que pueden ser con números decimales
double ancho, alto, area;
//Pedimos al usuario que introduzca los datos que solicitamos
Console.WriteLine("Introduce el ancho de tu rectángulo");
/*Para que cuando el usuario inserte los datos y el programa lo identifique
como string, añadimos double.parse*/
ancho = double.Parse (Console.ReadLine());
Console.WriteLine("Introduce el alto de tu rectángulo");
alto = double.Parse (Console.ReadLine());
//Escribimos la fórmula para indicar al programa como calcular el area
area = ancho * alto;
Console.WriteLine("El área de tu rectángulo es "+area);
