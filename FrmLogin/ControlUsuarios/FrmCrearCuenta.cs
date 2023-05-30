using EntidadesParcial;
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
    public partial class FrmCrearCuenta : Form
    {
        private Usuario nuevoUsuario;
        public Usuario NuevoUsuario
        {
            get { return nuevoUsuario; }
            set { nuevoUsuario = value; }
        }
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }
        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                int legajo;
                int.TryParse(this.txtLegajo.Text, out legajo);
                this.nuevoUsuario = new Usuario(txtApellido.Text, txtNombre.Text, legajo, txtCorreo.Text, txtClave.Text, txtPerfil.Text);
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtLegajo.Text = "";
                txtCorreo.Text = "";
                txtClave.Text = "";
                txtPerfil.Text = "";
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
            this.Close();

        }
    }
}
