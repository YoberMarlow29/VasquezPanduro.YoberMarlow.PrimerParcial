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
            lstListaVuelos = new ListBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(93, 428);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "BAJA";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(174, 428);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 428);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "ALTA";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstListaVuelos
            // 
            lstListaVuelos.FormattingEnabled = true;
            lstListaVuelos.ItemHeight = 15;
            lstListaVuelos.Location = new Point(12, 12);
            lstListaVuelos.Name = "lstListaVuelos";
            lstListaVuelos.Size = new Size(929, 409);
            lstListaVuelos.TabIndex = 4;
            // 
            // FrmVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 476);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstListaVuelos);
            Name = "FrmVuelos";
            Text = "FrmVuelos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ListBox lstListaVuelos;
    }
}