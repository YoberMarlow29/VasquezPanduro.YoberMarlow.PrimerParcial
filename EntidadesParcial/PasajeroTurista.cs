using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class PasajeroTurista : Pasajero
    {
        private Pasajero pasajeroTurista;
        private double equipajeDeBodega;

        public PasajeroTurista(double equipajeDeBodega) :base()
        {           
            if (equipajeDeBodega <= 25) 
            {
                this.equipajeDeBodega = equipajeDeBodega;
            }
        }




    }
}
