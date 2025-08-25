// Realizar un programa que permita el ingreso de una hora (cantidad de horas, minutos y segundos) y muestre en pantalla a cuantos segundos corresponde (total en segundos).
using System;
namespace ejercicio4;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido, convertiremos la hora en segundos");
        string horaStr, minutosStr, segundosStr;
        int hora, minutos, segundos;
        Console.WriteLine("Ingrese la hora que quiera: ");
        horaStr = Console.ReadLine();
        Console.WriteLine("Ingrese los minutos: ");
        minutosStr = Console.ReadLine();
        Console.WriteLine("Ingrese los segundos: ");
        segundosStr = Console.ReadLine();
        while (true)
        {
            if (!int.TryParse(horaStr, out hora) || !int.TryParse(minutosStr, out minutos) || !int.TryParse(segundosStr, out segundos))
            {
                Console.WriteLine("error: ingrese solo numeros enteros");
                continue;
            }
            if (hora <= 0 || minutos > 60 || segundos > 60 || hora > 24 || minutos <= 0 || segundos <= 0)
            {
                Console.WriteLine("ingrese dentro del formato horario de 24 hs: ");
                continue;
            }
            break;
        }
        int resultado;
        resultado = hora * 3600 + minutos * 60 + segundos;
        Console.WriteLine($"La hora {hora} mas los minutos {minutos} y los segundos {segundos} da una cantidad de segundos totales de: {resultado}");
        Console.WriteLine("presione una tecla para cerrar el programa");
        Console.ReadKey();
    }
}