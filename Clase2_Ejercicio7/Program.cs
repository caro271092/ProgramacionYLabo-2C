using System;
using System.Text;
using Clase2_Ejercicio6;

namespace Clase2_Ejercicio7
{
    public class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double areaBase;
            double areaAltura;
            double alturaTriangulo;
            double longitudHipotenusa;
            bool parseo;

            Console.WriteLine("Calculadora de hipotenusa. ");
            Console.WriteLine("Ingrese la base del triángulo (cm): ");
            parseo = double.TryParse(Console.ReadLine(), out baseTriangulo);
            while (parseo == false)
            {
                Console.WriteLine("Error. Ingrese la base del triángulo (cm): ");
                parseo = double.TryParse(Console.ReadLine(), out baseTriangulo);
            }
            Console.WriteLine("Ingrese la altura del triángulo (cm): ");
            parseo = double.TryParse(Console.ReadLine(), out alturaTriangulo);
            while (parseo == false)
            {
                Console.WriteLine("Error. Ingrese la altura (cm): ");
                parseo = double.TryParse(Console.ReadLine(), out alturaTriangulo);
            }
            areaBase = CalculadoraDeArea.CalcularAreaCuadrado(baseTriangulo);
            areaAltura = CalculadoraDeArea.CalcularAreaCuadrado(alturaTriangulo);
            StringBuilder sbTriangulo = new StringBuilder("La hipotenusa del triángulo mide (cm): ", 100);
            longitudHipotenusa = Math.Sqrt(areaBase + areaAltura);
            sbTriangulo.Append(longitudHipotenusa);
            Console.WriteLine(sbTriangulo.ToString());
        }
    }
}
