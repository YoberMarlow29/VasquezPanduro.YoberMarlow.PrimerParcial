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
        public Usuario() : base("", "")
        {
            this.correo = "";
            this.clave = "";
        }
        public Usuario(string nombre, string apellido, int legajo, string correo, string clave, string perfil): base(nombre, apellido)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

    }
}