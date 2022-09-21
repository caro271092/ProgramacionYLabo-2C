namespace Clase5_Ejercicio2Forms
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.chBJavaScript = new System.Windows.Forms.CheckBox();
            this.chBCMasMas = new System.Windows.Forms.CheckBox();
            this.chBCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbPaises = new System.Windows.Forms.ListBox();
            this.lblPaises = new System.Windows.Forms.Label();
            this.gbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            this.gbDetallesUsuario.Controls.Add(this.numEdad);
            this.gbDetallesUsuario.Controls.Add(this.txtDireccion);
            this.gbDetallesUsuario.Controls.Add(this.txtNombre);
            this.gbDetallesUsuario.Controls.Add(this.lblEdad);
            this.gbDetallesUsuario.Controls.Add(this.lblDireccion);
            this.gbDetallesUsuario.Controls.Add(this.lblNombre);
            this.gbDetallesUsuario.Location = new System.Drawing.Point(57, 40);
            this.gbDetallesUsuario.Name = "gbDetallesUsuario";
            this.gbDetallesUsuario.Size = new System.Drawing.Size(278, 144);
            this.gbDetallesUsuario.TabIndex = 0;
            this.gbDetallesUsuario.TabStop = false;
            this.gbDetallesUsuario.Text = "Detalles del usuario";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(86, 91);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(156, 23);
            this.numEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(86, 56);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(155, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 93);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 59);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Location = new System.Drawing.Point(356, 40);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(144, 100);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(21, 73);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(21, 48);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(21, 23);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.chBJavaScript);
            this.gbCursos.Controls.Add(this.chBCMasMas);
            this.gbCursos.Controls.Add(this.chBCSharp);
            this.gbCursos.Location = new System.Drawing.Point(356, 155);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(144, 100);
            this.gbCursos.TabIndex = 2;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // chBJavaScript
            // 
            this.chBJavaScript.AutoSize = true;
            this.chBJavaScript.Location = new System.Drawing.Point(15, 73);
            this.chBJavaScript.Name = "chBJavaScript";
            this.chBJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chBJavaScript.TabIndex = 2;
            this.chBJavaScript.Text = "JavaScript";
            this.chBJavaScript.UseVisualStyleBackColor = true;
            // 
            // chBCMasMas
            // 
            this.chBCMasMas.AutoSize = true;
            this.chBCMasMas.Location = new System.Drawing.Point(15, 48);
            this.chBCMasMas.Name = "chBCMasMas";
            this.chBCMasMas.Size = new System.Drawing.Size(50, 19);
            this.chBCMasMas.TabIndex = 1;
            this.chBCMasMas.Text = "C++";
            this.chBCMasMas.UseVisualStyleBackColor = true;
            // 
            // chBCSharp
            // 
            this.chBCSharp.AutoSize = true;
            this.chBCSharp.Checked = true;
            this.chBCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBCSharp.Location = new System.Drawing.Point(15, 23);
            this.chBCSharp.Name = "chBCSharp";
            this.chBCSharp.Size = new System.Drawing.Size(41, 19);
            this.chBCSharp.TabIndex = 0;
            this.chBCSharp.Text = "C#";
            this.chBCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(356, 280);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbPaises
            // 
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.ItemHeight = 15;
            this.lbPaises.Location = new System.Drawing.Point(57, 224);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(278, 79);
            this.lbPaises.TabIndex = 4;
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Location = new System.Drawing.Point(57, 203);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(28, 15);
            this.lblPaises.TabIndex = 5;
            this.lblPaises.Text = "País";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 332);
            this.Controls.Add(this.lblPaises);
            this.Controls.Add(this.lbPaises);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetallesUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.ShowIcon = false;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.gbDetallesUsuario.ResumeLayout(false);
            this.gbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetallesUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox chBJavaScript;
        private System.Windows.Forms.CheckBox chBCMasMas;
        private System.Windows.Forms.CheckBox chBCSharp;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lbPaises;
        private System.Windows.Forms.Label lblPaises;
    }
}
