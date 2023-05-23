namespace FRMVIAJES
{
    partial class FrmAeronave
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
            dataGridAeronaves = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(94, 531);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "BAJA";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(175, 531);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 531);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "ALTA";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridAeronaves
            // 
            dataGridAeronaves.AllowUserToAddRows = false;
            dataGridAeronaves.AllowUserToDeleteRows = false;
            dataGridAeronaves.AllowUserToResizeRows = false;
            dataGridAeronaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAeronaves.EnableHeadersVisualStyles = false;
            dataGridAeronaves.Location = new Point(12, 12);
            dataGridAeronaves.MultiSelect = false;
            dataGridAeronaves.Name = "dataGridAeronaves";
            dataGridAeronaves.ReadOnly = true;
            dataGridAeronaves.RowHeadersVisible = false;
            dataGridAeronaves.RowTemplate.Height = 25;
            dataGridAeronaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAeronaves.Size = new Size(1341, 513);
            dataGridAeronaves.TabIndex = 8;
            dataGridAeronaves.TabStop = false;
            dataGridAeronaves.VirtualMode = true;
            // 
            // FrmAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 566);
            Controls.Add(dataGridAeronaves);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmAeronave";
            Text = "FrmAeronave";
            Load += FrmAeronave_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dataGridAeronaves;
    }
}