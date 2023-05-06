using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class ViajeInternacional : Viaje
    {
        private EViajeInternacional destinoInternacional;

        public ViajeInternacional(EViajeInternacional destino, DateTime fecha, Aeronave a1, int asientosPremium, int asientosTuristas, float precioPremium, float precioTurista) : base(fecha, a1, asientosPremium, asientosTuristas)
        {
            if (precioPremium > 0 && precioTurista > 0)
            {
                this.destinoInternacional = destino;
                Random myObject = new Random();
                this.duracionHoras = myObject.Next(480, 720);

                this.precioPremiumBruto = precioPremium * this.duracionHoras;
                this.precioTuristaBruto = precioTurista * this.duracionHoras;

                this.precioPremium = precioPremiumBruto + (precioPremiumBruto * 21 / 100);
                this.precioTurista = precioTuristaBruto + (precioTuristaBruto * 21 / 100);
            }
        }
        public DateTime LLegada
        {
            get { return fechaInicio.AddHours(this.duracionHoras); }
        }

        public EViajeInternacional DestinoInternacional
        {
            get { return destinoInternacional; }
        }
        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($"El destino es: {this.destinoInternacional} ");

            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(ViajeInternacional viaje1, ViajeInternacional viaje2)
        {
            bool rta = false;
            if (viaje1.fechaInicio == viaje2.fechaInicio && viaje1.destinoInternacional == viaje2.destinoInternacional)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(ViajeInternacional viaje1, ViajeInternacional viaje2)
        {
            return !(viaje1 == viaje2);
        }

        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is ViajeInternacional)
            {
                if (this == ((ViajeInternacional)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.avion.GetHashCode();
        }
    }
}
