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
            set {matricula = value;}
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
            ValidarNumero(cantidadDeAsientosTotales, 1,1200,out this.cantidadAsientosTotales);
            ValidarNumero(cantidadDeBanios, 1, 12, out this.cantidadBaños);
            ValidarNumero(capacidadDeBodega, 2000, 15000, out this.capacidadBodega);
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
        private static void ValidarNumero(object numero, int valorMinimo, int valorMaximo, out int numeroValidado)
        {
            if (numero is int)
            {
                numeroValidado = (int)numero;
            }
            else if (numero is string)
            {
                if (int.TryParse((string)numero, out int parsedNumero))
                {
                    numeroValidado = parsedNumero;
                }
                else
                {
                    throw new Exception("No es válido.");
                }
            }
            else
            {
                throw new Exception("No es válido.");
            }

            if (numeroValidado < valorMinimo || numeroValidado > valorMaximo)
            {
                throw new Exception($"Ingresar valores valido entre {valorMinimo} y {valorMaximo}");
            }
        }
        private static void ValidarNumero(object numero, double valorMinimo, double valorMaximo, out double numeroValidado)
        {
            if (numero is double)
            {
                numeroValidado = (double)numero;
            }
            else if (numero is string)
            {
                if (double.TryParse((string)numero, out double parsedNumero))
                {
                    numeroValidado = parsedNumero;
                }
                else
                {
                    throw new Exception("No es válido.");
                }
            }
            else
            {
                throw new Exception("No es válido.");
            }

            if (numeroValidado < valorMinimo || numeroValidado > valorMaximo)
            {
                throw new Exception($"Ingresar valores valido entre {valorMinimo} y {valorMaximo}");
            }
        }


    }
}
