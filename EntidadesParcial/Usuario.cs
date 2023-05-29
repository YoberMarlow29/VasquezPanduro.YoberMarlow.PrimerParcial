using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace EntidadesParcial
{
    public class Usuario : Persona
    {
        private string corr;
        private string clav;
        private int legaj;
        private string perfi;
        public int legajo
        {
            get { return legaj; }
            set { legaj = value; }
        }
        public string correo
        {
            get { return corr; }
            set { corr = value; }
        }
        public string clave
        {
            get { return clav; }
            set { clav = value; }
        }
        public string perfil
        {
            get { return perfi; }
            set { perfi = value; }
        }
        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil):base(apellido,nombre)
        {
            ValidarCampoEmail(correo, out this.corr);
            ValidarContrasenia(clave, out this.clav);
            ValidarNumeroEntero(legajo, out this.legaj);
            ValidarPerfil(perfil, out this.perfi);
        }
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1 is not null && u2 is not null && u1.correo == u2.correo && u1.clave == u2.clave;
        }
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Usuario)
            {
                if (this == ((Usuario)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
        public bool VerificarContrasenia(string contraseniaActual)
        {
            if (contraseniaActual == this.clave)
            {
                return true;
            }
            return false;
        }
        private void ValidarPerfil(string perfil, out string perfilValidado)
        {
            perfilValidado = string.Empty;

            if (perfil == "vendedor" || perfil == "supervisor" || perfil == "administrador")
            {
                perfilValidado = perfil;
            }
            else
            {
                throw new Exception("Perfil no válido. Los perfiles válidos son 'vendedor', 'supervisor' y 'administrador'.");
            }
        }
        private void ValidarCampoEmail(string email, out string emailValidado)
        {
            emailValidado = string.Empty;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new Exception("No es un email valido.");
            }
            emailValidado = email;
        }
        private  void ValidarContrasenia(string contraseniaAValidar, out string contraseniaValidado)
        {
            contraseniaValidado = string.Empty;

            if (contraseniaAValidar is null)
            {
                throw new ArgumentNullException("La contraseña no puede ser nula");
            }
            else if (contraseniaAValidar.Length < 8)
            {
                throw new FormatException("La contraseña debe tener un largo de 8 caracteres");
            }
            else
            {
                contraseniaValidado = contraseniaAValidar;
            }
        }
        private static void ValidarNumeroEntero(object numero, out int numeroValidado)
        {
            if (numero is int)
            {
                numeroValidado = (int)numero;
            }
            else if (numero is string)
            {
                if (int.TryParse((string)numero, out int parsedNumero))
                {
                    numeroValidado = parsedNumero;
                }
                else
                {
                    throw new Exception("No es un número entero válido.");
                }
            }
            else
            {
                throw new Exception("No es un número entero válido.");
            }
        }
    }
}