using System;

namespace Clase1_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool parseo;
            string respuesta = "no";
            int cantidadDeDivisores=0;

            while(respuesta != "salir")
            {
                Console.WriteLine("Ingrese un número: ");
                parseo = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (parseo == false)
                {
                    Console.WriteLine("Error, debe ingresar un número.");
                }
                else
                {
                    Console.WriteLine("Los números primos hasta el número ingresado son: ");
                    if (numeroIngresado != 0 && numeroIngresado != 1)
                    {
                        for (int i = 1; i < numeroIngresado; i++)
                        {
                            if (numeroIngresado % i == 0)
                            {
                                cantidadDeDivisores++;
                            }
                            if(cantidadDeDivisores > 2){
                               break;
                            }
                            if (cantidadDeDivisores == 2)
                            {
                                Console.WriteLine("{0}", i);
                            }
                        }
                        
                    }
                }
                Console.WriteLine("Si desea volver a ingresar presione cualquier tecla, para salir escriba: salir.");
                respuesta = Console.ReadLine();
            }
            if(respuesta == "salir")
            {
                Environment.Exit(0);
            }
            /*
            static bool EsPrimo(int numero)
            {
                if(numero != 0 && numero != 1) { 
                    for (int i = 2; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }*/

        }
        
    }
}
