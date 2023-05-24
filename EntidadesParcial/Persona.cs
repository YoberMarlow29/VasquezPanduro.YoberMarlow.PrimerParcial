using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected int dni;

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

        protected Persona(string nombre, string apellido) :this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        protected Persona(string nombre, string apellido, int edad, int dni) : this(nombre,apellido)
        {
            this.edad = edad;
            this.dni = dni;        
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

    }
}