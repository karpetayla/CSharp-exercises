/*Primero declaramos las variables del ejercicio, 
lo haremos con double porque pueden darse decimales*/
double lado1, lado2, lado3, peri;
//Segundo, pedimos al usuario que nos introduzca los datos
Console.WriteLine("¿Cuánto mide el lado 1 de tu triángulo?");
/*Como tenemos que pedir los datos al usuario, necesitamos un string, 
y para eso utilizo el double.parse*/
lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("¿Cuánto mide el lado 2 de tu triángulo");
lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("¿Cuánto mide el lado 3 de tu triángulo");
lado3 = double.Parse(Console.ReadLine());
//Decimos al programa qué fórmula tiene que usar para calcular el perímetro
peri = lado1 + lado2 + lado3;
Console.WriteLine("El perímetro de tu triángulo es "+ peri);