using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_EjercicioSello
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color; 
       
        public static string Mensaje()
        {
            return mensaje;
        }
        private static string ArmarFormatoMensaje()
        {
            int longitudCadenaMensaje;
            longitudCadenaMensaje = mensaje.Length;
            string asteriscos = "*";
            if (longitudCadenaMensaje > 0)
            {
                for (int i = 0; i < longitudCadenaMensaje+1; i++)
                {
                    asteriscos = asteriscos + '*';
                }
                return asteriscos + "\n*" + Sello.mensaje + "*\n" + asteriscos;
            }
            else
            {
                return "\n";
            }
        }
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

    }
}
