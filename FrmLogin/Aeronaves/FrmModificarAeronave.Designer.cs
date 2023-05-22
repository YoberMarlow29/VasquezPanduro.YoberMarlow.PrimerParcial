namespace FRMVIAJES
{
    partial class FrmModificarAeronave
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
            cboAsientos = new ComboBox();
            txtCapacidadBodega = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCantidadDeBaños = new TextBox();
            txtMatricula = new TextBox();
            label3 = new Label();
            lblCantidadAsientos = new Label();
            lblMatricula = new Label();
            SuspendLayout();
            // 
            // cboAsientos
            // 
            cboAsientos.FormattingEnabled = true;
            cboAsientos.Items.AddRange(new object[] { "100", "200", "300", "500", "600", "" });
            cboAsientos.Location = new Point(145, 66);
            cboAsientos.Name = "cboAsientos";
            cboAsientos.Size = new Size(213, 23);
            cboAsientos.TabIndex = 41;
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(145, 167);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.Size = new Size(213, 23);
            txtCapacidadBodega.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 39;
            label2.Text = "Capacidad de bodega:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 215);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 37;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCantidadDeBaños
            // 
            txtCantidadDeBaños.Location = new Point(145, 121);
            txtCantidadDeBaños.Name = "txtCantidadDeBaños";
            txtCantidadDeBaños.Size = new Size(213, 23);
            txtCantidadDeBaños.TabIndex = 36;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(145, 17);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(213, 23);
            txtMatricula.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 34;
            label3.Text = "Cantidad de baños:";
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.AutoSize = true;
            lblCantidadAsientos.Location = new Point(12, 69);
            lblCantidadAsientos.Name = "lblCantidadAsientos";
            lblCantidadAsientos.Size = new Size(122, 15);
            lblCantidadAsientos.TabIndex = 33;
            lblCantidadAsientos.Text = "Cantidad de Asientos:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(12, 20);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 32;
            lblMatricula.Text = "Matricula:";
            // 
            // FrmModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 270);
            Controls.Add(cboAsientos);
            Controls.Add(txtCapacidadBodega);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtCantidadDeBaños);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(lblCantidadAsientos);
            Controls.Add(lblMatricula);
            Name = "FrmModificarAeronave";
            Text = "FrmModificarAeronave";
            Load += FrmModificarAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAsientos;
        private TextBox txtCapacidadBodega;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtCantidadDeBaños;
        private TextBox txtMatricula;
        private Label label3;
        private Label lblCantidadAsientos;
        private Label lblMatricula;
    }
}