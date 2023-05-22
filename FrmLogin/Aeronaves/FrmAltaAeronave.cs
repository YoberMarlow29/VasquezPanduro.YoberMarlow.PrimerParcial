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
            int.TryParse(this.txtCantidadDeBaños.Text, out cantidadBanios);
            int.TryParse(cboAsientos.SelectedItem.ToString(), out cantidadAsientos);
            double.TryParse(this.txtCapacidadBodega.Text, out capacidadBodega);
            this.nuevaAeronave = new Aeronave(this.txtMatricula.Text, cantidadAsientos, cantidadBanios, capacidadBodega);
            txtMatricula.Text = "";
            txtCantidadDeBaños.Text = "";
            txtCapacidadBodega.Text = "";
            DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
