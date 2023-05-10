namespace FRMVIAJES
{
    partial class FrmAltaCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(145, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(224, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(145, 177);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(229, 23);
            txtDni.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(145, 228);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // FrmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 280);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaCliente";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker1;
    }
}