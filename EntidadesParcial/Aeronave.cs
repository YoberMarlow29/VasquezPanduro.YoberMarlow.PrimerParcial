using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Aeronave
    {
        private string matricula;//(un identificador alfanumérico de 8 dígitos).
        private string nombre;
        private int cantidadAsientos;
        private int cantidadBaños;
        private static int capacidadBodega;
        private ESiNo servicioComida;
        private ESiNo servicioInternet;
        private int capacidadBodegaActual;
        private int capacidadPasajerosActual;
        private bool enViaje;

        static Aeronave()
        {
            Aeronave.capacidadBodega = 10000;
        }

        public string Matricula
        {
            get { return this.matricula; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
        }
        public int CantidadBaños
        {
            get { return cantidadBaños; }
        }
        public int CapacidadBodega
        {
            get { return capacidadBodega; }
        }
        public ESiNo ServicioComida
        {
            get { return this.servicioComida; }
        }
        public ESiNo ServicioInternet
        {
            get { return this.servicioInternet; }
        }

        public int CapacidadBodegaActual
        {
            get { return this.capacidadBodegaActual; }
            set { this.capacidadBodegaActual = value; }
        }
        public int CapacidadPasajerosActual
        {
            get { return this.capacidadPasajerosActual; }
            set { this.capacidadPasajerosActual = value; }
        }
        public bool EnViaje
        {
            get { return this.enViaje; }
            set { this.enViaje = value; }
        }

        private Aeronave(int cantidadAsientos) 
        {
            if (cantidadAsientos > 0) 
            {
                this.matricula = "";
                this.nombre = "";
                this.cantidadAsientos = 0;
                this.cantidadBaños = 0;
                this.capacidadBodegaActual = Aeronave.capacidadBodega;
                this.servicioComida = ESiNo.No;
                this.servicioInternet = ESiNo.No;
                this.capacidadPasajerosActual = this.cantidadAsientos;
                this.enViaje = false;
            }
        }
        public Aeronave(string matricula, string nombre, int cantidadAsientos, int cantidadBaños, ESiNo servicioComida, ESiNo servicioInternet) :this(cantidadAsientos)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadBaños = cantidadBaños;
            this.servicioComida = servicioComida;
            this.servicioInternet = servicioInternet;
        }
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Aeronave: ");
            cadena.Append($"Esta en viaje? ");
            if (this.enViaje)
            {
                cadena.AppendLine("si ");
            }
            else
            {
                cadena.AppendLine("no ");
            }
            cadena.AppendLine($"La matricula es: {this.matricula} ");
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"La cantidad de asientos es: {this.cantidadAsientos} ");
            cadena.AppendLine($"La cantidad de baños es: {this.cantidadBaños} ");
            cadena.AppendLine($"La capacidad total de la bodega es de: {this.CapacidadBodega} kg ");
            cadena.AppendLine($"La capacidad restante de la bodega es de: {this.CapacidadBodegaActual} kg ");
            cadena.AppendLine($"Ofrece servicio de comida: {this.servicioComida} ");
            cadena.AppendLine($"Ofrece servicio de internet:{this.servicioInternet} ");
            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            bool rta = false;
            if (a1.matricula == a2.matricula && a1.nombre == a2.nombre)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Aeronave a1, Aeronave a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Aeronave)
            {
                if (this == ((Aeronave)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.cantidadAsientos.GetHashCode();
        }
    }
}
