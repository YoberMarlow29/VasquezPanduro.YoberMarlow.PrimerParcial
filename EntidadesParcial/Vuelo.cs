using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Vuelo
    {

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

        public int IdVuelo              
        { 
            get { return idVuelo; } set {  idVuelo = value; }
        }
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }
        public ETipoDeViaje Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public int Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }
        public Aeronave Aeronave
        {
            get { return aeronave; }
            set { aeronave = value; }
        }
        public List<Pasaje> ListaDePasajes
        {
            get { return listaDePasajes; }
            set { listaDePasajes = value; }
        }

        public DateTime Partida
        {
            get { return partida; }
            set { partida = value; }
        }
        public string Disponibilidad
        {
            get
            {
                return ActualizarDisponibilidad();
            }
        }

        public bool ServicioComida
        {
            get { return servicioComida; }
            set { servicioComida = value; }
        }
        public bool ServicioWifi
        {
            get { return servicioWifi; }
            set { servicioWifi = value; }
        }
        public int Premium
        {
            get
            {
                return CantidadDeVuelosPorClase(ClasePasajero.Premium);
            }
        }
        public int Tursita
        {
            get
            {
                return CantidadDeVuelosPorClase(ClasePasajero.Turista);
            }
        }
        public Vuelo()
        {
            this.listaDePasajes = new List<Pasaje>();
            this.idVuelo = Archivos.listaDeViaje.Count()+1;
        }
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
        private static void ValidarOrigenDestino(string origen, string destino)
        {
            if (origen == destino)
            {
                throw new Exception("El origen no puede ser igual que el destino");
            }
        }
        private void ValidarVueloInternacional()
        {
            if (DestinoEsInternacional(this.origen, this.destino) == ETipoDeViaje.Internacional &&
                                        this.origen != "Buenos Aires" && this.destino != "Buenos Aires")
            {
                throw new Exception("Vuelos internacionales deben partir o arribar en Buenos Aires");
            }
        }
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
        public override string ToString()
        {
            return $"{this.tipo},{this.origen},{this.destino}";
        }

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
        private DateTime MedirHorarioDeLlegada()
        {
            DateTime llegada;

            llegada = this.partida.AddHours(this.duracion);

            return llegada;

        }
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
            return $"{this.listaDePasajes.Count}/ {this.aeronave.CantidadAsientosTotales}";
        }

    }
}
