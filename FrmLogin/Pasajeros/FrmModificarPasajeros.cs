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
    public partial class FrmModificarPasajeros : Form
    {
        private Pasajero modificarPasajero;
        public Pasajero ModificarPasajero
        {
            get { return modificarPasajero; }
            set { modificarPasajero = value; }
        }
        public FrmModificarPasajeros(Pasajero pasajeroModificar)
        {
            InitializeComponent();
            modificarPasajero = new Pasajero();
            this.modificarPasajero = pasajeroModificar;
        }

        private void FrmModificarPasajeros_Load(object sender, EventArgs e)
        {
            txtNombre.Text = modificarPasajero.Nombre;
            txtApellido.Text = modificarPasajero.Apellido;
            txtEdad.Text = modificarPasajero.Edad.ToString();
            txtDni.Text = modificarPasajero.Dni.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            int dni;
            int.TryParse(this.txtEdad.Text, out edad);
            int.TryParse(this.txtDni.Text, out dni);

            modificarPasajero.Nombre = txtNombre.Text;
            modificarPasajero.Apellido = txtApellido.Text;
            modificarPasajero.Edad = edad;
            modificarPasajero.Dni = dni;

            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
