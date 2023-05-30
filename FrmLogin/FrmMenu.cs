using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMVIAJES
{
    public partial class FrmMenu : Form
    {
        private string nombreUsuario;
        private string perfilUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set
            {
                nombreUsuario = value;
                lblNombreUsuario.Text = value;
            }
        }

        public string PerfilUsuario
        {
            get { return perfilUsuario; }
            set
            {
                perfilUsuario = value;
                lblPerfilUsuario.Text = value;
            }
        }
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void btnAeronaves_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAeronave());
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPasajeros());
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmVuelos());

        }
        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje frm = new FrmVentaPasaje();
            frm.ShowDialog();
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEstadisticas());
        }

        private Form activarForm = null;
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        public void PerfilVendedor()
        {
            btnVenderPasaje.Enabled = true;
            btnEstadisticas.Enabled = true;
            btnPasajeros.Enabled = true;
            btnVuelos.Enabled = false;
            btnAeronaves.Enabled = false;
            btnVuelos.BackColor = Color.LightGray;
            btnAeronaves.BackColor = Color.LightGray;
        }

        public void PerfilSupervisor()
        {
            btnVenderPasaje.Enabled = false;
            btnEstadisticas.Enabled = true;
            btnPasajeros.Enabled = true;
            btnVuelos.Enabled = false;
            btnAeronaves.Enabled = false;
            btnVenderPasaje.BackColor = Color.LightGray;
            btnAeronaves.BackColor = Color.LightGray;
        }

        public void PerfilAdministrador()
        {
            btnVenderPasaje.Enabled = true;
            btnEstadisticas.Enabled = true;
            btnPasajeros.Enabled = true;
            btnVuelos.Enabled = true;
            btnAeronaves.Enabled = true;
            /*btnVenderPasaje.BackColor = Color.LightGray;
            btnEstadisticas.BackColor = Color.LightGray;
            btnPasajeros.BackColor = Color.LightGray;*/
        }
    }
}
