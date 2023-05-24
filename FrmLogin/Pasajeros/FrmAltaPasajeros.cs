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
            int edad;
            int dni;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 1 || edad > 100)
            {
                MessageBox.Show("Debe ingresar un número de edad válido entre 1 y 100.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtDni.Text, out dni) || dni < 1 || dni > 99999999)
            {
                MessageBox.Show("Debe ingresar un número de DNI válido entre 1 y 99999999.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.nuevoPasajero = new Pasajero(nombre, apellido, edad, dni);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaPasajeros_Load(object sender, EventArgs e)
        {

        }



    }
}
