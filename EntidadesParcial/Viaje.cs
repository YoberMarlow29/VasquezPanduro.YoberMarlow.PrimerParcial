using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Viaje
    {
        public enum AerolineaPartida
        {
            BuenosAires_Argentina
        };
        protected AerolineaPartida aerolinea;
        protected DateTime fechaInicio;
        protected DateTime fechaActual;
        protected Aeronave avion;
        protected int cantidadAsientosPremium;
        protected int cantidadAsientosTurista;
        protected float precioPremium;
        protected float precioTurista;
        protected float precioPremiumBruto;
        protected float precioTuristaBruto;
        protected int duracionHoras;
        protected List<Pasajero> pasajeros;

        public List<Pasajero> ListaPasajeros
        {
            get { return this.pasajeros; }
        }

        public int CantidadPasajeros
        {
            get { return pasajeros.Count; }
        }

        public AerolineaPartida Aerolinea
        {
            get { return aerolinea; }
        }
        public String FechaDePartida
        {
            get { return fechaInicio.ToString(); }
        }
        public Aeronave Avion
        {
            get { return avion; }
        }
        public int CantidadAsientosPremium
        {
            get { return cantidadAsientosPremium; }
        }
        public int CantidadAsientosTurista
        {
            get { return cantidadAsientosTurista; }
        }
        public float PrecioPremium
        {
            get { return precioPremium; }
        }
        public float PrecioTurista
        {
            get { return precioTurista; }
        }
        public int DuracionHoras
        {
            get { return duracionHoras; }
        }

        public float PrecioPremiumBruto
        {
            get { return precioPremiumBruto; }
        }
        public float PrecioTuristaBruto
        {
            get { return precioTuristaBruto; }
        }
        public Pasajero this[int indice]
        {
            get
            {
                // agarrar el pasajero de la lista en ese indice
                return this.pasajeros[indice];
            }
        }
        protected Viaje() 
        {
            this.aerolinea = AerolineaPartida.BuenosAires_Argentina;
            this.fechaInicio = DateTime.Today;
            this.avion = new Aeronave("","",1,0,ESiNo.No,ESiNo.No);
            this.cantidadAsientosPremium = 0;
            this.cantidadAsientosTurista = 0;
            this.precioPremium = 0;
            this.precioTurista = 0;
            this.pasajeros = new List<Pasajero>();
        }
        protected Viaje(DateTime fecha,Aeronave a1,int asientosPremium,int asientosTurista):this()
        {
            this.fechaInicio = fecha;
            this.avion = a1;
            this.cantidadAsientosPremium = asientosPremium;
            this.cantidadAsientosTurista = asientosTurista;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Viaje: ");
            sb.AppendLine($"La fecha de inicio es: {this.fechaInicio.ToString()} ");
            sb.AppendLine($"{this.avion.ToString()} ");
            sb.AppendLine($"La cantidad de asientos premium es: {this.cantidadAsientosPremium} ");
            sb.AppendLine($"La cantidad de asientos turista es: {this.cantidadAsientosTurista} ");
            sb.AppendLine($"El precio premium es: {this.precioPremium} ");
            sb.AppendLine($"El precio turista es: {this.precioTurista} ");
            sb.AppendLine($"La duracion del viaje es: {this.duracionHoras} ");
            sb.AppendLine($"El puerto de partida es: {this.aerolinea} ");
            return sb.ToString();
        }


    }
}
