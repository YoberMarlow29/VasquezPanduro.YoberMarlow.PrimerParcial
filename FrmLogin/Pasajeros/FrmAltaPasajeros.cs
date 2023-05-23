using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesParcial;

namespace FRMVIAJES
{
    public partial class FrmAltaPasajeros : Form
    {
        private Pasajero nuevoPasajero;
        public Pasajero NuevoPasajero
        {
            get { return nuevoPasajero; }
            set { nuevoPasajero = value; }
        }

        public FrmAltaPasajeros()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            int dni = Convert.ToInt32(txtDni.Text);
            ClasePasajero clase = rbTurista.Checked ? ClasePasajero.Turista : ClasePasajero.Premium;
            bool equipajeDeMano = cbEquipajeMano.Checked;

            List<double> equipajeDeBodega = new List<double>();
            if (clase == ClasePasajero.Turista)
            {
                double pesoBodega = Convert.ToDouble(txtPesoBodegaTurista.Text);
                equipajeDeBodega.Add(pesoBodega);
            }
            else if (clase == ClasePasajero.Premium)
            {
                double pesoBodega1 = Convert.ToDouble(txtPesoBodega1.Text);
                double pesoBodega2 = Convert.ToDouble(txtPesoBodega2.Text);
                double pesoBodegaTotal = pesoBodega1 + pesoBodega2;
                equipajeDeBodega.Add(pesoBodegaTotal);
                
            }

            this.nuevoPasajero = new Pasajero(nombre, apellido, fechaNacimiento, dni, clase, equipajeDeMano, equipajeDeBodega);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtPesoBodegaTurista.Text = "";
            txtPesoBodega1.Text = "";
            txtPesoBodega2.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaPasajeros_Load(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = false;
            labelPeso.Visible = false;
            txtPesoBodega1.Visible = false;
            txtPesoBodega2.Visible = false;
        }

        private void rbTurista_CheckedChanged(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = true;
            labelPeso.Visible = true;
            txtPesoBodega1.Visible = false;
            txtPesoBodega2.Visible = false;

        }

        private void rbPremium_CheckedChanged(object sender, EventArgs e)
        {
            txtPesoBodegaTurista.Visible = false;
            labelPeso.Visible = Visible;
            txtPesoBodega1.Visible = true;
            txtPesoBodega2.Visible = true;

        }
    }
}
