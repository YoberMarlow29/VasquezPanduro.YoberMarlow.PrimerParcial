namespace FRMVIAJES
{
    partial class FrmModificarVuelo
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
            cbServicioWifi = new CheckBox();
            cbServicioComida = new CheckBox();
            cboAeronave = new ComboBox();
            cboDestino = new ComboBox();
            dtpFechaPartida = new DateTimePicker();
            cboOrigen = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDestino = new Label();
            lblOrigen = new Label();
            labelError = new Label();
            SuspendLayout();
            // 
            // cbServicioWifi
            // 
            cbServicioWifi.AutoSize = true;
            cbServicioWifi.Location = new Point(278, 176);
            cbServicioWifi.Name = "cbServicioWifi";
            cbServicioWifi.Size = new Size(47, 19);
            cbServicioWifi.TabIndex = 46;
            cbServicioWifi.Text = "Wifi";
            cbServicioWifi.UseVisualStyleBackColor = true;
            // 
            // cbServicioComida
            // 
            cbServicioComida.AutoSize = true;
            cbServicioComida.Location = new Point(133, 176);
            cbServicioComida.Name = "cbServicioComida";
            cbServicioComida.Size = new Size(68, 19);
            cbServicioComida.TabIndex = 45;
            cbServicioComida.Text = "Comida";
            cbServicioComida.UseVisualStyleBackColor = true;
            // 
            // cboAeronave
            // 
            cboAeronave.FormattingEnabled = true;
            cboAeronave.Location = new Point(133, 97);
            cboAeronave.Name = "cboAeronave";
            cboAeronave.Size = new Size(228, 23);
            cboAeronave.TabIndex = 44;
            // 
            // cboDestino
            // 
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(133, 54);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(228, 23);
            cboDestino.TabIndex = 43;
            // 
            // dtpFechaPartida
            // 
            dtpFechaPartida.Location = new Point(133, 133);
            dtpFechaPartida.Name = "dtpFechaPartida";
            dtpFechaPartida.Size = new Size(228, 23);
            dtpFechaPartida.TabIndex = 42;
            dtpFechaPartida.ValueChanged += dtpFechaPartida_ValueChanged;
            // 
            // cboOrigen
            // 
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(133, 15);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(228, 23);
            cboOrigen.TabIndex = 41;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(133, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 229);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 38;
            label3.Text = "Servicios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 37;
            label2.Text = "Fecha de partida:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 36;
            label1.Text = "Aeronave:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(12, 57);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 35;
            lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(12, 15);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(46, 15);
            lblOrigen.TabIndex = 34;
            lblOrigen.Text = "Origen:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 280);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 47;
            labelError.Text = "ERROR";
            // 
            // FrmModificarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 335);
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
            Name = "FrmModificarVuelo";
            Text = "FrmModificarVuelo";
            Load += FrmModificarVuelo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbServicioWifi;
        private CheckBox cbServicioComida;
        private ComboBox cboAeronave;
        private ComboBox cboDestino;
        private DateTimePicker dtpFechaPartida;
        private ComboBox cboOrigen;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblDestino;
        private Label lblOrigen;
        private Label labelError;
    }
}