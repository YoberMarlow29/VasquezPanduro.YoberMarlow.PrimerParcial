namespace FRMVIAJES
{
    partial class FrmVentaPasaje
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
            lstListaPasajeros = new ListBox();
            txtPesoBodega2 = new TextBox();
            txtPesoBodega1 = new TextBox();
            txtPesoBodegaTurista = new TextBox();
            labelPeso = new Label();
            label6 = new Label();
            cbEquipajeMano = new CheckBox();
            rbPremium = new RadioButton();
            label4 = new Label();
            rbTurista = new RadioButton();
            btnVender = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lstListaPasajeros
            // 
            lstListaPasajeros.FormattingEnabled = true;
            lstListaPasajeros.ItemHeight = 15;
            lstListaPasajeros.Location = new Point(12, 12);
            lstListaPasajeros.Name = "lstListaPasajeros";
            lstListaPasajeros.Size = new Size(365, 154);
            lstListaPasajeros.TabIndex = 0;
            // 
            // txtPesoBodega2
            // 
            txtPesoBodega2.Location = new Point(201, 286);
            txtPesoBodega2.Name = "txtPesoBodega2";
            txtPesoBodega2.Size = new Size(168, 23);
            txtPesoBodega2.TabIndex = 30;
            // 
            // txtPesoBodega1
            // 
            txtPesoBodega1.Location = new Point(12, 286);
            txtPesoBodega1.Name = "txtPesoBodega1";
            txtPesoBodega1.Size = new Size(168, 23);
            txtPesoBodega1.TabIndex = 29;
            // 
            // txtPesoBodegaTurista
            // 
            txtPesoBodegaTurista.Location = new Point(201, 250);
            txtPesoBodegaTurista.Name = "txtPesoBodegaTurista";
            txtPesoBodegaTurista.Size = new Size(168, 23);
            txtPesoBodegaTurista.TabIndex = 28;
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Location = new Point(12, 253);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(183, 15);
            labelPeso.TabIndex = 27;
            labelPeso.Text = "Equipaje de Bodega, poner en kg:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 218);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 26;
            label6.Text = "Equipaje de mano:";
            // 
            // cbEquipajeMano
            // 
            cbEquipajeMano.AutoSize = true;
            cbEquipajeMano.Location = new Point(145, 217);
            cbEquipajeMano.Name = "cbEquipajeMano";
            cbEquipajeMano.Size = new Size(122, 19);
            cbEquipajeMano.TabIndex = 25;
            cbEquipajeMano.Text = "Equipaje De Mano";
            cbEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // rbPremium
            // 
            rbPremium.AutoSize = true;
            rbPremium.Location = new Point(295, 179);
            rbPremium.Name = "rbPremium";
            rbPremium.Size = new Size(74, 19);
            rbPremium.TabIndex = 24;
            rbPremium.TabStop = true;
            rbPremium.Text = "Premium";
            rbPremium.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 23;
            label4.Text = "Tipo de Pasajero:";
            // 
            // rbTurista
            // 
            rbTurista.AutoSize = true;
            rbTurista.Location = new Point(145, 179);
            rbTurista.Name = "rbTurista";
            rbTurista.Size = new Size(60, 19);
            rbTurista.TabIndex = 22;
            rbTurista.TabStop = true;
            rbTurista.Text = "Turista";
            rbTurista.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(99, 335);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(75, 23);
            btnVender.TabIndex = 31;
            btnVender.Text = "VENDER";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(192, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmVentaPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 382);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(txtPesoBodega2);
            Controls.Add(txtPesoBodega1);
            Controls.Add(txtPesoBodegaTurista);
            Controls.Add(labelPeso);
            Controls.Add(label6);
            Controls.Add(cbEquipajeMano);
            Controls.Add(rbPremium);
            Controls.Add(label4);
            Controls.Add(rbTurista);
            Controls.Add(lstListaPasajeros);
            Name = "FrmVentaPasaje";
            Text = "FrmVentaPasaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstListaPasajeros;
        private TextBox txtPesoBodega2;
        private TextBox txtPesoBodega1;
        private TextBox txtPesoBodegaTurista;
        private Label labelPeso;
        private Label label6;
        private CheckBox cbEquipajeMano;
        private RadioButton rbPremium;
        private Label label4;
        private RadioButton rbTurista;
        private Button btnVender;
        private Button btnCancelar;
    }
}