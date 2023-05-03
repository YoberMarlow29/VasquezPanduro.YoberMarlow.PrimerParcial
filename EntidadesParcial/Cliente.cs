using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Cliente : Persona
    {
        private int dni;
        private ENacionalidad nacionalidad;
        private bool enViaje;
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

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public ESexo Sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public bool EnViaje
        {
            set { enViaje = value; }
        }
        public Cliente(string nombre, string apellido, int dni, int edad, ESexo genero,ENacionalidad nacionalidad) : base(nombre, apellido, edad, genero)
        {
            this.dni = dni;
            this.nacionalidad = nacionalidad;
            this.enViaje = false;
        }
        private string MostrarCliente()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($"El dni es: {this.dni} ");
            cadena.AppendLine($"La nacionalidad es: {this.nacionalidad} ");

            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.MostrarCliente();
        }
    }
}
