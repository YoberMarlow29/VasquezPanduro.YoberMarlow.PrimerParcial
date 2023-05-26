namespace FRMVIAJES
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelMenuPrincipal = new Panel();
            btnEstadisticas = new Button();
            btnVenderPasaje = new Button();
            btnVuelos = new Button();
            btnPasajeros = new Button();
            btnAeronaves = new Button();
            panelUsuario = new Panel();
            panelFormularioHijo = new Panel();
            pictureBox1 = new PictureBox();
            panelMenuPrincipal.SuspendLayout();
            panelFormularioHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.AutoScroll = true;
            panelMenuPrincipal.BackColor = Color.FromArgb(11, 7, 17);
            panelMenuPrincipal.Controls.Add(btnEstadisticas);
            panelMenuPrincipal.Controls.Add(btnVenderPasaje);
            panelMenuPrincipal.Controls.Add(btnVuelos);
            panelMenuPrincipal.Controls.Add(btnPasajeros);
            panelMenuPrincipal.Controls.Add(btnAeronaves);
            panelMenuPrincipal.Controls.Add(panelUsuario);
            panelMenuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Location = new Point(0, 0);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(250, 561);
            panelMenuPrincipal.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Dock = DockStyle.Top;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.ForeColor = Color.Gainsboro;
            btnEstadisticas.Location = new Point(0, 280);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(10, 0, 0, 0);
            btnEstadisticas.Size = new Size(250, 45);
            btnEstadisticas.TabIndex = 8;
            btnEstadisticas.Text = "ESTADISTICAS";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnVenderPasaje
            // 
            btnVenderPasaje.Dock = DockStyle.Top;
            btnVenderPasaje.FlatAppearance.BorderSize = 0;
            btnVenderPasaje.FlatStyle = FlatStyle.Flat;
            btnVenderPasaje.ForeColor = Color.Gainsboro;
            btnVenderPasaje.Location = new Point(0, 235);
            btnVenderPasaje.Name = "btnVenderPasaje";
            btnVenderPasaje.Padding = new Padding(10, 0, 0, 0);
            btnVenderPasaje.Size = new Size(250, 45);
            btnVenderPasaje.TabIndex = 7;
            btnVenderPasaje.Text = "VENDER PASAJE";
            btnVenderPasaje.TextAlign = ContentAlignment.MiddleLeft;
            btnVenderPasaje.UseVisualStyleBackColor = true;
            btnVenderPasaje.Click += btnVenderPasaje_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Dock = DockStyle.Top;
            btnVuelos.FlatAppearance.BorderSize = 0;
            btnVuelos.FlatStyle = FlatStyle.Flat;
            btnVuelos.ForeColor = Color.Gainsboro;
            btnVuelos.Location = new Point(0, 190);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Padding = new Padding(10, 0, 0, 0);
            btnVuelos.Size = new Size(250, 45);
            btnVuelos.TabIndex = 5;
            btnVuelos.Text = "VUELOS";
            btnVuelos.TextAlign = ContentAlignment.MiddleLeft;
            btnVuelos.UseVisualStyleBackColor = true;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnPasajeros
            // 
            btnPasajeros.Dock = DockStyle.Top;
            btnPasajeros.FlatAppearance.BorderSize = 0;
            btnPasajeros.FlatStyle = FlatStyle.Flat;
            btnPasajeros.ForeColor = Color.Gainsboro;
            btnPasajeros.Location = new Point(0, 145);
            btnPasajeros.Name = "btnPasajeros";
            btnPasajeros.Padding = new Padding(10, 0, 0, 0);
            btnPasajeros.Size = new Size(250, 45);
            btnPasajeros.TabIndex = 3;
            btnPasajeros.Text = "PASAJEROS";
            btnPasajeros.TextAlign = ContentAlignment.MiddleLeft;
            btnPasajeros.UseVisualStyleBackColor = true;
            btnPasajeros.Click += btnPasajeros_Click;
            // 
            // btnAeronaves
            // 
            btnAeronaves.Dock = DockStyle.Top;
            btnAeronaves.FlatAppearance.BorderSize = 0;
            btnAeronaves.FlatStyle = FlatStyle.Flat;
            btnAeronaves.ForeColor = Color.Gainsboro;
            btnAeronaves.Location = new Point(0, 100);
            btnAeronaves.Name = "btnAeronaves";
            btnAeronaves.Padding = new Padding(10, 0, 0, 0);
            btnAeronaves.Size = new Size(250, 45);
            btnAeronaves.TabIndex = 1;
            btnAeronaves.Text = "AERONAVES";
            btnAeronaves.TextAlign = ContentAlignment.MiddleLeft;
            btnAeronaves.UseVisualStyleBackColor = true;
            btnAeronaves.Click += btnAeronaves_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(11, 7, 17);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(250, 100);
            panelUsuario.TabIndex = 0;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.BackColor = Color.FromArgb(23, 21, 32);
            panelFormularioHijo.Controls.Add(pictureBox1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(250, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(934, 561);
            panelFormularioHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenuPrincipal);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(1500, 800);
            MinimumSize = new Size(1200, 600);
            Name = "FrmMenu";
            Opacity = 0.9D;
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            panelMenuPrincipal.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuPrincipal;
        private Button btnEstadisticas;
        private Button btnVenderPasaje;
        private Button btnVuelos;
        private Button btnPasajeros;
        private Button btnAeronaves;
        private Panel panelFormularioHijo;
        private PictureBox pictureBox1;
        private Panel panelUsuario;
    }
}