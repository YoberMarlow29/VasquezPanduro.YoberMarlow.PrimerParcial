using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Persona
    {
        protected string nom;
        protected string apell;
        protected int edad;
        protected int dni;

        public string apellido
        {
            get { return apell; }
            set { apell = value; }
        }
        public string nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        protected Persona()
        {

        }
        protected Persona(string apellido, string nombre) :this()
        {
            ValidarCampoString(apellido, out this.apell);
            ValidarCampoString(nombre, out this.nom);
        }
        protected Persona(string nombre, string apellido, int edad, int dni) : this(nombre,apellido)
        {   
            ValidarCampoEdad(edad, out this.edad);
            ValidarCampoDni(dni, out this.dni);
        }
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            cadena.AppendLine($"El dni es: {this.dni}");
            cadena.AppendLine($"edad: {this.edad}");
            return cadena.ToString();
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1 is not null && p2 is not null && p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Persona)
            {
                if (this == ((Persona)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
        public override int GetHashCode()
        {
            return this.dni;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        private void ValidarCampoString(string campo, out string campoValidado)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Ingresar un valor valido.");
            }
            campoValidado = campo;
        }
        private void ValidarCampoDni(int dni, out int dniValidado)
        {
            dniValidado = -1;
            if (dni < 1000000 || dni > 99999999)
            {
                throw new Exception("No es un dni valido.");
            }
            dniValidado = dni;
        }
        private void ValidarCampoEdad(int edad, out int edadValido)
        {
            edadValido = -1;
            if (edad<=1 && edad>120)
            {
                throw new Exception("No es una edad valida.");
            }
            edadValido = edad;
        }       
    }
}