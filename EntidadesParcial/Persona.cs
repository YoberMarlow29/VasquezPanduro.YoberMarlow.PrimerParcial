using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    /// <summary>
    /// Clase abstracta que representa a una persona.
    /// </summary>
    public abstract class Persona
    {
        protected string nom;
        protected string apell;
        protected int edad;
        protected int dni;

        /// <summary>
        /// Apellido de la persona.
        /// </summary>
        public string apellido
        {
            get { return apell; }
            set { apell = value; }
        }

        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        /// <summary>
        /// DNI de la persona.
        /// </summary>
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Edad de la persona.
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        /// <summary>
        /// Constructor protegido de la clase Persona.
        /// </summary>
        protected Persona()
        {

        }

        /// <summary>
        /// Constructor protegido de la clase Persona.
        /// </summary>
        /// <param name="apellido">El apellido de la persona.</param>
        /// <param name="nombre">El nombre de la persona.</param>
        protected Persona(string apellido, string nombre) : this()
        {
            ValidarCampoString(apellido, out this.apell);
            ValidarCampoString(nombre, out this.nom);
        }

        /// <summary>
        /// Constructor protegido de la clase Persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="apellido">El apellido de la persona.</param>
        /// <param name="edad">La edad de la persona.</param>
        /// <param name="dni">El DNI de la persona.</param>
        protected Persona(string nombre, string apellido, int edad, int dni) : this(nombre, apellido)
        {
            ValidarCampoEdad(edad, out this.edad);
            ValidarCampoDni(dni, out this.dni);
        }

        /// <summary>
        /// Método protegido que muestra los datos de la persona.
        /// </summary>
        /// <returns>Una cadena con los datos de la persona.</returns>
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            cadena.AppendLine($"El DNI es: {this.Dni}");
            cadena.AppendLine($"Edad: {this.Edad}");
            return cadena.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar dos objetos de tipo Persona.
        /// </summary>
        /// <param name="p1">Primer objeto de tipo Persona.</param>
        /// <param name="p2">Segundo objeto de tipo Persona.</param>
        /// <returns>true si los objetos son iguales; false en caso contrario.</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1 is not null && p2 is not null && p1.Dni == p2.Dni;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar dos objetos de tipo Persona.
        /// </summary>
        /// <param name="p1">Primer objeto de tipo Persona.</param>
        /// <param name="p2">Segundo objeto de tipo Persona.</param>
        /// <returns>true si los objetos son diferentes; false en caso contrario.</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobrescritura del método Equals para comparar dos objetos de tipo Persona.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>true si los objetos son iguales; false en caso contrario.</returns>
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

        /// <summary>
        /// Sobrescritura del método GetHashCode para obtener el código hash de la persona.
        /// </summary>
        /// <returns>El código hash de la persona.</returns>
        public override int GetHashCode()
        {
            return this.Dni;
        }

        /// <summary>
        /// Sobrescritura del método ToString para obtener una representación en cadena de la persona.
        /// </summary>
        /// <returns>Una cadena con los datos de la persona.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Método privado que valida un campo de tipo string.
        /// </summary>
        /// <param name="campo">El campo a validar.</param>
        /// <param name="campoValidado">El campo validado.</param>
        private void ValidarCampoString(string campo, out string campoValidado)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new Exception("Ingresar un valor válido.");
            }
            campoValidado = campo;
        }

        /// <summary>
        /// Método privado que valida un campo de tipo DNI.
        /// </summary>
        /// <param name="dni">El DNI a validar.</param>
        /// <param name="dniValidado">El DNI validado.</param>
        private void ValidarCampoDni(int dni, out int dniValidado)
        {
            dniValidado = -1;
            if (dni < 1000000 || dni > 99999999)
            {
                throw new Exception("No es un DNI válido.");
            }
            dniValidado = dni;
        }

        /// <summary>
        /// Método privado que valida un campo de tipo edad.
        /// </summary>
        /// <param name="edad">La edad a validar.</param>
        /// <param name="edadValido">La edad validada.</param>
        private void ValidarCampoEdad(int edad, out int edadValido)
        {
            edadValido = -1;
            if (edad <= 1 && edad > 120)
            {
                throw new Exception("No es una edad válida.");
            }
            edadValido = edad;
        }
    }
}