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
    public partial class FrmLoginV : Form
    {
        public FrmLoginV()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*';
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            foreach (Usuario item in Archivos.usuarios)
            {
                if (item.correo == txtCorreo.Text && item.clave == txtClave.Text)
                {
                    correcto = 1;
                    switch (item.perfil)
                    {
                        case "vendedor":
                            FrmMenu menuVendedor = new FrmMenu();
                            menuVendedor.PerfilVendedor();
                            menuVendedor.Show();
                            break;
                        case "supervisor":
                            FrmMenu menuSupervisor = new FrmMenu();
                            menuSupervisor.PerfilSupervisor();
                            menuSupervisor.Show();
                            break;
                        case "administrador":
                            FrmMenu menuAdministrador = new FrmMenu();
                            menuAdministrador.PerfilAdministrador();
                            menuAdministrador.Show();
                            break;

                    }
                }
            }
            if (correcto == 0)
            {
                MessageBox.Show("correo o contraseña erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
