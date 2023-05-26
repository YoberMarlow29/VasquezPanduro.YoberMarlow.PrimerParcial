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

        public static void AltaDePasajeros(Pasajero nuevoPasajero)
        {
            if (nuevoPasajero is not null)
            {
                Archivos.listaDePasajeros.Add(nuevoPasajero);
            }

        }
        public static void BajaDePasajero(Pasajero bajaPasajero)
        {
            if (bajaPasajero is not null)
            {
                Archivos.listaDePasajeros.Remove(bajaPasajero);
            }
        }
        public static Aeronave BuscarAeronavePorMatricula(string matricula)
        {
            foreach (Aeronave item in Archivos.listaDeAeronaves)
            {
                if (item.Matricula == matricula)
                {
                    return item;
                }
            }
            return null;
        }
        public static void AltaDeVuelo(Viaje vueloAAgregar)
        {
            if (vueloAAgregar is not null)
            {
                Archivos.listaDeViaje.Add(vueloAAgregar);
            }
        }
        public static void BajaDeVuelo(Viaje bajaViaje)
        {
            if (bajaViaje is not null)
            {
                Archivos.listaDeViaje.Remove(bajaViaje);
            }
        }
    }


}
