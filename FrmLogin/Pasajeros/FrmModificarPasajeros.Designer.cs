namespace FRMVIAJES
{
    partial class FrmModificarPasajeros
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
            txtEdad = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(159, 124);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(229, 23);
            txtEdad.TabIndex = 41;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(159, 169);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(229, 23);
            txtDni.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(159, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(229, 23);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 23);
            txtNombre.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 177);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 26;
            label5.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 25;
            label3.Text = "Edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 24;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 23;
            label1.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(211, 224);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 30;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(313, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(26, 268);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 42;
            labelError.Text = "ERROR";
            // 
            // FrmModificarPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 306);
            Controls.Add(labelError);
            Controls.Add(txtEdad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmModificarPasajeros";
            Text = "FrmModificarCliente";
            Load += FrmModificarPasajeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label labelError;
    }
}