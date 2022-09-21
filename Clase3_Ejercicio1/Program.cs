using System;
using Entidades;

namespace Clase3_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Mario", 4000);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Ingresar(2000);
            Console.WriteLine("Nuevo monto de la cuenta: ARS {0}", cuenta1.Cantidad);
            cuenta1.Retirar(2500);
            Console.WriteLine("Nuevo monto de la cuenta: ARS {0}", cuenta1.Cantidad);
            cuenta1.Ingresar(-1000);
            Console.WriteLine(cuenta1.Mostrar());

        }
    }
}
