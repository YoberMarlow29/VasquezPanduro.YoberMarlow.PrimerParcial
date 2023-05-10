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
        protected DateTime fechaDeNacimiento;
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

        public DateTime Nacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public int Edad
        {
            get { return CalcularEdad(fechaDeNacimiento); }
        }
        protected Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.fechaDeNacimiento = DateTime.Now;
            this.dni = 0;

        }

        protected Persona(string nombre, string apellido, DateTime fechaDeNacimiento, int dni) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento.ToUniversalTime();
            this.dni = dni;
            
        }
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            cadena.AppendLine($"El dni es: {this.dni}");
            cadena.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            return cadena.ToString();
        }
        private static int CalcularEdad(DateTime nacimiento)
        {
            int edad;
            edad = DateTime.Now.Year - nacimiento.Year;
            if (nacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
        public abstract int CalcularAntiguedad();
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1 is not null && p2 is not null && p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            Persona p = obj as Persona;
            return p is not null && this == p;
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