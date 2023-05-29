using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasajero : Persona
    {
        public Pasajero()
        {

        }
        public Pasajero(string nombre, string apellido, int edad, int dni) : base(nombre, apellido, edad, dni)
        {

        }

        /*public static bool operator ==(Pasajero p1, Pasajero p2)
        {

                return p1.GetHashCode() == p2.GetHashCode();
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }*/

        public override bool Equals(object? obj)
        {
            if (obj is Pasajero)
            {
                return this == (Pasajero)obj;
            }
            return false;
        }
        public string MostrarNombre() 
        {
            return $"{base.apellido}, {base.nombre} - DNI: {base.GetHashCode()}";
        }
        public override string ToString()
        {
            return MostrarNombre();
        }
    }
}
