namespace FRMVIAJES
{
    partial class FrmPasajeros
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dataGridPasajeros = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(12, 526);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "ALTA";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.Location = new Point(174, 526);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(93, 526);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "BAJA";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridPasajeros
            // 
            dataGridPasajeros.AllowUserToAddRows = false;
            dataGridPasajeros.AllowUserToDeleteRows = false;
            dataGridPasajeros.AllowUserToResizeRows = false;
            dataGridPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasajeros.EnableHeadersVisualStyles = false;
            dataGridPasajeros.Location = new Point(12, 41);
            dataGridPasajeros.MultiSelect = false;
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersVisible = false;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new Size(910, 479);
            dataGridPasajeros.TabIndex = 9;
            dataGridPasajeros.TabStop = false;
            dataGridPasajeros.VirtualMode = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Location = new Point(895, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(27, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "x";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(934, 561);
            Controls.Add(btnSalir);
            Controls.Add(dataGridPasajeros);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPasajeros";
            Opacity = 0.95D;
            Text = "FrmCliente";
            Load += FrmPasajeros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dataGridPasajeros;
        private Button btnSalir;
    }
}