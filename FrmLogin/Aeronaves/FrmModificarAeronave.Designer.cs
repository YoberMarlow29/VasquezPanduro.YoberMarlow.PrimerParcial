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
            txtCantidadAsientos = new TextBox();
            btnGenerarMatricula = new Button();
            txtCapacidadBodega = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCantidadDeBaños = new TextBox();
            txtMatricula = new TextBox();
            label3 = new Label();
            lblCantidadAsientos = new Label();
            lblMatricula = new Label();
            labelError = new Label();
            SuspendLayout();
            // 
            // txtCantidadAsientos
            // 
            txtCantidadAsientos.Location = new Point(145, 72);
            txtCantidadAsientos.Name = "txtCantidadAsientos";
            txtCantidadAsientos.Size = new Size(213, 23);
            txtCantidadAsientos.TabIndex = 44;
            // 
            // btnGenerarMatricula
            // 
            btnGenerarMatricula.Location = new Point(364, 23);
            btnGenerarMatricula.Name = "btnGenerarMatricula";
            btnGenerarMatricula.Size = new Size(158, 23);
            btnGenerarMatricula.TabIndex = 43;
            btnGenerarMatricula.Text = "GENERAR MATRICULA";
            btnGenerarMatricula.UseVisualStyleBackColor = true;
            btnGenerarMatricula.Click += btnGenerarMatricula_Click;
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(145, 173);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.Size = new Size(213, 23);
            txtCapacidadBodega.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 41;
            label2.Text = "Capacidad de bodega:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 221);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // txtCantidadDeBaños
            // 
            txtCantidadDeBaños.Location = new Point(145, 127);
            txtCantidadDeBaños.Name = "txtCantidadDeBaños";
            txtCantidadDeBaños.Size = new Size(213, 23);
            txtCantidadDeBaños.TabIndex = 38;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(145, 23);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(213, 23);
            txtMatricula.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 36;
            label3.Text = "Cantidad de baños:";
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.AutoSize = true;
            lblCantidadAsientos.Location = new Point(12, 75);
            lblCantidadAsientos.Name = "lblCantidadAsientos";
            lblCantidadAsientos.Size = new Size(122, 15);
            lblCantidadAsientos.TabIndex = 35;
            lblCantidadAsientos.Text = "Cantidad de Asientos:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(12, 26);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 34;
            lblMatricula.Text = "Matricula:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(233, 229);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 45;
            labelError.Text = "ERROR";
            // 
            // FrmModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 268);
            Controls.Add(labelError);
            Controls.Add(txtCantidadAsientos);
            Controls.Add(btnGenerarMatricula);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModificarAeronave";
            Load += FrmModificarAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidadAsientos;
        private Button btnGenerarMatricula;
        private TextBox txtCapacidadBodega;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtCantidadDeBaños;
        private TextBox txtMatricula;
        private Label label3;
        private Label lblCantidadAsientos;
        private Label lblMatricula;
        private Label labelError;
    }
}