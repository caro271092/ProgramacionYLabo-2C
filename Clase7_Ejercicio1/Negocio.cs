using System.Collections.Generic;

namespace Clase7_Ejercicio1
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(EPuesto.caja1);

        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Peek();
            }
            set
            {
                bool respuesta = this + value;
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n.clientes is not null)
            {
                foreach (Cliente item in n.clientes)
                {
                    if (c == item)
                    {
                        retorno = true;
                    }
                }
            }
            else { retorno = false; }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c || n.clientes.Count ==0)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else { return false; }
        }
        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (n.clientes != null)
            {
                retorno = n.caja.Atender(n.Cliente);
                n.clientes.Dequeue();
            }
            return retorno;
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }


    }
}
