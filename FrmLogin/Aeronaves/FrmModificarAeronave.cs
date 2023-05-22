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
            aeronaveModificar=new Aeronave();
            this.aeronaveModificar=modificarAeronave;
        }

        private void FrmModificarAeronave_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = aeronaveModificar.Matricula;
            cboAsientos.Text = aeronaveModificar.CantidadAsientos.ToString();
            txtCantidadDeBaños.Text = aeronaveModificar.CantidadBaños.ToString();
            txtCapacidadBodega.Text = aeronaveModificar.CapacidadBodega.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidadBanios;
            int cantidadAsientos;
            double capacidadBodega;
            int.TryParse(this.txtCantidadDeBaños.Text, out cantidadBanios);
            int.TryParse(cboAsientos.SelectedItem.ToString(), out cantidadAsientos);
            double.TryParse(this.txtCapacidadBodega.Text, out capacidadBodega);       
            txtMatricula.Text = txtMatricula.Text;
            cboAsientos.SelectedItem = cantidadAsientos.ToString();
            txtCantidadDeBaños.Text = cantidadBanios.ToString();
            txtCapacidadBodega.Text = capacidadBodega.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
