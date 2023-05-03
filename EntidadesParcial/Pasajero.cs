using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasajero
    {
        private List<Bolsos> equipajes;  
        private ETipoPasajero clase;
        private Cliente cliente;

        public ETipoPasajero Clase
        {
            get { return clase; }
        }

        public string Cliente
        {
            get{ return cliente.ToString(); }
        }
        public List<Bolsos> Equipajes
        {
            get { return equipajes; }
        }

        public string Nombre
        {
            get { return cliente.Nombre; }
        }
        public string Apellido
        {
            get { return cliente.Apellido; }
        }
        public int Dni
        {
            get { return cliente.Dni; }
        }
        public int Edad
        {
            get { return cliente.Edad; }
        }
        public string Equipaje
        {
            get
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendLine($"El equipaje es: ");
                foreach (Bolsos item in this.equipajes)
                {
                    cadena.AppendLine($"- {item.ToString()} ");
                }
                return cadena.ToString();
            }
        }

        private Pasajero()
        {
            this.equipajes = new List<Bolsos>();
            this.clase = ETipoPasajero.NoCargado;
            this.cliente = new Cliente("", "", 0, 0, ESexo.NoCargado,ENacionalidad.NoCargado);
        }
        public Pasajero(Cliente cliente, ETipoPasajero clase) : this()
        {
            this.clase = clase;
            this.cliente = cliente;
            this.cliente.EnViaje = true;
        }
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Pasajero: ");
            cadena.AppendLine($"El cliente es: {this.cliente.ToString()} ");
            cadena.AppendLine($"El equipaje es: ");
            foreach (Bolsos item in this.equipajes)
            {
                cadena.AppendLine($"- {item.ToString()} ");
            }
            cadena.AppendLine($"La clase es: {this.clase} ");

            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static Pasajero operator +(Pasajero pasajero, Bolsos bolso)
        {
            if (bolso is not null && pasajero is not null)
            {
                pasajero.equipajes.Add(bolso);
            }
            return pasajero;
        }

        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            bool rta = false;
            if (pasajero1 is not null && pasajero2 is not null)
            {
                if (pasajero1.cliente.Dni == pasajero2.cliente.Dni)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2)
        {
            return !(pasajero1 == pasajero2);
        }
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Pasajero)
            {
                if (this == ((Pasajero)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.cliente.Dni.GetHashCode();
        }

    }
}
