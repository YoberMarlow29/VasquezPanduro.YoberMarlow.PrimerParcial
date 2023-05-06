using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class ViajeNacional : Viaje
    {
        private EViajeNacional destinoNacional;

        public ViajeNacional(EViajeNacional destino, DateTime fecha, Aeronave a1, int asientosPremium, int asientosTuristas, float precioPremium, float precioTurista) : base(fecha, a1, asientosPremium, asientosTuristas)
        {
            if (precioPremium > 0 && precioTurista > 0)
            {
                this.destinoNacional = destino;
                Random myObject = new Random();
                this.duracionHoras = myObject.Next(72, 360);

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

        public EViajeNacional DestinoNacional
        {
            get { return destinoNacional; }
        }

        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($"El destino es: {this.destinoNacional} ");

            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(ViajeNacional viaje1, ViajeNacional viaje2)
        {
            bool rta = false;
            if (viaje1.fechaInicio == viaje2.fechaInicio && viaje1.destinoNacional == viaje2.destinoNacional)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(ViajeNacional viaje1, ViajeNacional viaje2)
        {
            return !(viaje1 == viaje2);
        }

        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is ViajeNacional)
            {
                if (this == ((ViajeNacional)obj))
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
