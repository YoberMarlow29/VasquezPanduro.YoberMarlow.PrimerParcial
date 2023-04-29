using System.Text;

namespace EntidadesParcial
{
    public class Aeronave
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBaños;
        private ESiNo servicioInternet;
        private ESiNo servicioComida;
        private static int capacidadBodega;
        private int capacidadBodegaActual;
        private bool enViaje;
        public string Matricula
        {
            get { return this.matricula; }
        }
        public int CantidadAsientos
        {
            get { return this.cantidadAsientos; }
        }
        public int CantidadBaños
        {
            get { return this.cantidadBaños; }
        }
        public ESiNo ServicioInternet
        {
            get { return this.servicioInternet; }
        }
        public ESiNo ServicioComida
        {
            get { return this.servicioComida; }
        }
        public int CapacidadBodega
        {
            get { return capacidadBodega; }
        }


        static Aeronave()
        {
            Aeronave.capacidadBodega = 10000;
        }
        private Aeronave(int cantidadAsientos, int cantidadBaños) 
        {
            if (cantidadAsientos > 0 && cantidadBaños > 0) 
            {
                this.enViaje = false;
                this.matricula = "";
                this.servicioInternet = ESiNo.No;
                this.servicioComida = ESiNo.No;
                this.capacidadBodegaActual = Aeronave.capacidadBodega;
            }
        }
        private Aeronave(string matricula, int cantidadAsientos, int cantidadBaños, ESiNo servicioInternet, ESiNo servicioComida) :this(cantidadAsientos,cantidadBaños)
        {
            this.matricula = matricula;
            this.servicioInternet = servicioInternet;
            this.servicioComida = servicioComida;
        }

        private string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Aeronave: ");
            sb.Append($"Esta en viaje? ");
            if (this.enViaje)
            {
                sb.AppendLine("si ");
            }
            else
            {
                sb.AppendLine("no ");
            }
            sb.AppendLine($"La matricula es: {this.matricula} ");
            sb.AppendLine($"La cantidad de asientos es: {this.cantidadAsientos} ");
            sb.AppendLine($"La cantidad de baños es: {this.cantidadBaños} ");
            sb.AppendLine($"La capacidad total de la bodega es de: {this.CapacidadBodega} kg ");
            sb.AppendLine($"La capacidad restante de la bodega es de: {this.capacidadBodegaActual} kg ");
            sb.AppendLine($"Ofrece servicio de internet: {this.servicioInternet} ");
            sb.AppendLine($"Ofrece servicio de comida:{this.servicioComida} ");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }







    }
}
