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
    public partial class FrmPrincipalClase5 : Form
    {
        public FrmPrincipalClase5()
        {
            InitializeComponent();
            txtNombre.Text = null;
            txtApellido.Text = null;
        }
        private void FrmPrincipalClase5_Load(object sender, EventArgs e)
        {
            cbMaterias.Items.Add("Programación I");
            cbMaterias.SelectedIndex = 0;
            cbMaterias.Items.Add("Programación II");
            cbMaterias.Items.Add("Laboratorio I");
            cbMaterias.Items.Add("Laboratorio II");
            cbMaterias.Items.Add("Matemática");
            cbMaterias.Items.Add("Estadística");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se deben completar los siguientes campos: ");
                if(String.IsNullOrWhiteSpace(txtNombre.Text)) { sb.AppendLine("Nombre"); }
                if (String.IsNullOrWhiteSpace(txtApellido.Text)) { sb.AppendLine("Apellido"); }
                MessageBox.Show(sb.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
            else { 
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Soy {this.txtNombre.Text} {this.txtApellido.Text}. ");
                sb.Append($"Mi materia favorita es {this.cbMaterias.Text}");
                FrmSegundoFormulario segundoFormulario = new FrmSegundoFormulario("¡Hola, Windows Forms!", sb.ToString() );
                segundoFormulario.ShowDialog();
            }
        }

       
    }
}
