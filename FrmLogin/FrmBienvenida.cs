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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frm = new FrmCrearCuenta();
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Usuario nuevoUsuario = frm.NuevoUsuario;
                Compañia.AltaDeUsuario(nuevoUsuario);
            }
            Archivos.SerializarListaJson(Archivos.usuarios, Archivos.pathUsuarios);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
    }
}
