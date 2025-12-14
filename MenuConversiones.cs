using System;
using System.Linq;

namespace Menú_de_conversiones;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("MENÚ DE CONVERSIONES\n");
        Console.WriteLine("Elige la opción con la conversión que quieres realizar:");
        Console.WriteLine("1.Conversión grados Celsius a Fahrenheit");
        Console.WriteLine("2.Conversión de km/h a m/s");
        Console.WriteLine("3.Conversión de pesos a dolares\n");


        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                float celsius = 0.00f;
                Console.WriteLine("\nIngresa tus grados en Celsius(solo el número):");
                celsius = float.Parse(Console.ReadLine());
                float conv1 = (celsius * 1.8f) + 32;
                Console.WriteLine(celsius + "°C = " + conv1.ToString("F2") + "°F.");
                break;

            case 2:
                float kmH = 0.00f;
                Console.WriteLine("\nIngresa tus valores en km / h(solo el número):");
                kmH = float.Parse(Console.ReadLine());
                float conv2 = kmH * 0.278f;
                Console.WriteLine(kmH + "km/h = " + conv2.ToString("F2") + "m/s");
                break;

            case 3:
                float pesos = 0.00f;
                Console.WriteLine("\nIngresa tu valor en pesos(solo el número):");
                pesos = float.Parse(Console.ReadLine());
                float conv3 = pesos * 18.18f;
                Console.WriteLine(pesos + " pesos es igual a " + conv3.ToString("F2") + " dolares");
                break;

            default:
                Console.WriteLine("\nIngresa una opción válida");
                break;
        }
    }
}
