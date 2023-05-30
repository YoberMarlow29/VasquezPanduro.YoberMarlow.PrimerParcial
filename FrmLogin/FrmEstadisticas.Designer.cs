namespace FRMVIAJES
{
    partial class FrmEstadisticas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbl_DestinoFavorito = new Label();
            gb_Ganacias = new GroupBox();
            lbl_Internacional = new Label();
            lbl_Cabotaje = new Label();
            lbl_GananciasTotales = new Label();
            dtg_DestinosFacturados = new DataGridView();
            dtg_Aeronaves = new DataGridView();
            lbl_EncabezaAeronaves = new Label();
            lbl_EncabezaDestinosFacturados = new Label();
            gb_Ganacias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DestinosFacturados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Aeronaves).BeginInit();
            SuspendLayout();
            // 
            // lbl_DestinoFavorito
            // 
            lbl_DestinoFavorito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_DestinoFavorito.AutoSize = true;
            lbl_DestinoFavorito.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DestinoFavorito.ForeColor = Color.White;
            lbl_DestinoFavorito.Location = new Point(161, 9);
            lbl_DestinoFavorito.Name = "lbl_DestinoFavorito";
            lbl_DestinoFavorito.Size = new Size(146, 20);
            lbl_DestinoFavorito.TabIndex = 11;
            lbl_DestinoFavorito.Text = "Destino Favorito:";
            // 
            // gb_Ganacias
            // 
            gb_Ganacias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gb_Ganacias.Controls.Add(lbl_Internacional);
            gb_Ganacias.Controls.Add(lbl_Cabotaje);
            gb_Ganacias.Controls.Add(lbl_GananciasTotales);
            gb_Ganacias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Ganacias.ForeColor = Color.White;
            gb_Ganacias.Location = new Point(161, 52);
            gb_Ganacias.Name = "gb_Ganacias";
            gb_Ganacias.Size = new Size(270, 132);
            gb_Ganacias.TabIndex = 10;
            gb_Ganacias.TabStop = false;
            gb_Ganacias.Text = "Ganacias";
            // 
            // lbl_Internacional
            // 
            lbl_Internacional.AutoSize = true;
            lbl_Internacional.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Internacional.ForeColor = Color.White;
            lbl_Internacional.Location = new Point(5, 88);
            lbl_Internacional.Name = "lbl_Internacional";
            lbl_Internacional.Size = new Size(95, 15);
            lbl_Internacional.TabIndex = 2;
            lbl_Internacional.Text = "Internacional:";
            // 
            // lbl_Cabotaje
            // 
            lbl_Cabotaje.AutoSize = true;
            lbl_Cabotaje.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cabotaje.ForeColor = Color.White;
            lbl_Cabotaje.Location = new Point(5, 60);
            lbl_Cabotaje.Name = "lbl_Cabotaje";
            lbl_Cabotaje.Size = new Size(68, 15);
            lbl_Cabotaje.TabIndex = 1;
            lbl_Cabotaje.Text = "Nacional:";
            // 
            // lbl_GananciasTotales
            // 
            lbl_GananciasTotales.AutoSize = true;
            lbl_GananciasTotales.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GananciasTotales.ForeColor = Color.White;
            lbl_GananciasTotales.Location = new Point(5, 32);
            lbl_GananciasTotales.Name = "lbl_GananciasTotales";
            lbl_GananciasTotales.Size = new Size(130, 15);
            lbl_GananciasTotales.TabIndex = 0;
            lbl_GananciasTotales.Text = "Ganancias Totales:";
            // 
            // dtg_DestinosFacturados
            // 
            dtg_DestinosFacturados.AllowUserToAddRows = false;
            dtg_DestinosFacturados.AllowUserToDeleteRows = false;
            dtg_DestinosFacturados.AllowUserToResizeRows = false;
            dtg_DestinosFacturados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtg_DestinosFacturados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DestinosFacturados.BackgroundColor = SystemColors.ControlDarkDark;
            dtg_DestinosFacturados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DestinosFacturados.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtg_DestinosFacturados.DefaultCellStyle = dataGridViewCellStyle3;
            dtg_DestinosFacturados.GridColor = SystemColors.ActiveCaptionText;
            dtg_DestinosFacturados.Location = new Point(40, 213);
            dtg_DestinosFacturados.MultiSelect = false;
            dtg_DestinosFacturados.Name = "dtg_DestinosFacturados";
            dtg_DestinosFacturados.ReadOnly = true;
            dtg_DestinosFacturados.RowHeadersVisible = false;
            dtg_DestinosFacturados.RowTemplate.Height = 25;
            dtg_DestinosFacturados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_DestinosFacturados.Size = new Size(526, 258);
            dtg_DestinosFacturados.TabIndex = 12;
            dtg_DestinosFacturados.TabStop = false;
            // 
            // dtg_Aeronaves
            // 
            dtg_Aeronaves.AllowUserToAddRows = false;
            dtg_Aeronaves.AllowUserToDeleteRows = false;
            dtg_Aeronaves.AllowUserToResizeRows = false;
            dtg_Aeronaves.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dtg_Aeronaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Aeronaves.BackgroundColor = SystemColors.ControlDarkDark;
            dtg_Aeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Aeronaves.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtg_Aeronaves.DefaultCellStyle = dataGridViewCellStyle4;
            dtg_Aeronaves.GridColor = SystemColors.ActiveCaptionText;
            dtg_Aeronaves.Location = new Point(667, 213);
            dtg_Aeronaves.MultiSelect = false;
            dtg_Aeronaves.Name = "dtg_Aeronaves";
            dtg_Aeronaves.ReadOnly = true;
            dtg_Aeronaves.RowHeadersVisible = false;
            dtg_Aeronaves.RowTemplate.Height = 25;
            dtg_Aeronaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Aeronaves.Size = new Size(216, 258);
            dtg_Aeronaves.TabIndex = 13;
            dtg_Aeronaves.TabStop = false;
            // 
            // lbl_EncabezaAeronaves
            // 
            lbl_EncabezaAeronaves.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_EncabezaAeronaves.AutoSize = true;
            lbl_EncabezaAeronaves.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EncabezaAeronaves.ForeColor = Color.White;
            lbl_EncabezaAeronaves.Location = new Point(667, 194);
            lbl_EncabezaAeronaves.Name = "lbl_EncabezaAeronaves";
            lbl_EncabezaAeronaves.Size = new Size(216, 16);
            lbl_EncabezaAeronaves.TabIndex = 14;
            lbl_EncabezaAeronaves.Text = "Horas de Vuelo de Aeronaves";
            // 
            // lbl_EncabezaDestinosFacturados
            // 
            lbl_EncabezaDestinosFacturados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_EncabezaDestinosFacturados.AutoSize = true;
            lbl_EncabezaDestinosFacturados.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EncabezaDestinosFacturados.ForeColor = Color.White;
            lbl_EncabezaDestinosFacturados.Location = new Point(161, 194);
            lbl_EncabezaDestinosFacturados.Name = "lbl_EncabezaDestinosFacturados";
            lbl_EncabezaDestinosFacturados.Size = new Size(150, 16);
            lbl_EncabezaDestinosFacturados.TabIndex = 15;
            lbl_EncabezaDestinosFacturados.Text = "Destinos Facturados";
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(918, 522);
            Controls.Add(lbl_EncabezaDestinosFacturados);
            Controls.Add(lbl_EncabezaAeronaves);
            Controls.Add(dtg_Aeronaves);
            Controls.Add(dtg_DestinosFacturados);
            Controls.Add(lbl_DestinoFavorito);
            Controls.Add(gb_Ganacias);
            MaximumSize = new Size(1234, 761);
            MinimumSize = new Size(934, 561);
            Name = "FrmEstadisticas";
            Opacity = 0.95D;
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load;
            gb_Ganacias.ResumeLayout(false);
            gb_Ganacias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DestinosFacturados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Aeronaves).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_DestinoFavorito;
        private GroupBox gb_Ganacias;
        private Label lbl_Internacional;
        private Label lbl_Cabotaje;
        private Label lbl_GananciasTotales;
        private DataGridView dtg_DestinosFacturados;
        private DataGridView dtg_Aeronaves;
        private Label lbl_EncabezaAeronaves;
        private Label lbl_EncabezaDestinosFacturados;
    }
}