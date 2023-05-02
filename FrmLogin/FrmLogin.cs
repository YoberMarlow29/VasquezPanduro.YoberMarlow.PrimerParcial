using Microsoft.VisualBasic.ApplicationServices;
using EntidadesParcial;
//using System.Text.Json;
using System.Text;
using Newtonsoft.Json;
using FRMVIAJES;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrase�a = txtContrase�a.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Debe ingresar correo y contrase�a.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = usuarios.FirstOrDefault(u => u.Correo == correo && u.Clave == contrase�a);

            if (usuario == null)
            {
                MessageBox.Show("Correo o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            switch (usuario.Perfil)
            {
                case "vendedor":
                    MessageBox.Show("Inicio de sesi�n exitoso como vendedor.", "Inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    break;
                case "supervisor":

                    MessageBox.Show("Inicio de sesi�n exitoso como supervisor.", "Inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "administrador":
                    FrmPrincipal frmPrincipal3 = new FrmPrincipal();
                    frmPrincipal3.ShowDialog();
                    MessageBox.Show("Inicio de sesi�n exitoso como administrador.", "Inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Perfil de usuario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "MOCK_DATA.json";
            this.usuarios = this.DeserializarUsuarios(path);

        }
        private List<Usuario> DeserializarUsuarios(string path)
        {
            List<Usuario> usuarios = new List<Usuario>();
            if (File.Exists(path))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    using (FileStream file = File.OpenRead(path))
                    using (StreamReader reader = new StreamReader(file))
                    using (JsonTextReader jsonReader = new JsonTextReader(reader))
                    {
                        usuarios = serializer.Deserialize<List<Usuario>>(jsonReader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al deserializar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no existe o no se puede leer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usuarios;
        }
    }

}