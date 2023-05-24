using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Aeronave
    {
        private string matricula;//(un identificador alfanumérico de 8 dígitos).
        private int cantidadAsientosTotales;
        private int cantidadBaños;
        private double capacidadBodega;
        private bool enViaje;

        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (value.Length == 8 && Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                {
                    matricula = value;
                }
                else
                {
                    throw new ArgumentException("La matrícula debe ser alfanumérica y tener 8 dígitos.");
                }
            }
        }

        public int CantidadAsientosTotales
        {
            get { return cantidadAsientosTotales; }
            set { cantidadAsientosTotales = value; }
        }

        public int CantidadBaños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }

        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }
        public int AsientosPremium
        {
            get
            {
                return (int)(cantidadAsientosTotales * 0.20);
            }
            

        }
        public int AsientosTuristas
        {
            get
            {
                return this.cantidadAsientosTotales - this.AsientosPremium;
            }
        }
        public Aeronave()
        {
            this.matricula = "";
            this.cantidadBaños=0;
            this.cantidadAsientosTotales = 0;
            this.capacidadBodega=0;
            this.enViaje=false;
        }
        public Aeronave(string matricula,int cantidadDeAsientosTotales, int cantidadDeBanios, double capacidadDeBodega) : this()
        {
            this.matricula = matricula;
            this.cantidadAsientosTotales = cantidadDeAsientosTotales;
            this.cantidadBaños = cantidadDeBanios;
            this.capacidadBodega = capacidadDeBodega;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}");
            sb.AppendLine($"Cantidad de Asientos : {this.cantidadAsientosTotales}");
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
            return this.cantidadAsientosTotales.GetHashCode();
        }


    }
}
