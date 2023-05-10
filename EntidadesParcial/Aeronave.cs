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
        private int cantidadAsientos;
        private int cantidadBaños;
        private double capacidadBodega;
        private List<DateTime> planDeVuelos;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int Premium
        {
            get
            {
                return (int)(cantidadAsientos * 0.20);
            }
        }

        public int Tursita
        {
            get
            {
                return this.cantidadAsientos - this.Premium;
            }
        }

        public int AsientosTotales
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }

        public int Baños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }

        public double Bodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }
        private Aeronave()
        {
            planDeVuelos = new List<DateTime>();
        }
        public Aeronave(string matricula,int cantidadDeAsientos, int cantidadDeBanios, double capacidadDeBodega) : this()
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadDeAsientos;
            this.cantidadBaños = cantidadDeBanios;
            this.capacidadBodega = capacidadDeBodega;
        }
        public void AgregarVueloAPlanDeVuelos(DateTime vueloFecha)
        {
            if (VerificarQueNuevoPlanDeVueloNoExista(vueloFecha))
            {
                this.planDeVuelos.Add(vueloFecha);
            }
        }
        private bool VerificarQueNuevoPlanDeVueloNoExista(DateTime vueloFecha)
        {
            foreach (DateTime item in this.planDeVuelos)
            {
                if (item.ToShortDateString() == vueloFecha.ToShortDateString())
                {
                    throw new Exception($"La aerovane {this.matricula} ya tiene un vuelo en {vueloFecha.ToString("dd/MM/yyyy")}");
                }
            }
            return true;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Cantidad de Asientos Totales: {this.cantidadAsientos}");
            sb.AppendLine($"Cantidad de Asientos Premium: {this.Premium}");
            sb.AppendLine($"Cantidad de Asientos Tursitas: {this.Tursita}");
            sb.AppendLine($"Cantidad de Baños: {this.cantidadBaños}");
            sb.AppendLine($"Capacidad de Bodega: {this.capacidadBodega.ToString("0.##")} KG.");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            bool rta = false;
            if (a1.matricula == a2.matricula )
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
