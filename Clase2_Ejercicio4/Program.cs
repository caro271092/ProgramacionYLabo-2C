using System;

namespace Clase2_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerOperando;
            double segundoOperando;
            string operador;
            double resultado;
            bool parseo;
            string respuesta;

            Console.WriteLine("Bienvenido, si desea realizar un calculo ingrese cualquier tecla, para salir ingrese n");
            respuesta = Console.ReadLine();
            while (respuesta != "n")
            {
                Console.WriteLine("Ingrese la operación que desea realizar (+, -, / ó *): ");
                operador = Console.ReadLine();
                while (Calculadora.ValidarOperador(operador) == false)
                {
                    Console.WriteLine("Ingrese una operación válida. Suma: +, Resta: -, División: / ó Multiplicación: *): ");
                    operador = Console.ReadLine();
                }
                Console.WriteLine("Ingrese el primer operando: ");
                parseo = double.TryParse(Console.ReadLine(), out primerOperando);
                while (parseo == false)
                {
                    Console.WriteLine("Error, debe ingresar un número.");
                    parseo = double.TryParse(Console.ReadLine(), out primerOperando);
                }
                Console.WriteLine("Ingrese el segundo operando: ");
                parseo = double.TryParse(Console.ReadLine(), out segundoOperando);
                while (parseo == false)
                {
                    Console.WriteLine("Error, debe ingresar un número.");
                    parseo = double.TryParse(Console.ReadLine(), out segundoOperando);
                }
                resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador);
                Console.WriteLine("El resultado de la operación es: {0}\n", resultado);
                Console.WriteLine("Si desea realizar otro cálculo ingrese cualquier tecla, para salir ingrese n");
                respuesta = Console.ReadLine();
            }
            
        }
    }
}
