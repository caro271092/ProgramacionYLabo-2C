using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio6
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado){
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura){ 
            return (baseTriangulo * altura)/2;
        }

        public static double CalcularAreaCirculo(double radio){ 
            return radio * radio * 3.141592;
        }

    }
}
