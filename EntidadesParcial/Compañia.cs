using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Compañia
    {
        /// <summary>
        /// Agrega una nueva aeronave a la lista de aeronaves de la compañía.
        /// </summary>
        /// <param name="nuevaAeronave">La nueva aeronave a agregar.</param>
        public static void AltaDeAeronave(Aeronave nuevaAeronave)
        {
            if (nuevaAeronave is not null)
            {
                Archivos.listaDeAeronaves.Add(nuevaAeronave);
            }
        }
        /// <summary>
        /// Elimina una aeronave de la lista de aeronaves de la compañía.
        /// </summary>
        /// <param name="bajaAeronave">La aeronave a dar de baja.</param>
        public static void BajaDeAeronave(Aeronave bajaAeronave)
        {
            if (bajaAeronave is not null)
            {
                Archivos.listaDeAeronaves.Remove(bajaAeronave);
            }
        }
        /// <summary>
        /// Agrega un nuevo pasajero a la lista de pasajeros de la compañía.
        /// </summary>
        /// <param name="nuevoPasajero">El nuevo pasajero a agregar.</param>
        public static void AltaDePasajeros(Pasajero nuevoPasajero)
        {
            if (nuevoPasajero is not null)
            {
                Archivos.listaDePasajeros.Add(nuevoPasajero);
            }

        }
        /// <summary>
        /// Elimina un pasajero de la lista de pasajeros de la compañía.
        /// </summary>
        /// <param name="bajaPasajero">El pasajero a dar de baja.</param>
        public static void BajaDePasajero(Pasajero bajaPasajero)
        {
            if (bajaPasajero is not null)
            {
                Archivos.listaDePasajeros.Remove(bajaPasajero);
            }
        }
        /// <summary>
        /// Busca una aeronave por su matrícula.
        /// </summary>
        /// <param name="matricula">La matrícula de la aeronave a buscar.</param>
        /// <returns>La aeronave encontrada o null si no se encuentra.</returns>
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
        /// <summary>
        /// Agrega un nuevo vuelo a la lista de vuelos de la compañía.
        /// </summary>
        /// <param name="vueloAAgregar">El vuelo a agregar.</param>
        public static void AltaDeVuelo(Vuelo vueloAAgregar)
        {
            if (vueloAAgregar is not null)
            {
                Archivos.listaDeViaje.Add(vueloAAgregar);
            }
        }

        /// <summary>
        /// Elimina un vuelo de la lista de vuelos de la compañía.
        /// </summary>
        /// <param name="bajaViaje">El vuelo a dar de baja.</param>
        public static void BajaDeVuelo(Vuelo bajaViaje)
        {
            if (bajaViaje is not null)
            {
                Archivos.listaDeViaje.Remove(bajaViaje);
            }
        }
        /// <summary>
        /// Agrega un nuevo usuario a la lista de usuarios de la compañía.
        /// </summary>
        /// <param name="usuarioAgregar">El usuario a agregar.</param>
        public static void AltaDeUsuario(Usuario usuarioAgregar) 
        {
            if (usuarioAgregar is not null)
            {
                Archivos.listaDeUsuarios.Add(usuarioAgregar);
            }
        }
        /// <summary>
        /// Valida la compra de un pasaje de una determinada clase en un vuelo.
        /// </summary>
        /// <param name="vuelo">El vuelo en el que se desea comprar el pasaje.</param>
        /// <param name="pasajero">El pasajero que desea comprar el pasaje.</param>
        /// <param name="pasajesAComprar">La lista de pasajes a comprar.</param>
        /// <exception cref="Exception">Se lanza una excepción si no hay disponibilidad para la clase de pasajero en el vuelo.</exception>
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
            if ((pasajero.Clase == ClasePasajero.Turista && vuelo.Tursita + contadorTurista + 1 > vuelo.Aeronave.Turista) ||
                pasajero.Clase == ClasePasajero.Premium && vuelo.Premium + contadorPremium + 1 > vuelo.Aeronave.Premium)
            {
                throw new Exception($"Ya no hay disponibilidad para Pasajeros {pasajero.Clase} en este vuelo");
            }
        }

        /// <summary>
        /// Inicializa el diccionario de destinos favoritos con todas las localidades y un contador inicial de 0.
        /// </summary>
        /// <param name="destinoFavorito">El diccionario de destinos favoritos a inicializar.</param>
        private static void InicializarDestinosFavorito(Dictionary<string, int> destinoFavorito)
        {
            foreach (string item in Archivos.localidades)
            {
                destinoFavorito.Add(item, 0);
            }
        }
        /// <summary>
        /// Cuenta la cantidad de vuelos por destino y actualiza el diccionario de destinos favoritos.
        /// </summary>
        /// <param name="destinoFavorito">El diccionario de destinos favoritos a actualizar.</param>
        private static void ContarVuelosPorDesitno(Dictionary<string, int> destinoFavorito)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                destinoFavorito[item.Destino]++;
            }
        }
        /// <summary>
        /// Busca y devuelve el destino más favorito basado en el número de vuelos hacia ese destino.
        /// </summary>
        /// <returns>El destino más favorito o "Ninguno" si no se encontró ningún destino.</returns>
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

            }
            return favorito;
        }
        /// <summary>
        /// Calcula y devuelve la ganancia total de todos los vuelos de la compañía.
        /// </summary>
        /// <returns>La ganancia total en formato de cadena de texto.</returns>
        public static string InformarGananciaTotalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaTotal();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        /// <summary>
        /// Calcula y devuelve la ganancia nacional de todos los vuelos de la compañía.
        /// </summary>
        /// <returns>La ganancia nacional en formato de cadena de texto.</returns>
        public static string InformarGananciaNacionalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaNacional();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        /// <summary>
        /// Calcula y devuelve la ganancia internacional de todos los vuelos de la compañía.
        /// </summary>
        /// <returns>La ganancia internacional en formato de cadena de texto.</returns>
        public static string InformarGananciaInternacionalDeLosVuelos()
        {
            double ganancia = 0;
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                ganancia += item.GananciaInternacional();
            }
            return $"$ {ganancia.ToString("0.00")} USD";
        }
        /// <summary>
        /// Carga un diccionario con el historial de vuelos por facturación, ordenado por la facturación acumulada de cada destino.
        /// </summary>
        /// <returns>El diccionario con el historial de vuelos por facturación en formato (destino, facturación) como cadena de texto.</returns>
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
        /// <summary>
        /// Acumula los valores de ganancia total de cada destino en un diccionario.
        /// </summary>
        /// <param name="dic">El diccionario donde se acumularán los valores de ganancia.</param>
        private static void AcumularValoresDeGanacia(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                dic[item.Destino] += item.GananciaTotal();
            }
        }
        /// <summary>
        /// Convierte un diccionario con ordenamiento de clave-valor de tipo string-double a un diccionario de tipo string-string.
        /// </summary>
        /// <param name="dic">El diccionario a convertir.</param>
        /// <returns>El diccionario convertido con los valores en formato de cadena de texto.</returns>
        private static Dictionary<string, string> ConvertirConOrdenamientoDeStringDoubleAStringString(Dictionary<string, double> dic)
        {
            List<KeyValuePair<string, double>> lista;

            lista = dic.ToList();
            lista.Sort(OrdenarDiccionarioStringDoublePorValorDescendente);
            return ConvertirDiccionarioPasarDoubleAString(lista);
        }
        /// <summary>
        /// Ordena un diccionario de tipo string-double por valor de forma descendente.
        /// </summary>
        /// <param name="p1">El primer par clave-valor a comparar.</param>
        /// <param name="p2">El segundo par clave-valor a comparar.</param>
        /// <returns>Un valor entero que indica el resultado de la comparación.</returns>
        private static int OrdenarDiccionarioStringDoublePorValorDescendente(KeyValuePair<string, double> p1, KeyValuePair<string, double> p2)
        {
            return (int)(p2.Value - p1.Value);
        }
        /// <summary>
        /// Convierte un diccionario de tipo string-double a un diccionario de tipo string-string con el valor en formato de cadena de texto.
        /// </summary>
        /// <param name="lista">La lista de pares clave-valor a convertir.</param>
        /// <returns>El diccionario convertido con los valores en formato de cadena de texto.</returns>
        private static Dictionary<string, string> ConvertirDiccionarioPasarDoubleAString(List<KeyValuePair<string, double>> lista)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> item in lista)
            {
                diccionario[item.Key] = $"$ {item.Value.ToString("0.00")} USD";
            }
            return diccionario;
        }
        /// <summary>
        /// Cuenta la cantidad de horas voladas por cada aeronave y carga un diccionario con la matrícula de la aeronave y su tiempo de vuelo.
        /// </summary>
        /// <returns>El diccionario con la cantidad de horas voladas por cada aeronave en formato (matrícula, tiempo de vuelo) como cadena de texto.</returns>
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
        /// <summary>
        /// Cuenta las horas y minutos volados por cada aeronave y actualiza el diccionario con el tiempo de vuelo.
        /// </summary>
        /// <param name="dic">El diccionario donde se almacenará el tiempo de vuelo por cada aeronave.</param>
        private static void ContarHorasMinutos(Dictionary<string, double> dic)
        {
            foreach (Vuelo item in Archivos.listaDeViaje)
            {
                dic[item.Aeronave.Matricula] += item.Duracion;
            }
        }
        /// <summary>
        /// Convierte el diccionario con el tiempo de vuelo de cada aeronave a formato de cadena de texto y calcula el horario de vuelo.
        /// </summary>
        /// <param name="horaAeronave">El diccionario con el tiempo de vuelo de cada aeronave.</param>
        /// <returns>El diccionario con el horario de vuelo de cada aeronave en formato (matrícula, horario) como cadena de texto.</returns>
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
