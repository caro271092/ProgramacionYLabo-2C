namespace Clase5_Ejercicio2Forms
{
    partial class MostrarIngresanteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDatosIngresante = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatosIngresante
            // 
            this.txtDatosIngresante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatosIngresante.Location = new System.Drawing.Point(22, 12);
            this.txtDatosIngresante.Multiline = true;
            this.txtDatosIngresante.Name = "txtDatosIngresante";
            this.txtDatosIngresante.Size = new System.Drawing.Size(365, 221);
            this.txtDatosIngresante.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(312, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MostrarIngresanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDatosIngresante);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarIngresanteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresante";
            this.Load += new System.EventHandler(this.MostrarIngresanteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatosIngresante;
        private System.Windows.Forms.Button btnAceptar;
    }
}