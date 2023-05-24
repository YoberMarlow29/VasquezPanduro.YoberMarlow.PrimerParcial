using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Viaje
    {
        private string idViaje;
        private string destino;
        private string origen;
        private ETipoDeViaje tipo;
        private int horaDelVuelo;
        private int minutosDelVuelo;
        private string duracion;
        private DateTime partida;
        private Aeronave aeronave;
        private List<Pasajero> listaDePasajeros;
        private bool servicioWifi;
        private bool servicioComida;
        private bool enViaje;
        public string IdViaje
        {
            get { return idViaje; }
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
            get { return tipo; }
        }
        public string Duracion
        {
            get { return duracion; }
        }
        public Aeronave Aeronave
        {
            get { return aeronave; }
            set { aeronave = value; }
        }
        public List<Pasajero> ListaDePasajeros
        {
            get { return listaDePasajeros; }
            set { listaDePasajeros = value; }
        }
        public int HoraDelVuelo
        {
            get { return horaDelVuelo; }
            set { horaDelVuelo = value; }
        }
        public int MinutosDelVuelo
        {
            get { return minutosDelVuelo; }
            set { minutosDelVuelo = value; }
        }
        public DateTime Partida
        {
            get { return partida; }
            set { partida = value; }
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
        private bool EnViaje 
        {
            get { return enViaje; }
            set { enViaje = value; }
        }

        private Viaje()
        {
            this.listaDePasajeros = new List<Pasajero>();
            this.idViaje = GenerarID();
        }
        public Viaje(Aeronave aeronave, string origen, string destino, DateTime partida, bool servicioWifi, bool servicioComida) : this()
        {
            this.origen = origen;
            this.destino = destino;
            ValidarOrigenDestino(origen, destino);
            ValidarVueloInternacional();
            this.tipo = DestinoEsInternacional(this.origen, this.destino);
            this.partida = partida;
            GenerarDuracionDeVuelos();
            this.duracion = new DateTime(1, 1, 1, this.horaDelVuelo, this.minutosDelVuelo, 0).ToString("HH:mm");
            this.servicioWifi = servicioWifi;
            this.servicioComida = servicioComida;           
            this.aeronave = aeronave;
            
        }
        private string GenerarID()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] idArray = new char[11];
            Random random = new Random();

            for (int i = 0; i < idArray.Length; i++)
            {
                idArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new String(idArray);
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
        private void GenerarDuracionDeVuelos()
        {
            Random rnd = new Random();
            if (this.Tipo == ETipoDeViaje.Internacional)
            {
                this.horaDelVuelo = rnd.Next(8, 12);
                this.minutosDelVuelo = rnd.Next(0, 55);
                if (this.horaDelVuelo == 12)
                {
                    this.minutosDelVuelo = 0;
                }
            }
            else
            {
                this.horaDelVuelo = rnd.Next(2, 4);
                this.minutosDelVuelo = rnd.Next(0, 55);
                if (this.horaDelVuelo == 4)
                {
                    this.minutosDelVuelo = 0;
                }
            }
        }

    }
}
