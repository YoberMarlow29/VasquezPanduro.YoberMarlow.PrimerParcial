namespace FRMVIAJES
{
    partial class FrmAltaPasajeros
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
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            rbTurista = new RadioButton();
            label4 = new Label();
            rbPremium = new RadioButton();
            cbEquipajeMano = new CheckBox();
            label6 = new Label();
            labelPeso = new Label();
            txtPesoBodegaTurista = new TextBox();
            txtPesoBodega1 = new TextBox();
            txtPesoBodega2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(145, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(229, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(145, 177);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(229, 23);
            txtDni.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(153, 408);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(255, 408);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(145, 132);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(229, 23);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // rbTurista
            // 
            rbTurista.AutoSize = true;
            rbTurista.Location = new Point(145, 230);
            rbTurista.Name = "rbTurista";
            rbTurista.Size = new Size(60, 19);
            rbTurista.TabIndex = 13;
            rbTurista.TabStop = true;
            rbTurista.Text = "Turista";
            rbTurista.UseVisualStyleBackColor = true;
            rbTurista.CheckedChanged += rbTurista_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo de Pasajero:";
            // 
            // rbPremium
            // 
            rbPremium.AutoSize = true;
            rbPremium.Location = new Point(295, 230);
            rbPremium.Name = "rbPremium";
            rbPremium.Size = new Size(74, 19);
            rbPremium.TabIndex = 15;
            rbPremium.TabStop = true;
            rbPremium.Text = "Premium";
            rbPremium.UseVisualStyleBackColor = true;
            rbPremium.CheckedChanged += rbPremium_CheckedChanged;
            // 
            // cbEquipajeMano
            // 
            cbEquipajeMano.AutoSize = true;
            cbEquipajeMano.Location = new Point(145, 268);
            cbEquipajeMano.Name = "cbEquipajeMano";
            cbEquipajeMano.Size = new Size(122, 19);
            cbEquipajeMano.TabIndex = 16;
            cbEquipajeMano.Text = "Equipaje De Mano";
            cbEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 17;
            label6.Text = "Equipaje de mano:";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Location = new Point(12, 304);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(183, 15);
            labelPeso.TabIndex = 18;
            labelPeso.Text = "Equipaje de Bodega, poner en kg:";
            // 
            // txtPesoBodegaTurista
            // 
            txtPesoBodegaTurista.Location = new Point(201, 301);
            txtPesoBodegaTurista.Name = "txtPesoBodegaTurista";
            txtPesoBodegaTurista.Size = new Size(168, 23);
            txtPesoBodegaTurista.TabIndex = 19;
            // 
            // txtPesoBodega1
            // 
            txtPesoBodega1.Location = new Point(12, 337);
            txtPesoBodega1.Name = "txtPesoBodega1";
            txtPesoBodega1.Size = new Size(168, 23);
            txtPesoBodega1.TabIndex = 20;
            // 
            // txtPesoBodega2
            // 
            txtPesoBodega2.Location = new Point(201, 337);
            txtPesoBodega2.Name = "txtPesoBodega2";
            txtPesoBodega2.Size = new Size(168, 23);
            txtPesoBodega2.TabIndex = 21;
            // 
            // FrmAltaPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 489);
            Controls.Add(txtPesoBodega2);
            Controls.Add(txtPesoBodega1);
            Controls.Add(txtPesoBodegaTurista);
            Controls.Add(labelPeso);
            Controls.Add(label6);
            Controls.Add(cbEquipajeMano);
            Controls.Add(rbPremium);
            Controls.Add(label4);
            Controls.Add(rbTurista);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaPasajeros";
            Text = "FrmPrincipal";
            Load += FrmAltaPasajeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaNacimiento;
        private RadioButton rbTurista;
        private Label label4;
        private RadioButton rbPremium;
        private CheckBox cbEquipajeMano;
        private Label label6;
        private Label labelPeso;
        private TextBox txtPesoBodegaTurista;
        private TextBox txtPesoBodega1;
        private TextBox txtPesoBodega2;
    }
}