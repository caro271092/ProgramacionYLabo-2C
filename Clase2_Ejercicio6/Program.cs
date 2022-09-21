using System;
using System.Text;

namespace Clase2_Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int forma;
            bool parseo;
            double ladoCuadrado;
            double alturaTriangulo;
            double baseTriangulo;
            double radio;
            Console.WriteLine("Ingrese el tipo de figura de la cual desea calcular el área: ");
            Console.WriteLine("1: círculo, 2: cuadrado, 3: triángulo");
            parseo = int.TryParse(Console.ReadLine(), out forma);
            while (parseo == false || forma >3 || forma <1){
                Console.WriteLine("Error. Ingrese 1, 2 o 3 acorde al tipo de figura de la cual desea calcular el área: ");
                Console.WriteLine("1: círculo, 2: cuadrado, 3: triángulo");
                parseo = int.TryParse(Console.ReadLine(), out forma);
            
            }
            switch (forma)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio: ");
                    parseo = double.TryParse(Console.ReadLine(), out radio);
                    while (parseo == false)
                    {
                        Console.WriteLine("Error. Ingrese el radio: ");
                        parseo = double.TryParse(Console.ReadLine(), out radio);
                    }
                    StringBuilder sb = new StringBuilder("El área del círculo es: ", 100);
                    sb.Append(CalculadoraDeArea.CalcularAreaCirculo(radio));
                    Console.WriteLine(sb.ToString());
                break;
                case 2:
                    Console.WriteLine("Ingrese el lado: ");
                    parseo = double.TryParse(Console.ReadLine(), out ladoCuadrado);
                    while (parseo == false)
                    {
                        Console.WriteLine("Error. Ingrese el lado del cuadrado: ");
                        parseo = double.TryParse(Console.ReadLine(), out ladoCuadrado);
                    }
                    StringBuilder sbCuadrado = new StringBuilder("El área del cuadrado es: ", 100);
                    sbCuadrado.Append(CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado));
                    Console.WriteLine(sbCuadrado.ToString());
                    break;
                case 3:
                    Console.WriteLine("Ingrese la base del triángulo: ");
                    parseo = double.TryParse(Console.ReadLine(), out baseTriangulo);
                    while (parseo == false)
                    {
                        Console.WriteLine("Error. Ingrese la base del triángulo: ");
                        parseo = double.TryParse(Console.ReadLine(), out baseTriangulo);
                    }
                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    parseo = double.TryParse(Console.ReadLine(), out alturaTriangulo);
                    while (parseo == false)
                    {
                        Console.WriteLine("Error. Ingrese la altura del triángulo: ");
                        parseo = double.TryParse(Console.ReadLine(), out alturaTriangulo);
                    }
                    StringBuilder sbTriangulo = new StringBuilder("El área del triángulo es: ", 100);
                    sbTriangulo.Append(CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo,alturaTriangulo));
                    Console.WriteLine(sbTriangulo.ToString());
                    break;
            }

        }
    }
}
