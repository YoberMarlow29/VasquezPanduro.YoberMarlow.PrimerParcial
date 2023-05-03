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
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
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
        public Usuario() : base("", "",0,ESexo.NoCargado)
        {
            this.correo = "";
            this.clave = "";
        }
        public Usuario(string nombre, string apellido,int edad,ESexo sexo, int legajo, string correo, string clave, string perfil): base(nombre, apellido,edad,sexo)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;             
        }
        public static bool operator ==(Usuario t1, Usuario t2)
        {
            bool rta = false;
            if (t1 is not null && t2 is not null)
            {
                if (t1.correo == t2.correo && t1.clave == t2.clave)
                {
                    rta = true;
                }
            }
            else
            {
                if (t1 is null && t2 is null)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Usuario t1, Usuario t2)
        {
            return !(t1 == t2);
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

        public override int GetHashCode()
        {
            return this.edad.GetHashCode();
        }

    }
}