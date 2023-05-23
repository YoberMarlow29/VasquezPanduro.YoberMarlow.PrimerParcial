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
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(11, 540);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "ALTA";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(173, 540);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(92, 540);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "BAJA";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridPasajeros
            // 
            dataGridPasajeros.AllowUserToAddRows = false;
            dataGridPasajeros.AllowUserToDeleteRows = false;
            dataGridPasajeros.AllowUserToResizeRows = false;
            dataGridPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasajeros.EnableHeadersVisualStyles = false;
            dataGridPasajeros.Location = new Point(12, 12);
            dataGridPasajeros.MultiSelect = false;
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersVisible = false;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new Size(1600, 522);
            dataGridPasajeros.TabIndex = 9;
            dataGridPasajeros.TabStop = false;
            dataGridPasajeros.VirtualMode = true;
            // 
            // FrmPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 575);
            Controls.Add(dataGridPasajeros);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmPasajeros";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dataGridPasajeros;
    }
}