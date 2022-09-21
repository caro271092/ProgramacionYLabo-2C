using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clase7_Ejercicio1
{
    public enum EPuesto { caja1, caja2 };  
    public class PuestoAtencion
    {
        static private int numeroActual;
        private EPuesto puesto;
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        public static int NumeroActual { 
            get => numeroActual++;}
        public bool Atender(Cliente cli)
        {
            if(cli == null) return false;
            else
            {
                Thread.Sleep(2000);
                return true;
            }
        }


    }
}
