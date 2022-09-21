using System;

namespace Clase4_Entidades
{
    public class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 102.65;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static double SetCotizacion(double cotizacion)
        {
            return cotizRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }
        
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }


    }
}
