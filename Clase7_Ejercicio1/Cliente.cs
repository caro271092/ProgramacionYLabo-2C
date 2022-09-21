﻿using System;

namespace Clase7_Ejercicio1
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; }
        public Cliente(int numero)
        {
            this.numero = numero;  
        }
        public Cliente(int numero, string nombre)
        {
            this.nombre = nombre;
        }   
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;  
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }



    }
}
