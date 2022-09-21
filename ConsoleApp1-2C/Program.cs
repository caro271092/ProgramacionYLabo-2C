using System;

namespace ConsoleApp1_2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado =0;
            double suma =0;
            double maximo=0;
            double minimo=0;
            double promedio;
            
            for(int i=0; i < 5; i++) {
                Console.WriteLine("Ingresar un número entre -100.000 y 100.000: ");
                numeroIngresado = double.Parse(Console.ReadLine());
                // int.TryParse(, out numeroIngresado);
                if (i == 0){
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }
                else{ 
                    if (numeroIngresado < minimo){
                        minimo = numeroIngresado;
                    }else if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                }
                suma = suma + numeroIngresado;
            }
            promedio = suma / 5;

            Console.Write("El mínimo ingresado es: {0}\n" +
                          "El máximo ingresado es: {1}\n" +
                          "El promedio: {2}", minimo, maximo,promedio);
            Console.ReadKey();            
        }
    }
}
