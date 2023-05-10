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
        private string? perfil;

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
        public string? Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public Usuario() : base("", "", DateTime.Now,0)
        {
            this.correo = "";
            this.clave = "";
        }
        public Usuario(string usuario, string contraseña) : this()
        {
                this.correo = usuario;
                this.clave = contraseña;
        }

        public Usuario(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, int legajo, string correo, string clave, string perfil):this(correo,clave)
        {
            this.legajo = legajo;
            this.perfil = perfil;             
        }
        public override int CalcularAntiguedad() 
        {
            return 0;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1 is not null && u2 is not null && u1.perfil == u2.perfil && u1.clave == u2.clave;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario is not null && this == usuario;
        }
    }
}