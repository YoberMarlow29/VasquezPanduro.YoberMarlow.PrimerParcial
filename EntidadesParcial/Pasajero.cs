using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasajero : Persona
    {
        private ClasePasajero clase;
        private bool equipajeDeMano;
        private double equipajeDeBodega;

        public ClasePasajero Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public bool EquipajeDeMano
        {
            get { return equipajeDeMano; }
            set { equipajeDeMano = value; }
        }

        public double EquipajeDeBodega
        {
            get { return equipajeDeBodega; }
            set { equipajeDeBodega = value; }
        }

        public Pasajero()
        {
            clase = ClasePasajero.NoCargado;
            equipajeDeMano = false;
            equipajeDeBodega = 0;
        }
        public Pasajero(string nombre, string apellido, int edad, int dni) : base(nombre, apellido, edad, dni)
        {
            
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            return p1.GetHashCode() == p2.GetHashCode();
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pasajero)
            {
                return this == (Pasajero)obj;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.Apellido}, {base.Nombre} - DNI: {base.GetHashCode()}";
        }
    }
}
