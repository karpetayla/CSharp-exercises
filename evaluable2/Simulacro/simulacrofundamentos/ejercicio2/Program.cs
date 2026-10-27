using System;

class Program
{
    static void Main()
    {
        /*Desarrolla un programa en C# que permita a un concesionario ingresar las ventas mensuales de
    coches y realizar un análisis básico. El programa debe:
    • Crear una lista para almacenar el número de coches vendidos en cada mes.
    // ejemplo de Lista con las ventas de los 12 meses
    List<int> ventas = new List<int> { 45, 52, 38, 61, 73, 82, 91, 78,
    64, 55, 47, 39 };
    • Pedir al usuario que ingrese las ventas mes por mes, asegurándose de que cada valor
    sea un número entero no negativo.
    Una vez ingresadas todas las ventas, el programa debe calcular y mostrar:
    • El promedio de coches vendidos por mes.
    • El mes con mayores ventas (número del mes y cantidad vendida).
    • El mes con menores ventas (número del mes y cantidad vendida).
    • El total de coches vendidos en todo el período.*/

    List <int> ventas = new List<int> {45, 52, 38, 61, 73, 82, 91, 78,64, 55, 47, 39};
 
{
    static void Main()
    {
        // Lista para guardar las ventas
        List<int> ventas = new List<int>();

        // Pedir ventas de los 12 meses
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine("Introduce las ventas del mes " + (i + 1));

            int ventasMes = int.Parse(Console.ReadLine());

            // Comprobar que no sea negativo
            while (ventasMes < 0)
            {
                Console.WriteLine("Error. Introduce un número no negativo:");
                ventasMes = int.Parse(Console.ReadLine());
            }

            ventas.Add(ventasMes);
        }

        // Calcular promedio
        double promedio = ventas.Average();

        // Calcular total
        int total = ventas.Sum();

        // Mayor venta
        int mayorVenta = ventas.Max();
        int mesMayor = ventas.IndexOf(mayorVenta) + 1;

        // Menor venta
        int menorVenta = ventas.Min();
        int mesMenor = ventas.IndexOf(menorVenta) + 1;

        // Mostrar resultados
        Console.WriteLine("Promedio de ventas: " + promedio);

        Console.WriteLine("Mayor venta: Mes " + mesMayor +
                          " con " + mayorVenta + " coches");

        Console.WriteLine("Menor venta: Mes " + mesMenor +
                          " con " + menorVenta + " coches");

        Console.WriteLine("Total vendido: " + total);
    }
}


    }
    
    
    

}
