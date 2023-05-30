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
    public partial class FrmModificarAeronave : Form
    {
        public Aeronave aeronaveModificar;
        public Aeronave AeronaveModificar
        {
            get { return aeronaveModificar; }
            set { aeronaveModificar = value; }
        }
        public FrmModificarAeronave(Aeronave modificarAeronave)
        {
            InitializeComponent();
            aeronaveModificar = new Aeronave();
            this.aeronaveModificar = modificarAeronave;
            labelError.Visible = false;
        }

        private void FrmModificarAeronave_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = aeronaveModificar.Matricula;
            txtCantidadAsientos.Text = aeronaveModificar.CantidadAsientosTotales.ToString();
            txtCantidadDeBaños.Text = aeronaveModificar.CantidadBaños.ToString();
            txtCapacidadBodega.Text = aeronaveModificar.CapacidadBodega.ToString();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int cantidadBanios;
            int cantidadAsientos;
            double capacidadBodega;
            int.TryParse(this.txtCantidadDeBaños.Text, out cantidadBanios);
            int.TryParse(txtCantidadAsientos.Text, out cantidadAsientos);
            double.TryParse(this.txtCapacidadBodega.Text, out capacidadBodega);

            aeronaveModificar.Matricula = txtMatricula.Text;
            aeronaveModificar.CantidadAsientosTotales = cantidadAsientos;
            aeronaveModificar.CantidadBaños = cantidadBanios;
            aeronaveModificar.CapacidadBodega = capacidadBodega;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
