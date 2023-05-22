using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Sistema
    {
        public static int VerificarUsuarioContrasenia(string correo, string contrasenia)
        {
            foreach (Usuario item in Archivos.usuarios)
            {
                if (item.Correo == correo && item.VerificarContrasenia(contrasenia))
                {
                    return Archivos.usuarios.IndexOf(item);
                }
            }
            return -1;
        }
    }
}
