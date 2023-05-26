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
    public partial class FrmAltaVuelo : Form
    {
        private Vuelo nuevoViaje;
        private bool fechaCambio;

        public Vuelo NuevoViaje
        {
            get { return nuevoViaje; }
            set { nuevoViaje = value; }
        }
        public FrmAltaVuelo()
        {
            InitializeComponent();
            this.fechaCambio = false;
        }
        private void FrmAltaVuelo_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
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
                            this.nuevoViaje = new Vuelo(aeronave, cboOrigen.Text, cboDestino.Text, dtpFechaPartida.Value, cbServicioWifi.Checked,cbServicioComida.Checked);
                            this.DialogResult = DialogResult.OK;
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
            labelError.Visible = false;
            if (String.IsNullOrEmpty(cboOrigen.Text) || String.IsNullOrEmpty(cboDestino.Text) || String.IsNullOrEmpty(cboAeronave.Text) || !this.fechaCambio)
            {
                labelError.Text = "       Datos Incompletos";
                labelError.Visible = true;
                return false;
            }
            else if (cboOrigen.Text == cboDestino.Text)
            {
                labelError.Text = "       Destino y Origen no pueden ser iguales";
                labelError.Visible = true;
                return false;
            }
            return true;
        }

        private void dtpFechaPartida_ValueChanged(object sender, EventArgs e)
        {
            this.fechaCambio = true;
        }
    }
}
