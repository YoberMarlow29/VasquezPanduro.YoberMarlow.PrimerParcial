namespace FRMVIAJES
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            gpbIngresarDatos = new GroupBox();
            menuStrip1 = new MenuStrip();
            iniciarSesionToolStripMenuItem = new ToolStripMenuItem();
            vueloToolStripMenuItem = new ToolStripMenuItem();
            lISTADEVIAJESToolStripMenuItem = new ToolStripMenuItem();
            vENDERVIAJEToolStripMenuItem = new ToolStripMenuItem();
            eSTADISTICASHISTORICASToolStripMenuItem1 = new ToolStripMenuItem();
            pASAJEROSToolStripMenuItem1 = new ToolStripMenuItem();
            avionToolStripMenuItem = new ToolStripMenuItem();
            eSTADISTICASHISTORICASToolStripMenuItem = new ToolStripMenuItem();
            pASAJEROSToolStripMenuItem = new ToolStripMenuItem();
            estadisticasToolStripMenuItem = new ToolStripMenuItem();
            aBMVIAJEToolStripMenuItem = new ToolStripMenuItem();
            aBMAERONAVEToolStripMenuItem = new ToolStripMenuItem();
            gpbIngresarDatos.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(156, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(19, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(46, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(19, 78);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(131, 29);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(195, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(131, 78);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(195, 23);
            txtContraseña.TabIndex = 4;
            // 
            // gpbIngresarDatos
            // 
            gpbIngresarDatos.Controls.Add(txtContraseña);
            gpbIngresarDatos.Controls.Add(btnIngresar);
            gpbIngresarDatos.Controls.Add(txtCorreo);
            gpbIngresarDatos.Controls.Add(lblUsuario);
            gpbIngresarDatos.Controls.Add(lblContraseña);
            gpbIngresarDatos.Location = new Point(335, 188);
            gpbIngresarDatos.Name = "gpbIngresarDatos";
            gpbIngresarDatos.Size = new Size(381, 183);
            gpbIngresarDatos.TabIndex = 6;
            gpbIngresarDatos.TabStop = false;
            gpbIngresarDatos.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarSesionToolStripMenuItem, vueloToolStripMenuItem, avionToolStripMenuItem, estadisticasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            iniciarSesionToolStripMenuItem.Size = new Size(88, 20);
            iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            iniciarSesionToolStripMenuItem.Click += iniciarSesionToolStripMenuItem_Click;
            // 
            // vueloToolStripMenuItem
            // 
            vueloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lISTADEVIAJESToolStripMenuItem, vENDERVIAJEToolStripMenuItem, eSTADISTICASHISTORICASToolStripMenuItem1, pASAJEROSToolStripMenuItem1 });
            vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            vueloToolStripMenuItem.Size = new Size(69, 20);
            vueloToolStripMenuItem.Text = "Vendedor";
            // 
            // lISTADEVIAJESToolStripMenuItem
            // 
            lISTADEVIAJESToolStripMenuItem.Name = "lISTADEVIAJESToolStripMenuItem";
            lISTADEVIAJESToolStripMenuItem.Size = new Size(214, 22);
            lISTADEVIAJESToolStripMenuItem.Text = "LISTA DE VIAJES";
            // 
            // vENDERVIAJEToolStripMenuItem
            // 
            vENDERVIAJEToolStripMenuItem.Name = "vENDERVIAJEToolStripMenuItem";
            vENDERVIAJEToolStripMenuItem.Size = new Size(214, 22);
            vENDERVIAJEToolStripMenuItem.Text = "VENDER VIAJE";
            // 
            // eSTADISTICASHISTORICASToolStripMenuItem1
            // 
            eSTADISTICASHISTORICASToolStripMenuItem1.Name = "eSTADISTICASHISTORICASToolStripMenuItem1";
            eSTADISTICASHISTORICASToolStripMenuItem1.Size = new Size(214, 22);
            eSTADISTICASHISTORICASToolStripMenuItem1.Text = "ESTADISTICAS HISTORICAS";
            // 
            // pASAJEROSToolStripMenuItem1
            // 
            pASAJEROSToolStripMenuItem1.Name = "pASAJEROSToolStripMenuItem1";
            pASAJEROSToolStripMenuItem1.Size = new Size(214, 22);
            pASAJEROSToolStripMenuItem1.Text = "PASAJEROS";
            // 
            // avionToolStripMenuItem
            // 
            avionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eSTADISTICASHISTORICASToolStripMenuItem, pASAJEROSToolStripMenuItem });
            avionToolStripMenuItem.Name = "avionToolStripMenuItem";
            avionToolStripMenuItem.Size = new Size(74, 20);
            avionToolStripMenuItem.Text = "Supervisor";
            // 
            // eSTADISTICASHISTORICASToolStripMenuItem
            // 
            eSTADISTICASHISTORICASToolStripMenuItem.Name = "eSTADISTICASHISTORICASToolStripMenuItem";
            eSTADISTICASHISTORICASToolStripMenuItem.Size = new Size(214, 22);
            eSTADISTICASHISTORICASToolStripMenuItem.Text = "ESTADISTICAS HISTORICAS";
            // 
            // pASAJEROSToolStripMenuItem
            // 
            pASAJEROSToolStripMenuItem.Name = "pASAJEROSToolStripMenuItem";
            pASAJEROSToolStripMenuItem.Size = new Size(214, 22);
            pASAJEROSToolStripMenuItem.Text = "PASAJEROS";
            // 
            // estadisticasToolStripMenuItem
            // 
            estadisticasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMVIAJEToolStripMenuItem, aBMAERONAVEToolStripMenuItem });
            estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            estadisticasToolStripMenuItem.Size = new Size(95, 20);
            estadisticasToolStripMenuItem.Text = "Administrador";
            // 
            // aBMVIAJEToolStripMenuItem
            // 
            aBMVIAJEToolStripMenuItem.Name = "aBMVIAJEToolStripMenuItem";
            aBMVIAJEToolStripMenuItem.Size = new Size(180, 22);
            aBMVIAJEToolStripMenuItem.Text = "VIAJES";
            aBMVIAJEToolStripMenuItem.Click += aBMVIAJEToolStripMenuItem_Click;
            // 
            // aBMAERONAVEToolStripMenuItem
            // 
            aBMAERONAVEToolStripMenuItem.Name = "aBMAERONAVEToolStripMenuItem";
            aBMAERONAVEToolStripMenuItem.Size = new Size(180, 22);
            aBMAERONAVEToolStripMenuItem.Text = "AERONAVE";
            aBMAERONAVEToolStripMenuItem.Click += aBMAERONAVEToolStripMenuItem_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 601);
            Controls.Add(gpbIngresarDatos);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmLogin";
            Text = "Form1";
            Load += Form1_Load;
            gpbIngresarDatos.ResumeLayout(false);
            gpbIngresarDatos.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private GroupBox gpbIngresarDatos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private ToolStripMenuItem avionToolStripMenuItem;
        private ToolStripMenuItem vueloToolStripMenuItem;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
        private ToolStripMenuItem aBMVIAJEToolStripMenuItem;
        private ToolStripMenuItem aBMAERONAVEToolStripMenuItem;
        private ToolStripMenuItem lISTADEVIAJESToolStripMenuItem;
        private ToolStripMenuItem vENDERVIAJEToolStripMenuItem;
        private ToolStripMenuItem eSTADISTICASHISTORICASToolStripMenuItem1;
        private ToolStripMenuItem pASAJEROSToolStripMenuItem1;
        private ToolStripMenuItem eSTADISTICASHISTORICASToolStripMenuItem;
        private ToolStripMenuItem pASAJEROSToolStripMenuItem;
    }
}