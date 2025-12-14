using System;
using System.Linq;

namespace Suma_de_los_primeros_N_números;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("SUMA DE LOS PRIMEROS N NÚMEROS\n");
        Console.WriteLine("Ingresa un número entero");

        int num = int.Parse(Console.ReadLine());
        long suma = 0;
        for (int i = 1; i <= num; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("\nTu suma de n números es igual " + suma);
    }
}
