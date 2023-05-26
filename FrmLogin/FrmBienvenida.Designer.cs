namespace FRMVIAJES
{
    partial class FrmBienvenida
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
            btnIngresar = new Button();
            label1 = new Label();
            btnCrearCuenta = new Button();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Location = new Point(134, 152);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(391, 37);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INICIAR SESION";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 68);
            label1.Name = "label1";
            label1.Size = new Size(426, 54);
            label1.TabIndex = 2;
            label1.Text = "Bienvenidos al Sistema";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearCuenta.Location = new Point(134, 204);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(391, 37);
            btnCrearCuenta.TabIndex = 4;
            btnCrearCuenta.Text = "CREAR CUENTA";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(646, 352);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(746, 452);
            MinimumSize = new Size(646, 352);
            Name = "FrmBienvenida";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoginV2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private Button btnCrearCuenta;
    }
}