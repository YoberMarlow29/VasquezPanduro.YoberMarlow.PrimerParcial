using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Cliente : Persona
    {
        private DateTime antiguedadComoCliente;
        public int Antiguedad
        {
            get
            {
                return CalcularAntiguedad();
            }
        }

        public Cliente(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, DateTime antiguedadComoCliente)
           : base(nombre, apellido, fechaDeNacimiento, dni)
        {
            this.antiguedadComoCliente = antiguedadComoCliente;
        }
        public override int CalcularAntiguedad()
        {
            if ((this.antiguedadComoCliente.Year - this.Nacimiento.Year) < 0)
            {
                return 0;
            }
            return DateTime.Now.Year - this.antiguedadComoCliente.Year;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.GetHashCode() == c2.GetHashCode();
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cliente aux = obj as Cliente;
            return aux is not null && aux == this;
        }

        public override string ToString()
        {
            return $"{base.Apellido}, {base.Nombre} - DNI: {base.GetHashCode()}";
        }

    }
}
