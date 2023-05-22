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
    public partial class FrmAltaCliente : Form
    {
        private Cliente nuevoCliente;
        public Cliente NuevoCliente
        {
            get { return nuevoCliente; }
            set { nuevoCliente = value; }
        }

        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            int.TryParse(this.txtDni.Text, out dni);
            DateTime fechaActual = DateTime.Now;
            this.nuevoCliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, this.dtpNacimiento.Value.Date, dni, fechaActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
