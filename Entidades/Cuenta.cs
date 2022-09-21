using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta()
        {
            this.titular = "Sin nombre";
            this.cantidad = 0;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El titular de la cuenta es:  {this.Titular}");
            sb.AppendLine($"La cantidad de dinero en la cuenta: {this.Cantidad}");
            return sb.ToString();
        }
        public void Ingresar(double cantidadAAcreditar)
        {
            if(cantidadAAcreditar > 0)
            {
                this.cantidad+=cantidadAAcreditar;
            }
        }
        public void Retirar(double cantidadADebitar)
        {
            if (cantidadADebitar > 0) { 
             this.cantidad -= cantidadADebitar;
            }
        }

    }
}

