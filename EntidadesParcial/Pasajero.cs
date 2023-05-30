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
            if (ExistePasajeroConDNI(dni))
            {
                throw new Exception("Ya existe un pasajero con el mismo DNI.");
            }
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
        public override int GetHashCode()
        {
            return this.dni;
        }
        public override string ToString()
        {
            return MostrarNombre();
        }
        private bool ExistePasajeroConDNI(int dni)
        {
            foreach (Pasajero pasajero in Archivos.listaDePasajeros)
            {
                if (pasajero.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
