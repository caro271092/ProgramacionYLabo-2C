using System;

namespace Clase2_Ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool parseo;
            Console.WriteLine("Ingrese un número entero para calcular su tabla de multiplicación.");
            parseo = int.TryParse(Console.ReadLine(), out numero);
            while (parseo == false){
                Console.WriteLine("Error. Ingrese un número entero por favor.");
                parseo = int.TryParse(Console.ReadLine(), out numero);
            }
            Console.WriteLine();
            Console.WriteLine(Tabla.CalculadorDeTabla(numero));

        }
    }
}
