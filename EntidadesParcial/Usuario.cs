using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace EntidadesParcial
{
    /// <summary>
    /// Clase que representa a un usuario, hereda de la clase Persona.
    /// </summary>
    public class Usuario : Persona
    {
        private string corre;
        private string clav;
        private int legaj;
        private string perfi;

        /// <summary>
        /// Legajo del usuario.
        /// </summary>
        public int legajo
        {
            get { return legaj; }
            set { legaj = value; }
        }

        /// <summary>
        /// Correo electrónico del usuario.
        /// </summary>
        public string correo
        {
            get { return corre; }
            set { corre = value; }
        }

        /// <summary>
        /// Clave del usuario.
        /// </summary>
        public string clave
        {
            get { return clav; }
            set { clav = value; }
        }

        /// <summary>
        /// Perfil del usuario.
        /// </summary>
        public string perfil
        {
            get { return perfi; }
            set { perfi = value; }
        }

        /// <summary>
        /// Constructor de la clase Usuario que recibe los datos del usuario.
        /// </summary>
        /// <param name="apellido">El apellido del usuario.</param>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="legajo">El legajo del usuario.</param>
        /// <param name="correo">El correo electrónico del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        /// <param name="perfil">El perfil del usuario.</param>
        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil) : base(apellido, nombre)
        {
            ValidarCampoEmail(correo, out this.corre);
            ValidarContrasenia(clave, out this.clav);
            ValidarNumeroEntero(legajo, out this.legaj);
            ValidarPerfil(perfil, out this.perfi);
        }

        /// <summary>
        /// Sobrescritura del operador de igualdad (==) para comparar dos usuarios.
        /// </summary>
        /// <param name="u1">El primer usuario a comparar.</param>
        /// <param name="u2">El segundo usuario a comparar.</param>
        /// <returns>true si los usuarios son iguales; false en caso contrario.</returns>
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1 is not null && u2 is not null && u1.correo == u2.correo && u1.clave == u2.clave;
        }

        /// <summary>
        /// Sobrescritura del operador de desigualdad (!=) para comparar dos usuarios.
        /// </summary>
        /// <param name="u1">El primer usuario a comparar.</param>
        /// <param name="u2">El segundo usuario a comparar.</param>
        /// <returns>true si los usuarios no son iguales; false en caso contrario.</returns>
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        /// <summary>
        /// Sobrescritura del método Equals para comparar un objeto con un usuario.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si el objeto es igual al usuario; false en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Usuario)
            {
                if (this == (Usuario)obj)
                {
                    ok = true;
                }
            }
            return ok;
        }

        /// <summary>
        /// Sobrescritura del método GetHashCode para obtener el código hash del usuario.
        /// </summary>
        /// <returns>El código hash del usuario.</returns>
        public override int GetHashCode()
        {
            return this.Dni;
        }

        /// <summary>
        /// Verifica si la contraseña actual coincide con la contraseña del usuario.
        /// </summary>
        /// <param name="contraseniaActual">La contraseña actual a verificar.</param>
        /// <returns>true si la contraseña actual coincide; false en caso contrario.</returns>
        public bool VerificarContrasenia(string contraseniaActual)
        {
            if (contraseniaActual == this.clave)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida el perfil del usuario.
        /// </summary>
        /// <param name="perfil">El perfil a validar.</param>
        /// <param name="perfilValidado">Variable de salida que contiene el perfil validado.</param>
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

        /// <summary>
        /// Valida el campo de correo electrónico del usuario.
        /// </summary>
        /// <param name="email">El correo electrónico a validar.</param>
        /// <param name="emailValidado">Variable de salida que contiene el correo electrónico validado.</param>
        private void ValidarCampoEmail(string email, out string emailValidado)
        {
            emailValidado = string.Empty;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new Exception("No es un email válido.");
            }
            emailValidado = email;
        }

        /// <summary>
        /// Valida la contraseña del usuario.
        /// </summary>
        /// <param name="contraseniaAValidar">La contraseña a validar.</param>
        /// <param name="contraseniaValidado">Variable de salida que contiene la contraseña validada.</param>
        private void ValidarContrasenia(string contraseniaAValidar, out string contraseniaValidado)
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

        /// <summary>
        /// Valida un número entero.
        /// </summary>
        /// <param name="numero">El número a validar.</param>
        /// <param name="numeroValidado">Variable de salida que contiene el número entero validado.</param>
        private  void ValidarNumeroEntero(object numero, out int numeroValidado)
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