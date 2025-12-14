using System;
using System.Linq;

namespace Contador_Numeros_Positivos_y_Negativos;

public static class Program
{
    public static void Main()
    {
        int contP = 0;
        int contN = 0;

        int num = 0;
        Console.WriteLine("Ingresa un número ya sea positivo o negativo:");
        num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            if (num > 0)
            {
                contP++;
            }
            else
            {
                contN++;
            }

            Console.WriteLine("Ingresa un número ya sea positivo o negativo:");
            num = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingresaste " + contP + " números positivos");
        Console.WriteLine("Ingresaste " + contN + " números negativos");

    }
}
