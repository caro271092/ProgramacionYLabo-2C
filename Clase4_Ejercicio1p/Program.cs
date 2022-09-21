using System;
using Clase4_EntidadesEjercicio1;

namespace Clase4_Ejercicio1p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(3);
            Sumador sumador2 = new Sumador(6);
            //sumador1.CantidadSumas = 3;
            //sumador2.CantidadSumas = 6;
            sumador2.Sumar("Carolina ", "Alvarez");
            sumador1.Sumar(1, 1);
            if(sumador1 | sumador2)
            {
                Console.WriteLine("Son iguales.");
            }
            else { Console.WriteLine("Son distintos."); }
            Console.WriteLine("La sumatoria de ambos sumadores es: {0}", sumador1+sumador2);
            Console.WriteLine("La cantidad de sumas de sumador1 es: {0}", (int)sumador1);
            Console.WriteLine("La cantidad de sumas de sumador2 es: {0}", (int)sumador2);
        }
    }
}
