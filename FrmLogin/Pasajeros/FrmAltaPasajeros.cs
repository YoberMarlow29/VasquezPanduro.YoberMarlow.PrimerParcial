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
            /*string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad;
            int dni;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 1 || edad > 100)
            {
                labelError.Text = $"Ingresar una edad valida";
                labelError.Visible = true;
                return;
            }
            if (!int.TryParse(txtDni.Text, out dni) || dni < 1 || dni > 99999999)
            {
                labelError.Text = $"Ingresar un dni valido";
                labelError.Visible = true;
                return;
            }


            this.nuevoPasajero = new Pasajero(nombre, apellido, edad, dni);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";

            DialogResult = DialogResult.OK;
            this.Close();*/

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
