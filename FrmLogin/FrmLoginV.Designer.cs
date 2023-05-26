namespace FRMVIAJES
{
    partial class FrmLoginV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginV));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            btnAceptar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 94);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 1;
            label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(225, 164);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Clave:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(443, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 3;
            label3.Text = "LOGIN";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Right;
            txtCorreo.Location = new Point(426, 99);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(342, 23);
            txtCorreo.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Right;
            txtClave.Location = new Point(426, 164);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(342, 23);
            txtClave.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Location = new Point(347, 253);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(291, 37);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(721, 278);
            button1.Name = "button1";
            button1.Size = new Size(47, 40);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLoginV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(780, 330);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(880, 430);
            MinimumSize = new Size(780, 330);
            Name = "FrmLoginV";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoginV";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Button btnAceptar;
        private Button button1;
    }
}