using System;

namespace Clase1_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroAlCubo;
            int numeroAlCuadrado;
            bool parseo;

            Console.WriteLine("Ingresar un número: ");
            parseo = int.TryParse(Console.ReadLine(), out numeroIngresado);
            do
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                parseo = int.TryParse(Console.ReadLine(), out numeroIngresado);
            } while (numeroIngresado <= 0 || parseo==false);
            numeroAlCubo = numeroIngresado * numeroIngresado * numeroIngresado;
            numeroAlCuadrado = numeroIngresado * numeroIngresado;

            Console.Write("El cuadrado del número es: {0}\n" +
                          "El cubo del número es: {1}", numeroAlCuadrado, numeroAlCubo);
        }
    }
}
