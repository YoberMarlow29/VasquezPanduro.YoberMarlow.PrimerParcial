using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using Newtonsoft.Json;
using System;
using EntidadesParcial;


namespace FRMVIAJES
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            foreach (Usuario item in Archivos.usuarios)
            {
                if (item.Correo == txtCorreo.Text && item.VerificarContrasenia(txtContraseña.Text))
                {
                    correcto = 1;
                    gpbIngresarDatos.Visible = false;
                    switch (item.Perfil)
                    {
                        case "vendedor":
                            menuStrip1.Items[2].BackColor = Color.White;
                            menuStrip1.Items[2].Enabled = false;
                            menuStrip1.Items[3].BackColor = Color.White;
                            menuStrip1.Items[3].Enabled = false;

                            break;
                        case "supervisor":
                            menuStrip1.Items[1].BackColor = Color.White;
                            menuStrip1.Items[1].Enabled = false;
                            menuStrip1.Items[3].BackColor = Color.White;
                            menuStrip1.Items[3].Enabled = false;

                            break;
                        case "administrador":
                            menuStrip1.Items[1].BackColor = Color.White;
                            menuStrip1.Items[1].Enabled = false;
                            menuStrip1.Items[2].BackColor = Color.White;
                            menuStrip1.Items[2].Enabled = false;
                            break;

                    }
                }
            }
            if (correcto == 0)
            {
                MessageBox.Show("datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbIngresarDatos.Visible = true;
        }

        private void aBMVIAJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVuelos frm = new FrmVuelos();
            frm.ShowDialog();
        }

        private void aBMAERONAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAeronave frm = new FrmAeronave();
            frm.ShowDialog();
        }
    }

}