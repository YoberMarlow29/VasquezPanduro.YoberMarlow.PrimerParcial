namespace FRMVIAJES
{
    partial class FrmCrearCuenta
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            txtCorreo = new TextBox();
            txtPerfil = new TextBox();
            txtClave = new TextBox();
            btnAceptar = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 169);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "CORREO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "LEGAJO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "CLAVE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "PERFIL:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(95, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(95, 122);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(241, 23);
            txtLegajo.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(95, 161);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(241, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(95, 233);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(241, 23);
            txtPerfil.TabIndex = 10;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(95, 199);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(241, 23);
            txtClave.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(133, 280);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 321);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 36;
            labelError.Text = "ERROR";
            // 
            // FrmCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 371);
            Controls.Add(labelError);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtPerfil);
            Controls.Add(txtCorreo);
            Controls.Add(txtLegajo);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCrearCuenta";
            Text = "FrmCrearCuenta";
            Load += FrmCrearCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtLegajo;
        private TextBox txtCorreo;
        private TextBox txtPerfil;
        private TextBox txtClave;
        private Button btnAceptar;
        private Label labelError;
    }
}