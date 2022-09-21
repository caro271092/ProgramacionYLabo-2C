using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase5_Ejercicio2;

namespace Clase5_Ejercicio2Forms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();  
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            
            //ListBox lbPaises = new ListBox();
            lbPaises.Items.Add("Argentina");
            lbPaises.Items.Add("Chile");
            lbPaises.Items.Add("Uruguay");
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int)numEdad.Value;
            string pais = lbPaises.Text;
            string genero;
            if (rbFemenino.Checked){genero = rbFemenino.Text;
            }else if (rbMasculino.Checked) { genero = rbMasculino.Text; }
            else { genero = rbNoBinario.Text; }  
            string[] cursos = new string[3];
            if (chBCMasMas.Checked == true) { cursos[0] = chBCMasMas.Text; }
            if (chBCSharp.Checked == true) { cursos[1] = chBCSharp.Text; }
            if (chBJavaScript.Checked == true) { cursos[2] = chBJavaScript.Text; }
            Ingresante nuevoIngresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);


            if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) || (numEdad.Value)==0 ||
                String.IsNullOrWhiteSpace(lbPaises.Text) || String.IsNullOrWhiteSpace(gbGenero.Text))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Por favor chequee que no quede ningún campo sin completar");
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensaje = nuevoIngresante.Mostrar();
                MostrarIngresanteForm formularioIngresante = new MostrarIngresanteForm(mensaje);
                formularioIngresante.ShowDialog();

            }
        }
    }
    
}
