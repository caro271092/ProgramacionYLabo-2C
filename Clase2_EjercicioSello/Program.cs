using System;

namespace Clase2_EjercicioSello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.Imprimir()); //retorna string

            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());
            Sello.mensaje = "hola mundo C#";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();


            Sello.Imprimir();//retorna string
        }
    }
}
