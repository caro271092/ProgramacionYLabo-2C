using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Entidades
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Euro()
        {
            cotizRespectoDolar = 1.17;
        }
        public Euro(double cantidad): this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion() { return cotizRespectoDolar; }
        public double Cantidad() { return cantidad; }   
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * cotizRespectoDolar);
        }
        public static double SetCotizacion(double cotizacion)
        {
           return cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);

        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

    }
}
