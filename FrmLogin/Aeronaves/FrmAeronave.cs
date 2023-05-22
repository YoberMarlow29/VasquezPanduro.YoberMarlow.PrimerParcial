using EntidadesParcial;
using Newtonsoft.Json;
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
    public partial class FrmAeronave : Form
    {
        public FrmAeronave()
        {
            InitializeComponent();
        }
        private void FrmAeronave_Load(object sender, EventArgs e)
        {
            UpdateDataGrid(dataGridAeronaves);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaAeronave frm = new FrmAltaAeronave();
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Aeronave nuevaAeronave = frm.NuevaAeronave;
                //Archivos.listaDeAeronaves.Add(nuevaAeronave);
                Compañia.AltaDeAeronave(nuevaAeronave);
                UpdateDataGrid(dataGridAeronaves);
            }
            Archivos.SerializarListaJson(Archivos.listaDeAeronaves, Archivos.pathAeronaves);

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            FrmModificarAeronave frmModificar = new FrmModificarAeronave((Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem);
            DialogResult respuesta = frmModificar.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Aeronave nuevaAeronave = frmModificar.AeronaveModificar;
                Compañia.ModificarAeronave(nuevaAeronave);
                UpdateDataGrid(dataGridAeronaves);               
            }
            Archivos.SerializarListaJson(Archivos.listaDeAeronaves, Archivos.pathAeronaves);

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar la Aeronave {dataGridAeronaves.CurrentRow.DataBoundItem}?{Environment.NewLine} Esta accion es inrreversible", "Dar Baja Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Compañia.BajaDeAeronave((Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem);
                UpdateDataGrid(dataGridAeronaves);
            }
            Archivos.SerializarListaJson(Archivos.listaDeAeronaves, Archivos.pathAeronaves);
        }
        public void UpdateDataGrid(DataGridView dataGridAeronave)
        {
            if (Archivos.listaDeAeronaves.Count > 0)
            {
                dataGridAeronave.DataSource = null;
                dataGridAeronave.DataSource = Archivos.listaDeAeronaves;
                dataGridAeronave.Visible = true;
            }
            else
            {
                dataGridAeronave.Visible = false;
            }
        }


    }
}
