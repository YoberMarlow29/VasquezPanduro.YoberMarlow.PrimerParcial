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
        private List<double> equipajeDeBodega;

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

        public List<double> EquipajeDeBodega
        {
            get { return equipajeDeBodega; }
            set { equipajeDeBodega = value; }
        }

        public Pasajero()
        {
            clase = ClasePasajero.NoCargado;
            equipajeDeMano = false;
            equipajeDeBodega = new List<double>();
        }

        public Pasajero(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, ClasePasajero clase,bool equipajeDeMano, List<double> equipajeDeBodega)
        : base(nombre, apellido, fechaDeNacimiento, dni)
        {
            this.clase = clase;
            this.equipajeDeMano = equipajeDeMano;
            this.equipajeDeBodega = equipajeDeBodega;
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            return p1.GetHashCode() == p2.GetHashCode();
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
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
