using System;

namespace Clase2_Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int valorMin = -100;
            int valorMax = 100;
            int numeroMaximo = valorMin;
            int numeroMinimo = valorMax;
            double promedio;
            double suma =0;
            bool parseo;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número entre -100 y 100: ");
                parseo = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!(parseo || Validador.Validar(numeroIngresado, valorMin, valorMax)))
                {
                    Console.WriteLine("Error, debe ingresar un número. Que se encuentre entre -100 y 100."); 
                    Console.WriteLine("Ingrese un número entre -100 y 100: ");
                    parseo = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                if(numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }
                if(numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                suma += numeroIngresado;
            }
            promedio = suma / 10;

            Console.Write("El mínimo ingresado es: {0}\n" +
                          "El máximo ingresado es: {1}\n" +
                          "El promedio es: {2}", numeroMinimo, numeroMaximo, promedio);

        }
    }
}
