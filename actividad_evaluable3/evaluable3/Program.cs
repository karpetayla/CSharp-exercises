//Utilizo la libreria System.IO para poder utilizar el objeto StreamReader y StreamWriter
using System;
using System.IO;
//Utilizo la libreria Collections.Generic para poder utilizar las listas 
using System.Collections.Generic;

//Creo la clase empleado para guardar todos los datos que necesitamos
class Empleado
{
    public int ID {get; set;}
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public string Departamento {get;set;}
    public double Salario {get;set;}

    public Empleado (int id, string nombre, int edad, string departamento, double salario)
    {
        ID = id;
        Nombre = nombre;
        Edad = edad;
        Departamento = departamento;
        Salario = salario;
    }

}
//Creo la clase Program donde aquí empieza mi  programa
class Program
{
        static void Main()
        {
        int opcion=0;
        string rutaArchivo = "empleados.txt"; //Declaro el archivo desde el principio
        //Creo una lista donde guardar a todos los empleados, y donde también se puedan añadir los nuevos
        List<Empleado> listaEmpleados = new List<Empleado>();

        //Introduzco bucle do while para crear el menu de opciones
        do
        {
            /*Utilizo el try catch para elaborar un control de excepciones 
            en caso de que el usuario me introduzca un caracter no valido o un intro con un dato vacio*/
            try{
                Console.WriteLine("===MENU DE OPCIONES===");
                Console.WriteLine("1. Leer lista de empleados");
                Console.WriteLine("2. Añadir empleado nuevo");
                Console.WriteLine("3. Calcular salario promedio de los empleados");
                Console.WriteLine("4. Mostrar empleados con salario mayor al promedio");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Elige una opción");
                opcion=int.Parse(Console.ReadLine()!);
                //Introduzco el switch para determinar cada caso
                switch (opcion)
                {
                case 1:
                        //Utilizo condicional para comprobar si el archivo existe
                        if (!File.Exists(rutaArchivo))
                            {
                                Console.WriteLine("El archivo no existe.");
                                return;
                            }
                        //Leer y mostrar cada uno de los empleados linea a linea con el objeto StreamReader
                        using (StreamReader reader = new StreamReader("empleados.txt"))
                        {
                        string linea;
                        while ((linea = reader.ReadLine()!) != null)
                        {
                        //Divido cada línea con :   
                        string[] datos = linea.Split(':');
                        //Introduzco condicional para guardar cada dato en un "cajon" y que se añadan a la lista Empleados
                        if (datos.Length == 5 )
                            {
                            Empleado e = new Empleado(
                            int.Parse(datos[0]),
                            datos[1],
                            int.Parse(datos[2]),
                            datos[3],
                            double.Parse(datos[4])
                            );
                            listaEmpleados.Add(e);
                            }
                        }
                        }
                        Console.WriteLine("===LISTA DE EMPLEADOS===");
                        //Muestro la lista de los empleados mediante un bucle foreach que recorre la lista entera
                        foreach (Empleado worker in listaEmpleados)
                        {
                            Console.WriteLine($"ID:{worker.ID}, Nombre: {worker.Nombre}, Edad: {worker.Edad}, Departamento: {worker.Departamento}, Salario anual: {worker.Salario}");
                        }
                break;
                case 2:
                        //He añadido este caso por si se tuviera que añadir a un empleado nuevo
                        {
                        Console.WriteLine("==AÑADIR EMPLEADO NUEVO==");
                        Console.WriteLine("Ingrese el ID: ");
                        //Con Console.ReadLine recojo los datos que introduce el usuario y con .Parse parseo el numero entero o decimal para que lo lea como un String
                        int id = int.Parse(Console.ReadLine()!);
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine()!;
                        Console.Write("Ingrese la edad del empleado: ");
                        int edad = int.Parse(Console.ReadLine()!);
                        Console.Write("Ingrese el departamento del empleado: ");
                        string departamento = Console.ReadLine()!;
                        Console.Write("Ingrese el salario anual del empleado: ");
                        double salario = double.Parse(Console.ReadLine()!);


                        //Añadir el nuevo empleado al fichero con el objeto StreamWriter
                        using (StreamWriter writer = new StreamWriter ("empleados.txt", append: true))
                        {
                            writer.WriteLine($"{id}:{nombre}:{edad}:{departamento}:{salario}");
                        }
                        }
                        Console.WriteLine("Empleado añadido correctamente.");
                break;

                case 3:
                        //Para que se pueda recuperar la lista ya guardada, he añadido el condicional.
                        //De esta manera recorre la listaEmpleados linea por línea y después pasa a realizar el cálculo promedio
                        if (listaEmpleados.Count == 0) 
                        {
                        Console.WriteLine("Debes leer la lista primero. Selecciona la opcion 1 y después la 3."); 
                        break;
                        }
                        double totalSalario = 0;
                        foreach (Empleado worker in listaEmpleados) totalSalario += worker.Salario;
                        Console.WriteLine($"\nEl salario promedio anual es: {totalSalario / listaEmpleados.Count:F2}€");
                        

                break;

                case 4:
                        //Aquí vuelvo a obligar al usuario a que cargue la lista ya que, si no la carga primero es como si el programa la estuviera buscando
                        if (listaEmpleados.Count == 0)
                        {
                        Console.WriteLine("La lista de empleados está vacía. Debes añadir a un empleado");
                        return;
                        }

                        double totalSalarios = 0;
                        foreach (Empleado worker in listaEmpleados) totalSalarios+=worker.Salario;
                        double salarioPromedio = totalSalarios/listaEmpleados.Count;

                        Console.WriteLine($"\nEmpleados que ganan más de {salarioPromedio:F2} € anuales:");
                        //Vuelvo a recorrer la listaEmpleados para filtrar el empleado con el salario más alto
                        foreach (Empleado worker in listaEmpleados)
                        {
                            if (worker.Salario > salarioPromedio)
                            {
                            Console.WriteLine($"{worker.Nombre}: {worker.Salario:F2}");
                            }
                        }
                break;

                case 5:
                        Console.WriteLine("¡Gracias y hasta pronto!");
                break;
                }
            }
            //Introduzco las excepciones que pueden pasar en caso de que el usuario intente poner una letra en vez de un numero o añadir un dato vacio
            catch (FormatException)
                    {
                        Console.WriteLine("Error. El caracter introducido no es válido.");
                    }
            catch (Exception ex)
                    {
                        Console.WriteLine($"Ocurrió un error. Por favor, revisa los datos: {ex.Message}");
                    }

         }while(opcion!=5);
        }
    }
                    
                    