using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    /// <summary>
    /// Clase que representa a un pasajero, hereda de la clase Persona.
    /// </summary>
    public class Pasajero : Persona
    {
        /// <summary>
        /// Constructor por defecto de la clase Pasajero.
        /// </summary>
        public Pasajero()
        {

        }

        /// <summary>
        /// Constructor de la clase Pasajero que recibe los datos del pasajero.
        /// </summary>
        /// <param name="nombre">El nombre del pasajero.</param>
        /// <param name="apellido">El apellido del pasajero.</param>
        /// <param name="edad">La edad del pasajero.</param>
        /// <param name="dni">El DNI del pasajero.</param>
        public Pasajero(string nombre, string apellido, int edad, int dni) : base(nombre, apellido, edad, dni)
        {
            if (ExistePasajeroConDNI(dni))
            {
                throw new Exception("Ya existe un pasajero con el mismo DNI.");
            }
        }

        /// <summary>
        /// Sobrescritura del método Equals para comparar un objeto con un pasajero.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si el objeto es igual al pasajero; false en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Pasajero)
            {
                return this == (Pasajero)obj;
            }
            return false;
        }

        /// <summary>
        /// Método que muestra el nombre completo del pasajero junto con su DNI.
        /// </summary>
        /// <returns>Una cadena con el nombre completo y el DNI del pasajero.</returns>
        public string MostrarNombre()
        {
            return $"{base.apellido}, {base.nombre} - DNI: {base.GetHashCode()}";
        }

        /// <summary>
        /// Sobrescritura del método GetHashCode para obtener el código hash del pasajero.
        /// </summary>
        /// <returns>El código hash del pasajero.</returns>
        public override int GetHashCode()
        {
            return this.Dni;
        }

        /// <summary>
        /// Sobrescritura del método ToString para obtener una representación en cadena del pasajero.
        /// </summary>
        /// <returns>Una cadena con el nombre completo y el DNI del pasajero.</returns>
        public override string ToString()
        {
            return MostrarNombre();
        }

        /// <summary>
        /// Método privado que verifica si existe un pasajero con el mismo DNI en la lista de pasajeros.
        /// </summary>
        /// <param name="dni">El DNI a verificar.</param>
        /// <returns>true si existe un pasajero con el mismo DNI; false en caso contrario.</returns>
        private bool ExistePasajeroConDNI(int dni)
        {
            foreach (Pasajero pasajero in Archivos.listaDePasajeros)
            {
                if (pasajero.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
