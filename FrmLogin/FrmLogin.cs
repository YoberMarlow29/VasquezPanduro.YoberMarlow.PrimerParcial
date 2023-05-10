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
        private int bandera = 0;
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "MOCK_DATA.json";
            this.usuarios = this.DeserializarUsuarios(path);

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
                        this.Visible = false;
                        FrmCliente frm = new FrmCliente();  // consultar por 
                        frm.ShowDialog();
                        this.Close();
                    }

                }
                if (correcto == 0)
                {
                    MessageBox.Show("datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<Usuario> DeserializarUsuarios(string path)
        {

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
    }

}