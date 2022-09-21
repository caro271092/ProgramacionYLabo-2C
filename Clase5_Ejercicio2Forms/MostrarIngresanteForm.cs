using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5_Ejercicio2Forms
{
    public partial class MostrarIngresanteForm : Form
    {
        public string mensaje;
        public MostrarIngresanteForm(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
            
        }

        private void MostrarIngresanteForm_Load(object sender, EventArgs e)
        {
            txtDatosIngresante.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
