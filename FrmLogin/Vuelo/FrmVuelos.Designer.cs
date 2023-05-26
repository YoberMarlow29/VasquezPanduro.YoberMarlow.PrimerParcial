namespace FRMVIAJES
{
    partial class FrmVuelos
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dataGridViajes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(93, 561);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "BAJA";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(174, 561);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 561);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "ALTA";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridViajes
            // 
            dataGridViajes.AllowUserToAddRows = false;
            dataGridViajes.AllowUserToDeleteRows = false;
            dataGridViajes.AllowUserToResizeRows = false;
            dataGridViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViajes.EnableHeadersVisualStyles = false;
            dataGridViajes.Location = new Point(12, 12);
            dataGridViajes.MultiSelect = false;
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.ReadOnly = true;
            dataGridViajes.RowHeadersVisible = false;
            dataGridViajes.RowTemplate.Height = 25;
            dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViajes.Size = new Size(1319, 543);
            dataGridViajes.TabIndex = 9;
            dataGridViajes.TabStop = false;
            dataGridViajes.VirtualMode = true;
            // 
            // FrmVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 596);
            Controls.Add(dataGridViajes);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmVuelos";
            Text = "FrmVuelos";
            Load += FrmVuelos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dataGridViajes;
    }
}