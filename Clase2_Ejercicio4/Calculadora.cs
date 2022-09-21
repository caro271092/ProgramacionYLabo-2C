using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio4
{
    public static class Calculadora
    {
        private static bool Validar(double segundoOperandoDivision)
        {
            bool validar = true;
            if(segundoOperandoDivision == 0)
            {
                validar = false;
            }
            return validar;
        }

        public static double Calcular(double primerOperando, double segundoOperando, string operacion)
        {
            bool parseo = true;
            switch (operacion)
            {
                case "+":
                    return primerOperando + segundoOperando;
                case "-":
                    return primerOperando - segundoOperando;
                case "*":
                    return primerOperando * segundoOperando;
                case "/":
                    while (Validar(segundoOperando) == false || parseo == false) {
                        Console.WriteLine("Error, no se puede multiplicar por 0. Ingrese un número distinto de 0.");
                        parseo = double.TryParse(Console.ReadLine(), out segundoOperando);
                    }
                    return primerOperando / segundoOperando;
               default:
                    return 0;
            }
        }
        public static bool ValidarOperador(string operadorIngresado)
        {
            bool retorno = false;
            if(operadorIngresado == "+" || operadorIngresado == "-" || operadorIngresado == "/"|| operadorIngresado == "*")
            {
                retorno = true; 
            }
            return retorno;
        }

    }
}
