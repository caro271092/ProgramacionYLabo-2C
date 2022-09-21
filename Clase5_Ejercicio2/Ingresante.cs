using System;
using System.Text;

namespace Clase5_Ejercicio2
{
    public class Ingresante
    {
        private string[] cursos; 
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;   
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine($"Dirección: {this.direccion}");
            string cursos = this.cursos.ToString();
            sb.AppendLine($"Cursos: {cursos}");
            return sb.ToString();
        }

    }
}
