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
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 218);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "CORREO:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "LEGAJO:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 256);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "CLAVE:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "PERFIL:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(99, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(99, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtLegajo
            // 
            txtLegajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLegajo.Location = new Point(99, 171);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(241, 23);
            txtLegajo.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(99, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(241, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtPerfil
            // 
            txtPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPerfil.Location = new Point(99, 282);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(241, 23);
            txtPerfil.TabIndex = 10;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(99, 248);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(241, 23);
            txtClave.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Left;
            btnAceptar.Location = new Point(99, 325);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 29);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(16, 370);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 36;
            labelError.Text = "ERROR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 82);
            panel1.TabIndex = 37;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(115, 28);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 0;
            label7.Text = "CREAR CUENTA";
            // 
            // FrmCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(377, 435);
            Controls.Add(panel1);
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
            MaximumSize = new Size(493, 574);
            MinimumSize = new Size(393, 474);
            Name = "FrmCrearCuenta";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearCuenta";
            Load += FrmCrearCuenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label7;
    }
}