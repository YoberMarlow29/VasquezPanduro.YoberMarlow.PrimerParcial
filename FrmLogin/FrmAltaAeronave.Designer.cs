﻿namespace FRMVIAJES
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
            txtCantidadDeBaños = new TextBox();
            txtMatricula = new TextBox();
            label3 = new Label();
            lblCantidadAsientos = new Label();
            lblMatricula = new Label();
            label2 = new Label();
            txtCapacidadBodega = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(144, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(23, 225);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCantidadDeBaños
            // 
            txtCantidadDeBaños.Location = new Point(156, 131);
            txtCantidadDeBaños.Name = "txtCantidadDeBaños";
            txtCantidadDeBaños.Size = new Size(213, 23);
            txtCantidadDeBaños.TabIndex = 22;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(156, 27);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(213, 23);
            txtMatricula.TabIndex = 20;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 177);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 29;
            label2.Text = "Capacidad de bodega:";
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(156, 177);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.Size = new Size(213, 23);
            txtCapacidadBodega.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "90", "180", "270", "360", "450" });
            comboBox1.Location = new Point(156, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 31;
            // 
            // FrmAltaAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 272);
            Controls.Add(comboBox1);
            Controls.Add(txtCapacidadBodega);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtCantidadDeBaños);
            Controls.Add(txtMatricula);
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
        private TextBox txtCantidadDeBaños;
        private TextBox txtMatricula;
        private Label label3;
        private Label lblCantidadAsientos;
        private Label lblMatricula;
        private Label label1;
        private CheckBox cbServicioComida;
        private CheckBox cbServicioInternet;
        private Label label2;
        private TextBox txtCapacidadBodega;
        private ComboBox comboBox1;
    }
}