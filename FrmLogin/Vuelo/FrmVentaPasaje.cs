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
    public partial class FrmVentaPasaje : Form
    {
        Pasaje NuevoPasaje { get; set; }
        Pasajero Pasajero { get; set; }
        Vuelo Vuelo { get; set; }
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }
        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = false;
            labelPeso.Visible = false;
            txtPesoBodega1.Visible = false;
            txtPesoBodega2.Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni;
            int.TryParse(this.txtBuscarPasajero.Text, out dni);
            foreach (Pasajero item in Compañia.DevolverLista())
            {
                if (item.Dni == dni)
                {
                    Pasajero = item;
                    break;
                }
            }
            NuevoPasaje = new Pasaje();
            NuevoPasaje.Pasajero = Pasajero;
            int idVuelo;
            int.TryParse(this.txtBuscarVuelo.Text, out idVuelo);
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                if (item.IdVuelo == idVuelo)
                {
                    Vuelo = item;

                    break;
                }
            }
            NuevoPasaje = new Pasaje();
            NuevoPasaje.Pasajero = Pasajero;
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            ClasePasajero clase = rbTurista.Checked ? ClasePasajero.Turista : ClasePasajero.Premium;
            bool equipajeDeMano = cbEquipajeMano.Checked;
            double pesoBodega1 = 0.0;
            double pesoBodega2 = 0.0;


            if (clase == ClasePasajero.Turista)
            {
                double pesoBodegaTurista = ParseDoubleValue(txtPesoBodegaTurista.Text);

                if (ValidatePesoBodega(pesoBodegaTurista, 0.0, 25.0))
                {
                    pesoBodega1 = pesoBodegaTurista;
                }
                else
                {
                    MessageBox.Show("El peso del equipaje de bodega debe estar entre 0 y 25 kg.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (clase == ClasePasajero.Premium)
            {
                double pesoBodegaPremium1 = ParseDoubleValue(txtPesoBodega1.Text);
                double pesoBodegaPremium2 = ParseDoubleValue(txtPesoBodega2.Text);


                if (ValidatePesoBodega(pesoBodegaPremium1, 0.0, 21.0) && ValidatePesoBodega(pesoBodegaPremium2, 0.0, 21.0))
                {
                    pesoBodega1 = pesoBodegaPremium1;
                    pesoBodega2 = pesoBodegaPremium2;
                }
                else
                {
                    MessageBox.Show("El peso de cada equipaje de bodega debe estar entre 0 y 21 kg.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            double pesoBodegaTotal = pesoBodega1 + pesoBodega2;
            txtPesoBodegaTurista.Text = "";
            txtPesoBodega1.Text = "";
            txtPesoBodega2.Text = "";

            Compañia.AltaDePasaje(NuevoPasaje);
            Archivos.SerializarListaXml<Pasaje>(Archivos.listaPasaje, Archivos.pathPasaje);


        }
        private void rbTurista_CheckedChanged(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = true;
            labelPeso.Visible = true;
            txtPesoBodega1.Visible = false;
            txtPesoBodega2.Visible = false;
        }

        private void rbPremium_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = false;
            labelPeso.Visible = Visible;
            txtPesoBodega1.Visible = true;
            txtPesoBodega2.Visible = true;
        }

        private double ParseDoubleValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0.0;
            }

            double result;
            if (double.TryParse(value, out result))
            {
                return result;
            }

            return 0.0;
        }

        private bool ValidatePesoBodega(double peso, double minValue, double maxValue)
        {
            if (peso >= minValue && peso <= maxValue)
            {
                return true;
            }

            return false;
        }

        private void ListarPasajeros(List<Pasajero> ListarPasajeros)
        {
            lstListaPasajeros.Items.Clear();
            if (ListarPasajeros.Count > 0)
            {
                foreach (Pasajero item in ListarPasajeros)
                {
                    lstListaPasajeros.Items.Add(item);
                }
            }
        }
        private void ListarVuelos(List<Vuelo> listarVuelos)
        {
            lstListaVuelos.Items.Clear();
            if (listarVuelos.Count > 0)
            {
                foreach (Vuelo item in listarVuelos)
                {
                    lstListaVuelos.Items.Add(item);
                }
            }
        }
        private void FiltrarDatosDeVuelos(List<Vuelo> filtrado)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                if (item.IdVuelo.ToString().ToUpper().StartsWith(this.txtBuscarVuelo.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.GetHashCode().ToString().ToUpper().StartsWith(this.txtBuscarVuelo.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }

        private void FiltrarDatosDeClientes(List<Pasajero> filtrado)
        {
            foreach (Pasajero item in Archivos.listaDePasajeros)
            {
                if (item.nombre.ToUpper().StartsWith(this.txtBuscarPasajero.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.apellido.ToUpper().StartsWith(this.txtBuscarPasajero.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.GetHashCode().ToString().ToUpper().StartsWith(this.txtBuscarPasajero.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
            }
        }

        private void txtBuscarPasajero_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBuscarPasajero.Text))
            {
                List<Pasajero> filtrado = new List<Pasajero>();
                FiltrarDatosDeClientes(filtrado);
                ListarPasajeros(filtrado);
            }
            else
            {
                ListarPasajeros(Archivos.listaDePasajeros);
            }
        }

        private void txtBuscarVuelo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBuscarPasajero.Text))
            {
                List<Vuelo> filtrado = new List<Vuelo>();
                FiltrarDatosDeVuelos(filtrado);
                ListarVuelos(filtrado);
            }
            else
            {
                ListarVuelos(Archivos.listaDeViaje);
            }
        }
    }
}
