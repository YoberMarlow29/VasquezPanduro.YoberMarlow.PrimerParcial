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
    public partial class FrmVuelos : Form
    {
        private Vuelo viajeNuevo;
        public FrmVuelos()
        {
            InitializeComponent();

        }
        private void FrmVuelos_Load(object sender, EventArgs e)
        {
            UpdateDataGrid(dataGridViajes);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaVuelo altaVuelo = new FrmAltaVuelo();
            DialogResult respuesta = altaVuelo.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                this.viajeNuevo = altaVuelo.NuevoViaje;
                Compañia.AltaDeVuelo(this.viajeNuevo);
                UpdateDataGrid(dataGridViajes);
            }
            Archivos.SerializarListaXml<Vuelo>(Archivos.listaDeViaje, Archivos.pathVuelo);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar el vuelo {dataGridViajes.CurrentRow.DataBoundItem}?{Environment.NewLine} Esta accion es inrreversible", "Dar Baja Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Compañia.BajaDeVuelo((Vuelo)dataGridViajes.CurrentRow.DataBoundItem);
                UpdateDataGrid(dataGridViajes);
            }
            Archivos.SerializarListaXml<Vuelo>(Archivos.listaDeViaje, Archivos.pathVuelo);
        }
        public void UpdateDataGrid(DataGridView dataGridVuelos)
        {
            if (Archivos.listaDeViaje.Count > 0)
            {
                dataGridViajes.DataSource = null;
                dataGridViajes.DataSource = Archivos.listaDeViaje;
                dataGridViajes.Visible = true;
            }
            else
            {
                dataGridViajes.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vuelo viajeSeleccionado = (Vuelo)dataGridViajes.CurrentRow.DataBoundItem;

            FrmModificarVuelo frmModificar = new FrmModificarVuelo(viajeSeleccionado);
            DialogResult respuesta = frmModificar.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Vuelo nuevoViaje = frmModificar.VueloModificar;

                int index = Archivos.listaDeViaje.IndexOf(viajeSeleccionado);
                Archivos.listaDeViaje[index] = nuevoViaje;

                UpdateDataGrid(dataGridViajes);
            }
            Archivos.SerializarListaXml<Vuelo>(Archivos.listaDeViaje, Archivos.pathVuelo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
