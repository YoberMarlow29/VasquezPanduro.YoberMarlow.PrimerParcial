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
    public partial class FrmModificarVuelo : Form
    {
        public Vuelo vueloModificar;
        private bool fechaCambio;
        public Vuelo VueloModificar
        {
            get { return vueloModificar; }
            set { vueloModificar = value; }
        }
        public FrmModificarVuelo(Vuelo modificarVuelo)
        {
            InitializeComponent();
            vueloModificar = new Vuelo();
            vueloModificar = modificarVuelo;
            fechaCambio = false;
        }

        private void FrmModificarVuelo_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            cboOrigen.Text = vueloModificar.Origen;
            cboDestino.Text = vueloModificar.Destino;
            cboAeronave.Text = vueloModificar.Aeronave.Matricula;
            dtpFechaPartida.Value = vueloModificar.Partida;
            cbServicioWifi.Checked = vueloModificar.ServicioWifi;
            cbServicioComida.Checked = vueloModificar.ServicioComida;
            // Cargar las localidades y aeronaves en los ComboBox
            foreach (string item in Archivos.localidades)
            {
                cboOrigen.Items.Add(item);
                cboDestino.Items.Add(item);
            }
            foreach (Aeronave item in Archivos.listaDeAeronaves)
            {
                cboAeronave.Items.Add(item.Matricula);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarIngresosDeLosControles())
            {
                Aeronave aeronave = Compañia.BuscarAeronavePorMatricula(cboAeronave.Text);
                if (aeronave is not null)
                {
                    try
                    {
                        if (dtpFechaPartida.Value < DateTime.Now)
                        {
                            this.labelError.Text = $"       La Partida del vuelo no es valida.";
                            this.labelError.Visible = true;
                        }
                        else
                        {
                            vueloModificar.Origen = cboOrigen.Text;
                            vueloModificar.Destino = cboDestino.Text;
                            vueloModificar.Aeronave = aeronave;
                            vueloModificar.Partida = dtpFechaPartida.Value;
                            vueloModificar.ServicioWifi = cbServicioWifi.Checked;
                            vueloModificar.ServicioComida = cbServicioComida.Checked;

                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        this.labelError.Text = $"       {ex.Message}";
                        this.labelError.Visible = true;
                    }
                }
            }
        }
        private bool VerificarIngresosDeLosControles()
        {
            if (string.IsNullOrEmpty(cboOrigen.Text) || string.IsNullOrEmpty(cboDestino.Text) ||
                string.IsNullOrEmpty(cboAeronave.Text) || !fechaCambio)
            {
                labelError.Text = "       Datos Incompletos";
                labelError.Visible = true;
                return false;
            }

            if (cboOrigen.Text == cboDestino.Text)
            {
                labelError.Text = "       Destino y Origen no pueden ser iguales";
                labelError.Visible = true;
                return false;
            }

            return true;
        }

        private void dtpFechaPartida_ValueChanged(object sender, EventArgs e)
        {
            fechaCambio = true;
        }
    }
}
