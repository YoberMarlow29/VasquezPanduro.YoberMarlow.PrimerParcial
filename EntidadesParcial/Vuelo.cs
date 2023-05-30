using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    /// <summary>
    /// Clase que representa un vuelo.
    /// </summary>
    public class Vuelo
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private int idVuelo;
        private string destino;
        private string origen;
        private ETipoDeViaje tipo;
        private int duracion;
        private DateTime partida;
        private Aeronave aeronave;
        private List<Pasaje> listaDePasajes;
        private bool servicioWifi;
        private bool servicioComida;

        /// <summary>
        /// Identificador del vuelo.
        /// </summary>
        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }

        /// <summary>
        /// Origen del vuelo.
        /// </summary>
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        /// <summary>
        /// Destino del vuelo.
        /// </summary>
        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        /// <summary>
        /// Tipo de viaje.
        /// </summary>
        public ETipoDeViaje Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        /// <summary>
        /// Duración del vuelo en horas.
        /// </summary>
        public int Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }

        /// <summary>
        /// Aeronave asignada al vuelo.
        /// </summary>
        public Aeronave Aeronave
        {
            get { return aeronave; }
            set { aeronave = value; }
        }

        /// <summary>
        /// Lista de pasajes vendidos para el vuelo.
        /// </summary>
        public List<Pasaje> ListaDePasajes
        {
            get { return listaDePasajes; }
            set { listaDePasajes = value; }
        }

        /// <summary>
        /// Fecha y hora de partida del vuelo.
        /// </summary>
        public DateTime Partida
        {
            get { return partida; }
            set { partida = value; }
        }

        /// <summary>
        /// Disponibilidad del vuelo.
        /// </summary>
        public string Disponibilidad
        {
            get
            {
                return ActualizarDisponibilidad();
            }
        }

        /// <summary>
        /// Indica si el vuelo ofrece servicio de comida.
        /// </summary>
        public bool ServicioComida
        {
            get { return servicioComida; }
            set { servicioComida = value; }
        }

        /// <summary>
        /// Indica si el vuelo ofrece servicio de wifi.
        /// </summary>
        public bool ServicioWifi
        {
            get { return servicioWifi; }
            set { servicioWifi = value; }
        }

        /// <summary>
        /// Número de pasajes vendidos en la clase Premium.
        /// </summary>
        public int Premium
        {
            get
            {
                return CantidadDeVuelosPorClase(ClasePasajero.Premium);
            }
        }

        /// <summary>
        /// Número de pasajes vendidos en la clase Turista.
        /// </summary>
        public int Tursita
        {
            get
            {
                return CantidadDeVuelosPorClase(ClasePasajero.Turista);
            }
        }

        /// <summary>
        /// Constructor de la clase Vuelo.
        /// </summary>
        public Vuelo()
        {
            this.listaDePasajes = new List<Pasaje>();
            this.idVuelo = Archivos.listaDeViaje.Count() + 1;
        }

        /// <summary>
        /// Constructor de la clase Vuelo.
        /// </summary>
        /// <param name="aeronave">Aeronave asignada al vuelo.</param>
        /// <param name="origen">Origen del vuelo.</param>
        /// <param name="destino">Destino del vuelo.</param>
        /// <param name="partida">Fecha y hora de partida del vuelo.</param>
        /// <param name="servicioWifi">Indica si el vuelo ofrece servicio de wifi.</param>
        /// <param name="servicioComida">Indica si el vuelo ofrece servicio de comida.</param>
        public Vuelo(Aeronave aeronave, string origen, string destino, DateTime partida, bool servicioWifi, bool servicioComida) : this()
        {
            this.origen = origen;
            this.destino = destino;
            ValidarOrigenDestino(origen, destino);
            ValidarVueloInternacional();
            this.tipo = DestinoEsInternacional(this.origen, this.destino);
            this.partida = partida;
            GenerarDuracionDeVuelos();

            this.servicioWifi = servicioWifi;
            this.servicioComida = servicioComida;
            this.aeronave = aeronave;
            this.aeronave.AgregarVueloAPlanDeVuelos(this.partida);
        }

        /// <summary>
        /// Valida que el origen y destino del vuelo no sean iguales.
        /// </summary>
        /// <param name="origen">Origen del vuelo.</param>
        /// <param name="destino">Destino del vuelo.</param>
        private static void ValidarOrigenDestino(string origen, string destino)
        {
            if (origen == destino)
            {
                throw new Exception("El origen no puede ser igual que el destino.");
            }
        }
        /// <summary>
        /// Valida si el vuelo es internacional y si cumple con los requisitos.
        /// </summary>
        private void ValidarVueloInternacional()
        {
            if (DestinoEsInternacional(this.origen, this.destino) == ETipoDeViaje.Internacional &&
                                        this.origen != "Buenos Aires" && this.destino != "Buenos Aires")
            {
                throw new Exception("Vuelos internacionales deben partir o arribar en Buenos Aires");
            }
        }
         /// <summary>
         /// Determina si el destino es internacional.
         /// </summary>
         /// <param name="origen">Origen del vuelo.</param>
         /// <param name="destino">Destino del vuelo.</param>
         /// <returns>True si el destino es internacional, False si es nacional.</returns>
        private static ETipoDeViaje DestinoEsInternacional(string origen, string destino)
        {
            if (origen == "Acapulco(México)" ||
                origen == "Miami(EEUU)" ||
                origen == "Recife(Brasil)" ||
                origen == "Roma(Italia)" ||
                destino == "Acapulco(México)" ||
                destino == "Miami(EEUU)" ||
                destino == "Recife(Brasil)" ||
                destino == "Roma(Italia)")
            {
                return ETipoDeViaje.Internacional;
            }
            return ETipoDeViaje.Nacional;
        }
        private Random rnd = new Random();
        /// <summary>
        /// Genera una duración aleatoria para el vuelo.
        /// </summary>
        private void GenerarDuracionDeVuelos()
        {
            if (this.Tipo == ETipoDeViaje.Internacional)
            {
                this.Duracion = rnd.Next(8, 13); // Duración entre 8 y 12 horas
            }
            else
            {
                this.Duracion = rnd.Next(2, 5); // Duración entre 2 y 4 horas
            }
        }
        /// <summary>
        /// Sobrescribe al ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.tipo},{this.origen},{this.destino}";
        }
        /// <summary>
        /// Calcula la cantidad de vuelos por clase de pasajero.
        /// </summary>
        /// <param name="clase">Clase de pasajero.</param>
        /// <returns>La cantidad de vuelos por la clase de pasajero especificada.</returns>
        private int CantidadDeVuelosPorClase(ClasePasajero clase)
        {
            int contador = 0;
            foreach (Pasaje item in this.listaDePasajes)
            {
                if (item.Clase == clase)
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Calcula el horario de llegada del vuelo sumando la duración a la hora de partida.
        /// </summary>
        /// <returns>El horario de llegada del vuelo.</returns>
        private DateTime MedirHorarioDeLlegada()
        {
            DateTime llegada;

            llegada = this.partida.AddHours(this.duracion);

            return llegada;
        }

        /// <summary>
        /// Actualiza el estado del vuelo en función del horario actual y la hora de partida.
        /// </summary>
        /// <returns>El estado actualizado del vuelo.</returns>
        private string ActualizarEstadoDelVuelo()
        {
            string estado = string.Empty;
            if (MedirHorarioDeLlegada() > DateTime.Now && this.partida < DateTime.Now)
            {
                estado = "EN VUELO";
            }
            else if (this.partida < DateTime.Now)
            {
                estado = "FINALIZADO";
            }
            return estado;
        }

        /// <summary>
        /// Actualiza la disponibilidad del vuelo en función de su estado y la cantidad de pasajes vendidos.
        /// </summary>
        /// <returns>La disponibilidad actualizada del vuelo.</returns>
        private string ActualizarDisponibilidad()
        {
            string vuelo = ActualizarEstadoDelVuelo();
            if (!string.IsNullOrEmpty(vuelo))
            {
                return vuelo;
            }
            else if (this.listaDePasajes.Count == this.aeronave.CantidadAsientosTotales)
            {
                return "COMPLETO";
            }
            return $"{this.listaDePasajes.Count}/{this.aeronave.CantidadAsientosTotales}";
        }

        /// <summary>
        /// Calcula la ganancia total para vuelos nacionales.
        /// </summary>
        /// <returns>La ganancia total para vuelos nacionales.</returns>
        public double GananciaNacional()
        {
            double gananciaCabotaje = 0;
            if (DestinoEsInternacional(this.origen, this.destino) == ETipoDeViaje.Nacional)
            {
                double horas = this.duracion;
                double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
                foreach (Pasaje item in this.listaDePasajes)
                {
                    gananciaCabotaje += precioBase;
                }
            }
            return gananciaCabotaje;
        }

        /// <summary>
        /// Calcula la ganancia total para vuelos internacionales.
        /// </summary>
        /// <returns>La ganancia total para vuelos internacionales.</returns>
        public double GananciaInternacional()
        {
            double gananciaInternacional = 0;
            if (DestinoEsInternacional(this.origen, this.destino) == ETipoDeViaje.Internacional)
            {
                double horas = this.duracion;
                double precioBase = CalcularPrecioSegunTipoDeVuelo(horas);
                for (int i = 0; i < this.listaDePasajes.Count; i++)
                {
                    gananciaInternacional += precioBase;
                }
            }
            return gananciaInternacional;
        }

        /// <summary>
        /// Calcula el precio del pasaje según el tipo de vuelo y las horas totales de duración.
        /// </summary>
        /// <param name="horasTotales">Las horas totales de duración del vuelo.</param>
        /// <returns>El precio del pasaje.</returns>
        public double CalcularPrecioSegunTipoDeVuelo(double horasTotales)
        {
            double precioFinal;
            if (DestinoEsInternacional(this.origen, this.destino) == ETipoDeViaje.Nacional)
            {
                precioFinal = PRECIOPORHORANACIONAL * horasTotales;
            }
            else
            {
                precioFinal = PRECIOPORHORAINTERNACIONAL * horasTotales;
            }

            return precioFinal;
        }

        /// <summary>
        /// Calcula la ganancia total del vuelo sumando el precio de todos los pasajes vendidos.
        /// </summary>
        /// <returns>La ganancia total del vuelo.</returns>
        public double GananciaTotal()
        {
            double ganancia = 0;
            double precioPasaje;
            foreach (Pasaje item in this.listaDePasajes)
            {
                InformarTarifasYPrecioDelPasaje(item, out precioPasaje);
                ganancia += precioPasaje;
            }
            return ganancia;
        }

        /// <summary>
        /// Informa las tarifas y el precio final del pasaje.
        /// </summary>
        /// <param name="pasaje">El pasaje.</param>
        /// <param name="precioFinal">El precio final del pasaje.</param>
        /// <returns>Un string con las tarifas y el precio final del pasaje.</returns>
        public string InformarTarifasYPrecioDelPasaje(Pasaje pasaje, out double precioFinal)
        {
            StringBuilder sb = new StringBuilder();
            double precioBase = CalcularPrecioSegunTipoDeVuelo(this.duracion);
            precioFinal = precioBase;
            sb.AppendLine($"Precio Bruto: {precioBase.ToString("0.00")} U$D");
            if (pasaje.Clase == ClasePasajero.Premium)
            {
                double precioPreium = CalcularAdicionalPremium(precioBase);
                precioFinal += precioPreium;
                sb.AppendLine($"Impuesto por Premium: $ {(precioPreium).ToString("0.00")} U$D");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Calcula el adicional para pasajes premium basado en el precio base.
        /// </summary>
        /// <param name="precioBase">El precio base del pasaje.</param>
        /// <returns>El adicional para pasajes premium.</returns>
        public double CalcularAdicionalPremium(double precioBase)
        {
            return precioBase * 0.35;
        }

    }
}
