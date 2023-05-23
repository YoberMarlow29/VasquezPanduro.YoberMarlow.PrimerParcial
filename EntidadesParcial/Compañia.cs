using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Compañia
    {

        public static void AltaDeAeronave(Aeronave nuevaAeronave)
        {
            if (nuevaAeronave is not null)
            {
                Archivos.listaDeAeronaves.Add(nuevaAeronave);
            }
        }
        public static void BajaDeAeronave(Aeronave bajaAeronave) 
        {
            if (bajaAeronave is not null)
            {
                Archivos.listaDeAeronaves.Remove(bajaAeronave);
            }
        }
        public static void ModificarAeronave(Aeronave modificaAeronave) 
        {
            List<Aeronave> nuevaLista = Archivos.DevolverListaAeronave();
            if (modificaAeronave is not null)
            {
                foreach (Aeronave item in nuevaLista) 
                {
                    if (item.Equals(modificaAeronave))                    
                    {
                        item.CantidadAsientos=modificaAeronave.CantidadAsientos;
                        item.CantidadBaños = modificaAeronave.CantidadBaños;
                        item.CapacidadBodega = modificaAeronave.CapacidadBodega;
                    }
                }
            }
        }
        public static void AltaDePasajeros(Pasajero nuevoPasajero) 
        {
            if (nuevoPasajero is not null)
            {
                Archivos.listaDePasajeros.Add(nuevoPasajero);
            }

        }

    }
}
