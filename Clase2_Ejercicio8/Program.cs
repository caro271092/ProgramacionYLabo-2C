using System;

namespace Clase2_Ejercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //hacerlo con dateTime y sus funciones compare y otra más


            static bool EsBisiesto(int anyo){
                bool respuesta = false;
                if (((anyo % 4 == 0) && (anyo % 100 != 0)) || (anyo % 400 == 0))
                {
                    respuesta = true;
                }
                return respuesta;
            }
            static int NumeroDiasAnyo(int anyo)
            {
                if (EsBisiesto(anyo) == true)
                {
                    return 366;
                }
                else
                {
                    return 365;
                }
            }
            static int DiasTranscurridosAnyo(int dia, int mes){
                //Meses Anyo = { ene 31, feb 28,mar 31, abr 30, may31, jun30, jul31, ago31, spt30, oct31, 30, 31 };
                switch (mes)
                {
                    case 1:
                        return 0+dia;
                    case 2:
                        return 31+dia;
                    case 3:
                        return 59 + dia;
                    case 4:
                        return 90 + dia;
                    case 5:
                        return 120 + dia;
                    case 6:
                        return 151 + dia;
                    case 7:
                        return 181 + dia;
                    case 8:
                        return 212 + dia;
                    case 9:
                        return 243 + dia;
                    case 10:
                        return 273 + dia;
                    case 11:
                        return 304 + dia;
                    default:
                        return 334 + dia;
                }
            }
            static int DiasDeAnyosAnterioresAlActual(){
                //año actual sacarlo con lo de Today y el año
                int anyoActual;
                for (int i = 0; i < anyoActual - 1; i++){
                    suma += Meses_Anyo[contador];
                }
                //  sumar los dias correspondientes al mes actual
                suma += dia;
                // si el año es bisiesto sumar 1 dia mas al total
                if (EsBisiesto(anyo) && mes > 2)
                    suma++;
                // devolver el numero de dias transcurridos de la fecha pasada
                return suma;
            }
            return 0;
            }

        }
    }
}
