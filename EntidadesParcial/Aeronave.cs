using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    /// <summary>
    /// Representa una aeronave.
    /// </summary>
    public class Aeronave
    {
        private string matricula; // 8 digitos alfanumerico
        private int cantidadAsientosTotales;
        private int cantidadBaños;
        private double capacidadBodega;
        private List<DateTime> planDeVuelos;

        /// <summary>
        /// Obtiene o establece la matrícula de la aeronave.
        /// </summary>
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad total de asientos de la aeronave.
        /// </summary>
        public int CantidadAsientosTotales
        {
            get { return cantidadAsientosTotales; }
            set { cantidadAsientosTotales = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de baños de la aeronave.
        /// </summary>
        public int CantidadBaños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }

        /// <summary>
        /// Obtiene o establece la capacidad de la bodega de la aeronave.
        /// </summary>
        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }

        /// <summary>
        /// Obtiene la cantidad de asientos premium de la aeronave.
        /// </summary>
        public int Premium
        {
            get
            {
                return (int)(cantidadAsientosTotales * 0.20);
            }
        }

        /// <summary>
        /// Obtiene la cantidad de asientos de clase turista de la aeronave.
        /// </summary>
        public int Turista
        {
            get
            {
                return cantidadAsientosTotales - Premium;
            }
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Aeronave.
        /// </summary>
        public Aeronave()
        {
            this.matricula = "";
            this.cantidadBaños = 0;
            this.cantidadAsientosTotales = 0;
            this.capacidadBodega = 0;
            planDeVuelos = new List<DateTime>();
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Aeronave con los valores especificados.
        /// </summary>
        /// <param name="matricula">La matrícula de la aeronave.</param>
        /// <param name="cantidadDeAsientosTotales">La cantidad total de asientos de la aeronave.</param>
        /// <param name="cantidadDeBanios">La cantidad de baños de la aeronave.</param>
        /// <param name="capacidadDeBodega">La capacidad de la bodega de la aeronave.</param>
        public Aeronave(string matricula, int cantidadDeAsientosTotales, int cantidadDeBanios, double capacidadDeBodega) : this()
        {
            if (ExisteAeronaveConMismaMatricula(matricula))
            {
                throw new Exception("Ya existe una aeronave con la misma matrícula.");
            }
            else
                this.matricula = matricula;
            ValidarNumero(cantidadDeAsientosTotales, 1, 1200, out this.cantidadAsientosTotales);
            ValidarNumero(cantidadDeBanios, 1, 12, out this.cantidadBaños);
            ValidarNumero(capacidadDeBodega, 2000, 15000, out this.capacidadBodega);
        }

        /// <summary>
        /// Muestra los datos de la aeronave.
        /// </summary>
        /// <returns>Una cadena con la información de la aeronave.</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.matricula}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve una cadena que representa la aeronave actual.
        /// </summary>
        /// <returns>Una cadena que representa la aeronave actual.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Compara dos instancias de la clase Aeronave para determinar si son iguales.
        /// </summary>
        /// <param name="a1">La primera aeronave a comparar.</param>
        /// <param name="a2">La segunda aeronave a comparar.</param>
        /// <returns>true si las aeronaves son iguales; false en caso contrario.</returns>
        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            bool rta = false;
            if (a1.matricula == a2.matricula)
            {
                rta = true;
            }
            return rta;
        }

        /// <summary>
        /// Compara dos instancias de la clase Aeronave para determinar si son diferentes.
        /// </summary>
        /// <param name="a1">La primera aeronave a comparar.</param>
        /// <param name="a2">La segunda aeronave a comparar.</param>
        /// <returns>true si las aeronaves son diferentes; false en caso contrario.</returns>
        public static bool operator !=(Aeronave a1, Aeronave a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// Determina si la instancia actual es igual a otro objeto.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si el objeto es una instancia de Aeronave y es igual a la instancia actual; false en caso contrario.</returns>
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

        /// <summary>
        /// Obtiene el código hash de la instancia actual.
        /// </summary>
        /// <returns>El código hash de la instancia actual.</returns>
        public override int GetHashCode()
        {
            return this.cantidadAsientosTotales.GetHashCode();
        }

        /// <summary>
        /// Valida un número entero dentro de un rango especificado.
        /// </summary>
        /// <param name="numero">El número a validar.</param>
        /// <param name="valorMinimo">El valor mínimo permitido.</param>
        /// <param name="valorMaximo">El valor máximo permitido.</param>
        /// <param name="numeroValidado">El número validado.</param>
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
                throw new Exception($"Ingresar valores válido entre {valorMinimo} y {valorMaximo}");
            }
        }

        /// <summary>
        /// Valida un número decimal dentro de un rango especificado.
        /// </summary>
        /// <param name="numero">El número a validar.</param>
        /// <param name="valorMinimo">El valor mínimo permitido.</param>
        /// <param name="valorMaximo">El valor máximo permitido.</param>
        /// <param name="numeroValidado">El número validado.</param>
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
                throw new Exception($"Ingresar valores válido entre {valorMinimo} y {valorMaximo}");
            }
        }

        /// <summary>
        /// Agrega un vuelo al plan de vuelos de la aeronave.
        /// </summary>
        /// <param name="vueloFecha">La fecha del vuelo a agregar.</param>
        public void AgregarVueloAPlanDeVuelos(DateTime vueloFecha)
        {
            if (VerificarQueNuevoPlanDeVueloNoExista(vueloFecha))
            {
                this.planDeVuelos.Add(vueloFecha);
            }
        }

        /// <summary>
        /// Verifica que no exista un plan de vuelo con la misma fecha.
        /// </summary>
        /// <param name="vueloFecha">La fecha del vuelo a verificar.</param>
        /// <returns>true si no existe un plan de vuelo con la misma fecha; false en caso contrario.</returns>
        private bool VerificarQueNuevoPlanDeVueloNoExista(DateTime vueloFecha)
        {
            foreach (DateTime item in this.planDeVuelos)
            {
                if (item.ToShortDateString() == vueloFecha.ToShortDateString())
                {
                    throw new Exception($"La aeronave {this.matricula} ya tiene un vuelo en {vueloFecha.ToString("dd/MM/yyyy")}");
                }
            }
            return true;
        }

        /// <summary>
        /// Verifica si existe una aeronave con la misma matrícula en la lista de aeronaves.
        /// </summary>
        /// <param name="matricula">La matrícula a verificar.</param>
        /// <returns>true si existe una aeronave con la misma matrícula; false en caso contrario.</returns>
        private static bool ExisteAeronaveConMismaMatricula(string matricula)
        {
            // Aquí debes implementar la lógica para verificar si ya existe una aeronave con la misma matrícula en tu lista de aeronaves.
            return false;
        }
    }
}
