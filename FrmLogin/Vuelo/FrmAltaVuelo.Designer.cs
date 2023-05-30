namespace FRMVIAJES
{
    partial class FrmAltaVuelo
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
            lblOrigen = new Label();
            lblDestino = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboOrigen = new ComboBox();
            dtpFechaPartida = new DateTimePicker();
            cboDestino = new ComboBox();
            cboAeronave = new ComboBox();
            cbServicioComida = new CheckBox();
            cbServicioWifi = new CheckBox();
            labelError = new Label();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.ForeColor = Color.White;
            lblOrigen.Location = new Point(12, 28);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(46, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.ForeColor = Color.White;
            lblDestino.Location = new Point(12, 70);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "Destino:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Aeronave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha de partida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Servicios:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 242);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboOrigen
            // 
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(133, 28);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(228, 23);
            cboOrigen.TabIndex = 28;
            // 
            // dtpFechaPartida
            // 
            dtpFechaPartida.Location = new Point(133, 146);
            dtpFechaPartida.Name = "dtpFechaPartida";
            dtpFechaPartida.Size = new Size(228, 23);
            dtpFechaPartida.TabIndex = 29;
            dtpFechaPartida.ValueChanged += dtpFechaPartida_ValueChanged;
            // 
            // cboDestino
            // 
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(133, 67);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(228, 23);
            cboDestino.TabIndex = 30;
            // 
            // cboAeronave
            // 
            cboAeronave.FormattingEnabled = true;
            cboAeronave.Location = new Point(133, 110);
            cboAeronave.Name = "cboAeronave";
            cboAeronave.Size = new Size(228, 23);
            cboAeronave.TabIndex = 31;
            // 
            // cbServicioComida
            // 
            cbServicioComida.AutoSize = true;
            cbServicioComida.ForeColor = Color.White;
            cbServicioComida.Location = new Point(133, 189);
            cbServicioComida.Name = "cbServicioComida";
            cbServicioComida.Size = new Size(68, 19);
            cbServicioComida.TabIndex = 32;
            cbServicioComida.Text = "Comida";
            cbServicioComida.UseVisualStyleBackColor = true;
            // 
            // cbServicioWifi
            // 
            cbServicioWifi.AutoSize = true;
            cbServicioWifi.ForeColor = Color.White;
            cbServicioWifi.Location = new Point(278, 189);
            cbServicioWifi.Name = "cbServicioWifi";
            cbServicioWifi.Size = new Size(47, 19);
            cbServicioWifi.TabIndex = 33;
            cbServicioWifi.Text = "Wifi";
            cbServicioWifi.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(107, 280);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 34;
            labelError.Text = "ERROR";
            // 
            // FrmAltaVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(391, 304);
            Controls.Add(labelError);
            Controls.Add(cbServicioWifi);
            Controls.Add(cbServicioComida);
            Controls.Add(cboAeronave);
            Controls.Add(cboDestino);
            Controls.Add(dtpFechaPartida);
            Controls.Add(cboOrigen);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            ForeColor = Color.White;
            Name = "FrmAltaVuelo";
            Opacity = 0.95D;
            Text = "FrmAltaVuelo";
            Load += FrmAltaVuelo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private Label lblDestino;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboOrigen;
        private DateTimePicker dtpFechaPartida;
        private ComboBox cboDestino;
        private ComboBox cboAeronave;
        private CheckBox cbServicioComida;
        private CheckBox cbServicioWifi;
        private Label labelError;
    }
}