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
        private void FrmPasajeros_Load(object sender, EventArgs e)
        {
            UpdateDataGrid(dataGridPasajeros);
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar el pasajero {dataGridPasajeros.CurrentRow.DataBoundItem}?{Environment.NewLine} Esta accion es inrreversible", "Dar Baja Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Compañia.BajaDePasajero((Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroSeleccionado = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

            FrmModificarPasajeros frmModificar = new FrmModificarPasajeros(pasajeroSeleccionado);
            DialogResult respuesta = frmModificar.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Pasajero nuevoPasajero = frmModificar.ModificarPasajero;

                int index = Archivos.listaDePasajeros.IndexOf(pasajeroSeleccionado);
                Archivos.listaDePasajeros[index] = nuevoPasajero;

                UpdateDataGrid(dataGridPasajeros);
            }

            Archivos.SerializarListaXml<Pasajero>(Archivos.listaDePasajeros, Archivos.pathPasajeros);
        }
    }
}
