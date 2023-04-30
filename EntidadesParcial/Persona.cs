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

        protected Persona()
        {
            this.nombre = "";
            this.apellido = "";

        }
        protected Persona(string nombre, string apellido) : this()
        {
            if (nombre is not null && apellido is not null)
            {
                this.nombre = nombre;
                this.apellido = apellido;
            }
        }
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            return cadena.ToString();
        }

    }
}
