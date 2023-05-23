using EntidadesParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMVIAJES
{
    public partial class FrmPasajeros : Form
    {
        public FrmPasajeros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPasajeros frm = new FrmAltaPasajeros();
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Pasajero nuevoPasajero = frm.NuevoPasajero;
                Compañia.AltaDePasajeros(nuevoPasajero);
                UpdateDataGrid(dataGridPasajeros);
            }
            Archivos.SerializarListaXml<Pasajero>(Archivos.listaDePasajeros, Archivos.pathPasajeros);
        }
        public void UpdateDataGrid(DataGridView dataGridAeronave)
        {
            if (Archivos.listaDePasajeros.Count > 0)
            {
                dataGridAeronave.DataSource = null;
                dataGridAeronave.DataSource = Archivos.listaDePasajeros;
                dataGridAeronave.Visible = true;
            }
            else
            {
                dataGridAeronave.Visible = false;
            }
        }


    }
}
