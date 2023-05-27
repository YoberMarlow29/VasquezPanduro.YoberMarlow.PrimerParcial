using EntidadesParcial;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private void FrmAltaAeronave_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadBaños;
                int cantidadAsientos;
                double capacidadBodega;
                int.TryParse(this.txtCantidadDeBaños.Text, out cantidadBaños);
                int.TryParse(this.txtCantidadAsientos.Text, out cantidadAsientos);
                double.TryParse(this.txtCapacidadBodega.Text, out capacidadBodega);
                this.nuevaAeronave = new Aeronave(this.txtMatricula.Text, cantidadAsientos, cantidadBaños, capacidadBodega);
                txtMatricula.Text = "";
                txtCantidadAsientos.Text = "";
                txtCantidadDeBaños.Text = "";
                txtCapacidadBodega.Text = "";
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                this.labelError.Text = $"       {ex.Message}";
                this.labelError.Visible = true;
            }

        }

        private void btnGenerarMatricula_Click(object sender, EventArgs e)
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int longitudMatricula = 8;

            Random random = new Random();
            string matricula = new string(Enumerable.Repeat(caracteresPermitidos, longitudMatricula)
                                      .Select(s => s[random.Next(s.Length)]).ToArray());
            txtMatricula.Text = matricula;
        }

    }
}
