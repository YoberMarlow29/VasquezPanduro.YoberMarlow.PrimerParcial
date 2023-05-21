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
        private bool enViaje;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int CantidadAsientos
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
        public Aeronave()
        {
            this.matricula = "";
            this.cantidadBaños=0;
            this.cantidadAsientos=0;
            this.capacidadBodega=0;
            this.enViaje=false;
        }
        public Aeronave(string matricula,int cantidadDeAsientos, int cantidadDeBanios, double capacidadDeBodega) : this()
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadDeAsientos;
            this.cantidadBaños = cantidadDeBanios;
            this.capacidadBodega = capacidadDeBodega;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Cantidad de Asientos : {this.cantidadAsientos}");
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
        //asas
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
