using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    /// <summary>
    /// Representa un pasaje de un pasajero en un vuelo.
    /// </summary>
    public class Pasaje
    {
        private Pasajero pasajero;
        private ClasePasajero clase;
        private double equipajeDeBodega;
        private bool equipajeDeMano;
        private int idPasaje;
        private static int ultimoIdPasaje = 0;

        /// <summary>
        /// Obtiene o establece el pasajero asociado al pasaje.
        /// </summary>
        public Pasajero Pasajero
        {
            get { return pasajero; }
            set { pasajero = value; }
        }

        /// <summary>
        /// Obtiene o establece la clase de pasajero del pasaje.
        /// </summary>
        public ClasePasajero Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        /// <summary>
        /// Obtiene o establece el peso del equipaje de bodega en kilogramos.
        /// </summary>
        public double EquipajeDeBodega
        {
            get { return equipajeDeBodega; }
            set { equipajeDeBodega = value; }
        }

        /// <summary>
        /// Obtiene o establece el identificador único del pasaje.
        /// </summary>
        public int IdPasaje
        {
            get { return idPasaje; }
            set { idPasaje = value; }
        }

        /// <summary>
        /// Obtiene o establece un valor que indica si el pasajero lleva equipaje de mano.
        /// </summary>
        public bool EquipajeDeMano
        {
            get { return equipajeDeMano; }
            set { equipajeDeMano = value; }
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Pasaje.
        /// </summary>
        public Pasaje()
        {
            ultimoIdPasaje++;
            this.IdPasaje = ultimoIdPasaje;
            this.equipajeDeBodega = 0.0;
            this.EquipajeDeMano = false;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Pasaje con los datos especificados.
        /// </summary>
        /// <param name="pasajero">El pasajero asociado al pasaje.</param>
        /// <param name="clase">La clase de pasajero del pasaje.</param>
        /// <param name="equipajeDeMano">Indica si el pasajero lleva equipaje de mano.</param>
        /// <param name="equipajeDeBodega">El peso del equipaje de bodega en kilogramos.</param>
        public Pasaje(Pasajero pasajero, ClasePasajero clase, bool equipajeDeMano, double equipajeDeBodega)
        {
            this.pasajero = pasajero;
            this.clase = clase;
            this.equipajeDeMano = equipajeDeMano;
            this.equipajeDeBodega = equipajeDeBodega;
        }
    }
}
