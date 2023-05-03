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
        protected ESexo genero;

        protected Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.genero = ESexo.NoCargado;

        }
        protected Persona(string nombre, string apellido,int edad, ESexo genero) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            cadena.AppendLine($"El genero es: {this.genero} ");
            cadena.AppendLine($"La edad es: {this.edad} ");
            return cadena.ToString();
        }

    }
}