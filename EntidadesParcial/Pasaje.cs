using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasaje
    {
        private Pasajero pasajero;
        //private Vuelo vuelo;
        private ClasePasajero clase;
        private double equipajeDeBodega;
        private bool equipajeDeMano;
        private int idPasaje;
        private static int ultimoIdPasaje = 0;


        public Pasajero Pasajero 
        { 
            get {  return pasajero; } 
            set {  pasajero = value; } 
        }
        /*public Vuelo Vuelo
        {
            get { return vuelo; }
            set {  vuelo = value; }
        }*/
        public ClasePasajero Clase
        {
            get { return clase; }
            set { clase = value; }
        }
        public double EquipajeDeBodega
        {
            get { return equipajeDeBodega; }
            set { equipajeDeBodega = value; }
        }
        public int IdPasaje 
        {
            get { return  idPasaje; }
            set { idPasaje = value; }
        }      
        public bool EquipajeDeMano
        {
            get { return equipajeDeMano; }
            set { equipajeDeMano = value; }
        }
        public Pasaje() 
        {
            ultimoIdPasaje++;
            this.IdPasaje = ultimoIdPasaje;
            this.equipajeDeBodega = 0.0;
            this.EquipajeDeMano = false;
        }
        public Pasaje(Pasajero pasajero, ClasePasajero clase) 
        {
            this.pasajero = pasajero;
            this.clase = clase;
        }

    }
}
