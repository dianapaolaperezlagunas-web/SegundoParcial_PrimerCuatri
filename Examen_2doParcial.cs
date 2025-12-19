using System;
using System.Linq;

namespace Examen_2doParcial;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("MENÚ DE OPERACIONES:");

        int opcion = 0;

        do
        {


            Console.WriteLine("\nElige la operación que deseas realizar:");
            Console.WriteLine("\n1. Calcular el doble de un número");
            Console.WriteLine("2. Calcular el triple de un número");
            Console.WriteLine("3. Calcular el cuadrado de un número");
            Console.WriteLine("4. Salir\n");

            opcion = int.Parse(Console.ReadLine());

            int num = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nIngresa un número:");
                    num = int.Parse(Console.ReadLine());

                    int op1 = num * 2;

                    Console.WriteLine("\nEl doble de tu número es: " + op1 + "\n");
                    break;

                case 2:
                    Console.WriteLine("\nIngresa un número:");
                    num = int.Parse(Console.ReadLine());

                    int op2 = num * 3;

                    Console.WriteLine("\nEl triple de tu número es: " + op2 + "\n");
                    break;

                case 3:
                    Console.WriteLine("\nIngresa un número:");
                    num = int.Parse(Console.ReadLine());

                    int op3 = num * num;

                    Console.WriteLine("\nEl cuadrado de tu número es: " + op3 + "\n");
                    break;

                case 4:
                    Console.WriteLine("\nVuelva pronto al menú de operaciones, \nAdiós.");
                    break;

                default:
                    Console.WriteLine("_Opción no válida_");
                    break;
            }

        }

        while (opcion != 4);
    }
}
