using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5_Vistas
{
    public partial class FrmSegundoFormulario : Form
    {
        private string titulo;
        private string mensaje;
        public FrmSegundoFormulario(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo; 
            this.mensaje = mensaje;
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;         
        }

        private void FrmSegundoFormulario_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
