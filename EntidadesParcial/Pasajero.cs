using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Pasajero
    {
        protected Cliente cliente;
        protected bool equipajeDeMano;
        protected List<double> equipajeDeBodega;
        protected int equipajesMaximos;
        protected double pesoAdicional;


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

        public Pasajero()
        {
            this.equipajeDeBodega = new List<double>();
            this.EquipajeDeMano = false;

        }
        public Pasajero(Cliente cliente):this()
        {
            this.cliente = cliente;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.cliente.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        
    }
}
