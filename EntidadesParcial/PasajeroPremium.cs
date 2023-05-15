using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class PasajeroPremium:Pasajero
    {
        private Pasajero pasajeroTurista;
        private double[] equipajeDeBodega;
        public PasajeroPremium(double[] equipajeDeBodega) : base()
        {
            if (equipajeDeBodega[0] + equipajeDeBodega[1] <= 21)
            {
                this.equipajeDeBodega = equipajeDeBodega;
            }
        }
    }
}
