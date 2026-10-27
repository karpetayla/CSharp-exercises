using System;
using System.Security.Cryptography;

class Program
{
    static void Main ()
    {
        int resultado = Sumar(122, 7);
        Console.WriteLine("LA suma es "+ resultado);
        int r = Restar (0,9);
        Console.WriteLine("La resta es "+ r);
        int m=Multi(8,9);
        Console.WriteLine("La multiplicación es "+m);
    }

static int Sumar(int a, int b)
{
    return a+b;
}
static int Restar(int v1,int v2)
{
    return v1-v2;
}
static int Multi (int num1, int num2)
    {
        int m;
        m=num1*num2;
        return m;
    }
}