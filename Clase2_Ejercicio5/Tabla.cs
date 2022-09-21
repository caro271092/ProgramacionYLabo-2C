using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio5
{
    public static class Tabla
    {
        public static string CalculadorDeTabla(int numero)
        {
            StringBuilder sb = new StringBuilder("", 100);
            for(int i = 0; i < 9; i++)
            {
                sb.AppendFormat("{0} x {1} = {2}\n", numero, i+1, numero*(i + 1));
            }
            return sb.ToString();
        }
    }
}
