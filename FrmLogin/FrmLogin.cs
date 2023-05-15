using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using Newtonsoft.Json;
using System;
using EntidadesParcial;


namespace FRMVIAJES
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        private int bandera = 0;
        private Archivos archivos;
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
            this.archivos = new Archivos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "MOCK_DATA.json";
            this.usuarios = this.archivos.DeserializarLista<Usuario>(path);

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            int correcto = 0;
            if (Validar())
            {

                Usuario aux = new Usuario(txtCorreo.Text, txtContraseña.Text);
                foreach (Usuario item in this.usuarios)
                {
                    if (item.Equals(aux))
                    {
                        correcto = 1;
                        this.bandera = 1;
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
        }
        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Correo");
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Contraseña");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
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