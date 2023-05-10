using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasajero
    {
        private Cliente cliente;
        private ETipoPasajero claseDePasajero;
        private bool equipajeDeMano;
        private List<double> equipajeDeBodega;
        private int equipajesMaximos;
        private double pesoAdicional;

        public ETipoPasajero Clase
        {
            get
            {
                return claseDePasajero;
            }
            set
            {
                claseDePasajero = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public bool EquipajeDeMano
        {
            get
            {
                return equipajeDeMano;
            }
            set
            {
                equipajeDeMano = value;
            }
        }

        public double PesoAdicional
        {
            get
            {
                return this.pesoAdicional;
            }
        }

        public List<double> EquipajeDeBodega
        {
            get
            {
                return equipajeDeBodega;
            }
            set
            {
                equipajeDeBodega = value;
            }
        }

        public int EquipajesMaximos
        {
            get
            {
                return equipajesMaximos;
            }
            set
            {
                equipajesMaximos = value;
            }
        }

        private Pasajero()
        {
            this.equipajeDeBodega = new List<double>();
            this.EquipajeDeMano = false;
            this.equipajesMaximos = 4;
            this.pesoAdicional = 0;
        }
        public Pasajero(Cliente cliente, ETipoPasajero claseDePasajero) : this()
        {
            this.cliente = cliente;
            this.claseDePasajero = claseDePasajero;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.claseDePasajero.ToString());
            sb.AppendLine(this.cliente.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        
    }
}
