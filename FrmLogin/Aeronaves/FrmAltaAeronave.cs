using EntidadesParcial;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMVIAJES
{
    public partial class FrmAltaAeronave : Form
    {
        private Aeronave nuevaAeronave;


        public Aeronave NuevaAeronave
        {
            get { return nuevaAeronave; }
            set { nuevaAeronave = value; }
        }
        public FrmAltaAeronave()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidadBanios;
            int cantidadAsientos;
            double capacidadBodega;

            if (!ValidarInt(txtCantidadDeBaños.Text, out cantidadBanios, 1, 10))
                return;

            if (!ValidarInt(txtCantidadAsientos.Text, out cantidadAsientos, 1, 600))
                return;

            if (!ValidarDouble(txtCapacidadBodega.Text, out capacidadBodega, 1, 10000))
                return;

            this.nuevaAeronave = new Aeronave(this.txtMatricula.Text, cantidadAsientos, cantidadBanios, capacidadBodega);
            txtMatricula.Text = "";
            txtCantidadAsientos.Text = "";
            txtCantidadDeBaños.Text = "";
            txtCapacidadBodega.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGenerarMatricula_Click(object sender, EventArgs e)
        {
            // Generar la matrícula
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int longitudMatricula = 8;

            Random random = new Random();
            string matricula = new string(Enumerable.Repeat(caracteresPermitidos, longitudMatricula)
                                      .Select(s => s[random.Next(s.Length)]).ToArray());

            txtMatricula.Text = matricula;

        }
        private bool ValidarInt(string inputText, out int value, int minValue, int maxValue)
        {
            if (!int.TryParse(inputText, out value) || value < minValue || value > maxValue)
            {
                MessageBox.Show($"Ingrese un valor válido para el campo (entre {minValue} y {maxValue}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarDouble(string inputText, out double value, double minValue, double maxValue)
        {
            if (!double.TryParse(inputText, out value) || value < minValue || value > maxValue)
            {
                MessageBox.Show($"Ingrese un valor válido para el campo (entre {minValue} y {maxValue}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
