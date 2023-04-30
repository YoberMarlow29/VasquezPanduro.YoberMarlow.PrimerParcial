using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class User : Persona
    {
        private string correo;
        private string contraseña;
        private int legajo;
        private string perfil;

        public string Correo 
        {
            get { return correo; }
            set { correo = value; }    
        }
        public string Contraseña 
        {
            get { return contraseña; }
            set { contraseña = value; }
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
        public User(string nombre, string apellido,int legajo, string correo, string contraseña, string perfil)
        : base(nombre, apellido)
        {
            if (correo is not null && contraseña is not null && perfil is not null) 
            {
                Legajo = legajo;
                Correo = correo;
                Contraseña = contraseña;
                Perfil = perfil;
            }

        }

    }
}
