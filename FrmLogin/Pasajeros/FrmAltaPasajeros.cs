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
        private void FrmAltaPasajeros_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni;
                int edad;
                int.TryParse(this.txtDni.Text, out dni);
                int.TryParse(this.txtEdad.Text, out edad);
                this.nuevoPasajero = new Pasajero(txtNombre.Text, txtApellido.Text, edad, dni);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDni.Text = "";

                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                this.labelError.Text = $"       {ex.Message}";
                this.labelError.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }





    }
}
