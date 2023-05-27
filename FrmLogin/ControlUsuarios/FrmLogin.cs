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
    public partial class FrmLogin : Form
    {
        private bool mostrarContraseña = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            foreach (Usuario item in Archivos.listaDeUsuarios)
            {
                if (item.correo == txtCorreo.Text && item.clave == txtClave.Text)
                {
                    correcto = 1;
                    switch (item.perfil)
                    {
                        case "vendedor":
                            FrmMenu menuVendedor = new FrmMenu();
                            menuVendedor.PerfilVendedor();
                            menuVendedor.NombreUsuario = item.nombre;
                            menuVendedor.PerfilUsuario = item.perfil;
                            menuVendedor.ShowDialog();
                            this.Close();

                            break;
                        case "supervisor":
                            FrmMenu menuSupervisor = new FrmMenu();
                            menuSupervisor.PerfilSupervisor();
                            menuSupervisor.NombreUsuario = item.nombre;
                            menuSupervisor.PerfilUsuario = item.perfil;
                            menuSupervisor.ShowDialog();
                            this.Close();
                            break;
                        case "administrador":
                            FrmMenu menuAdministrador = new FrmMenu();
                            menuAdministrador.PerfilAdministrador();
                            menuAdministrador.NombreUsuario = item.nombre;
                            menuAdministrador.PerfilUsuario = item.perfil;
                            menuAdministrador.ShowDialog();
                            this.Close();
                            break;
                    }
                }
            }
            if (correcto == 0)
            {
                MessageBox.Show("correo o contraseña erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            mostrarContraseña = !mostrarContraseña;

            if (mostrarContraseña)
            {
                txtClave.PasswordChar = '\0'; // Mostrar texto plano
            }
            else
            {
                txtClave.PasswordChar = '*'; // Mostrar asteriscos
            }
        }

    }
}
