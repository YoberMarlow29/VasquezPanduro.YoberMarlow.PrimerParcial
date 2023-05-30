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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FRMVIAJES
{
    public partial class FrmVentaPasaje : Form
    {
        private List<Pasaje> nuevosPasajeros;
        private Vuelo vueloSeleccionado;
        public List<Pasaje> NuevosPasajeros
        {
            get => nuevosPasajeros;
            set => nuevosPasajeros = value;
        }
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
            vueloSeleccionado = new Vuelo();
            ListarPasajeros(Archivos.listaDePasajeros);
            ListarVuelos(Archivos.listaDeViaje);
            nuevosPasajeros = new List<Pasaje>();
            this.labelError.Visible = false;

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroSeleccionado = (Pasajero)lstListaPasajeros.SelectedItem;
            vueloSeleccionado = (Vuelo)lstListaVuelos.SelectedItem;
            if (pasajeroSeleccionado != null && vueloSeleccionado != null)
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
                        return;
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
                        return;
                    }
                }
                double pesoBodegaTotal = pesoBodega1 + pesoBodega2;

                Pasaje pasaje = new Pasaje(pasajeroSeleccionado, clase, equipajeDeMano, pesoBodegaTotal);
                try
                {
                    double precioFinal;
                    vueloSeleccionado.InformarTarifasYPrecioDelPasaje(pasaje, out precioFinal);

                    DialogResult result = MessageBox.Show($"El pasaje tiene un precio de: {precioFinal.ToString("0.00")} U$D. ¿Desea continuar con la venta?", "Confirmación de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Compañia.ValidarCompraDeClase(vueloSeleccionado, pasaje, this.nuevosPasajeros);
                        AgregarVuelo(pasaje);

                        vueloSeleccionado.ListaDePasajes.Add(pasaje);
                        Archivos.SerializarListaXml<Vuelo>(Archivos.listaDeViaje, Archivos.pathVuelo);

                        this.Close();
                    }

                }
                catch
                {
                    this.labelError.Text = "Error, no hay espacio";
                    this.labelError.Visible = true;
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un pasajero y un vuelo para realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (!string.IsNullOrEmpty(this.txtBuscarVuelo.Text))
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
        private void AgregarVuelo(Pasaje pasajeAgregado)
        {
            double precioFinal;
            this.nuevosPasajeros!.Add(pasajeAgregado);
            vueloSeleccionado.InformarTarifasYPrecioDelPasaje(pasajeAgregado, out precioFinal);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
