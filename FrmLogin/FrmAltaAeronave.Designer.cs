namespace FRMVIAJES
{
    partial class FrmAltaAeronave
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            lblCantidadAsientos = new Label();
            lblMatricula = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(144, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(23, 314);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(156, 131);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(213, 23);
            txtEdad.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(156, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 23);
            txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 134);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 17;
            label3.Text = "Cantidad de baños:";
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.AutoSize = true;
            lblCantidadAsientos.Location = new Point(23, 79);
            lblCantidadAsientos.Name = "lblCantidadAsientos";
            lblCantidadAsientos.Size = new Size(122, 15);
            lblCantidadAsientos.TabIndex = 16;
            lblCantidadAsientos.Text = "Cantidad de Asientos:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(23, 30);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 15;
            lblMatricula.Text = "Matricula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 185);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 26;
            label1.Text = "Servicios:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(156, 185);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Servicio de comida";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(286, 184);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 19);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "Servicio de Internet";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 241);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 29;
            label2.Text = "Capacidad de bodega:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 30;
            // 
            // FrmAltaAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 368);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(lblCantidadAsientos);
            Controls.Add(lblMatricula);
            Name = "FrmAltaAeronave";
            Text = "FrmAltaAeronave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label lblCantidadAsientos;
        private Label lblMatricula;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private TextBox textBox1;
    }
}