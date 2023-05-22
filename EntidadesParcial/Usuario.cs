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
        private string correo;
        private string clave;
        private int legajo;
        private string perfil;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public Usuario() : base()
        {
            this.correo = "";
            this.clave = "";
        }

        public Usuario(string correo, string clave):this()
        {
            this.correo = correo;
            this.clave = clave;
        }

        public Usuario(string nombre, string apellido, int legajo, string correo, string clave, string perfil) : base(nombre, apellido)
        {
            this.correo = correo;
            this.clave = clave;
            this.legajo = legajo;
            this.perfil = perfil;
        }
        public override int CalcularAntiguedad() 
        {
            return 0;
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
    }
}