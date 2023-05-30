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
        public static void AltaDeVuelo(Vuelo vueloAAgregar)
        {
            if (vueloAAgregar is not null)
            {
                Archivos.listaDeViaje.Add(vueloAAgregar);
            }
        }
        public static void BajaDeVuelo(Vuelo bajaViaje)
        {
            if (bajaViaje is not null)
            {
                Archivos.listaDeViaje.Remove(bajaViaje);
            }
        }
        public static void AltaDeUsuario(Usuario usuarioAgregar) 
        {
            if (usuarioAgregar is not null)
            {
                Archivos.listaDeUsuarios.Add(usuarioAgregar);
            }
        }

        public static void ValidarCompraDeClase(Vuelo vuelo, Pasaje pasajero, List<Pasaje> pasajesAComprar)
        {
            int contadorPremium = 0;
            int contadorTurista = 0;
            foreach (Pasaje item in pasajesAComprar)
            {
                if (item.Clase == ClasePasajero.Premium)
                {
                    contadorPremium++;
                }
                else
                {
                    contadorTurista++;
                }
            }
            if ((pasajero.Clase == ClasePasajero.Turista && vuelo.Tursita + contadorTurista + 1 > vuelo.Aeronave.Tursita) ||
                pasajero.Clase == ClasePasajero.Premium && vuelo.Premium + contadorPremium + 1 > vuelo.Aeronave.Premium)
            {
                throw new Exception($"Ya no hay disponibilidad para Pasajeros {pasajero.Clase} en este vuelo");
            }
        }
        private static void InicializarDestinosFavorito(Dictionary<string, int> destinoFavorito)
        {
            foreach (string item in Archivos.localidades)
            {
                destinoFavorito.Add(item, 0);
            }
        }
        private static void ContarVuelosPorDesitno(Dictionary<string, int> destinoFavorito)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                destinoFavorito[item.Destino]++;
            }
        }
        public static string BuscarDestinoFavorito()
        {
            string favorito = "Ninguno";
            int cantidadMayor = -1;
            bool primero = true;
            Dictionary<string, int> destinoFavorito = new Dictionary<string, int>();

            InicializarDestinosFavorito(destinoFavorito);
            ContarVuelosPorDesitno(destinoFavorito);
            foreach (KeyValuePair<string, int> item in destinoFavorito)
            {
                if (primero || cantidadMayor < item.Value)
                {
                    cantidadMayor = item.Value;
                    favorito = item.Key;
                    primero = false;
                }

                    //favorito = "Ninguno";
            }
            return favorito;
        }
        public static string InformarGananciaTotalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaTotal();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        public static string InformarGananciaNacionalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaNacional();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        public static string InformarGananciaInternacionalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaInternacional();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        public static Dictionary<string, string> CargarDiccionarioHistorialDeVuelosPorFacturacion()
        {
            Dictionary<string, double> destinoFacturadosDouble = new Dictionary<string, double>();
            foreach (string item in Archivos.localidades)
            {
                destinoFacturadosDouble.Add(item, 0);
            }
            AcumularValoresDeGanacia(destinoFacturadosDouble);
            return ConvertirConOrdenamientoDeStringDoubleAStringString(destinoFacturadosDouble);
        }
        private static void AcumularValoresDeGanacia(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                dic[item.Destino] += item.GananciaTotal();
            }
        }
        private static Dictionary<string, string> ConvertirConOrdenamientoDeStringDoubleAStringString(Dictionary<string, double> dic)
        {
            List<KeyValuePair<string, double>> lista;

            lista = dic.ToList();
            lista.Sort(OrdenarDiccionarioStringDoublePorValorDescendente);
            return ConvertirDiccionarioPasarDoubleAString(lista);
        }
        private static int OrdenarDiccionarioStringDoublePorValorDescendente(KeyValuePair<string, double> p1, KeyValuePair<string, double> p2)
        {
            return (int)(p2.Value - p1.Value);
        }
        private static Dictionary<string, string> ConvertirDiccionarioPasarDoubleAString(List<KeyValuePair<string, double>> lista)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> item in lista)
            {
                diccionario[item.Key] = $"$ {item.Value.ToString("0.00")} USD";
            }
            return diccionario;
        }
        public static Dictionary<string, string> CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas()
        {
            Dictionary<string, double> horasDeAeronaves = new Dictionary<string, double>();
            foreach (Aeronave item in Archivos.listaDeAeronaves)
            {
                horasDeAeronaves.Add(item.Matricula, 0);
            }
            ContarHorasMinutos(horasDeAeronaves);
            return ConvertirDiccionarioYCalcularHorarioParaInformar(horasDeAeronaves);
        }
        private static void ContarHorasMinutos(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                dic[item.Aeronave.Matricula] += item.Duracion;
            }
        }
        private static Dictionary<string, string> ConvertirDiccionarioYCalcularHorarioParaInformar(Dictionary<string, double> horaAeronave)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string minutos;
            foreach (KeyValuePair<string, double> item in horaAeronave)
            {
                minutos = ((int)((item.Value - (int)item.Value) * 60)).ToString();
                if ((int)((item.Value - (int)item.Value) * 60) < 10)
                {
                    minutos = $"0{(int)((item.Value - (int)item.Value) * 60)}";
                }
                dict[item.Key] = $"{((int)item.Value)}:{minutos}";
            }
            return dict;
        }
    }
}
