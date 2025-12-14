using System;
using System.Linq;

namespace Calculadora_simple;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Elige la operación que deseas realizar:");
        Console.WriteLine("\nSuma");
        Console.WriteLine("Resta");
        Console.WriteLine("Multiplicacion");
        Console.WriteLine("Division\n");

        string operacion = Console.ReadLine();

        int n1 = 0;
        Console.WriteLine("\nIngresa el primer número:");
        n1 = int.Parse(Console.ReadLine());

        int n2 = 0;
        Console.WriteLine("\nIngresa el segundo número:");
        n2 = int.Parse(Console.ReadLine());

        switch (operacion.ToLower())
        {
            case "suma":
                int suma = n1 + n2;
                Console.WriteLine("El resultado es: " + suma);
                break;

            case "resta":
                int resta = n1 - n2;
                Console.WriteLine("El resultado es: " + resta);
                break;

            case "multiplicacion":
                int multiplicacion = n1 * n2;
                Console.WriteLine("El resultado es: " + multiplicacion);
                break;

            case "division":
                int division = n1 / n2;
                Console.WriteLine("El resultado es: " + division);
                break;

            default:
                Console.WriteLine("Elige una operación válida");
                break;
        }

    }
}
