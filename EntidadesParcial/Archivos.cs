using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace EntidadesParcial
{
    /// <summary>
    /// Clase estática que proporciona métodos para cargar y guardar datos en archivos.
    /// </summary>
    public static class Archivos
    {
        /// <summary>
        /// Ruta del archivo de aeronaves.
        /// </summary>
        public static string pathAeronaves;

        /// <summary>
        /// Ruta del archivo de usuarios.
        /// </summary>
        public static string pathUsuarios;

        /// <summary>
        /// Ruta del archivo de pasajeros.
        /// </summary>
        public static string pathPasajeros;

        /// <summary>
        /// Ruta del archivo de vuelos.
        /// </summary>
        public static string pathVuelo;

        /// <summary>
        /// Lista de usuarios cargada desde el archivo.
        /// </summary>
        public static List<Usuario> listaDeUsuarios;

        /// <summary>
        /// Lista de aeronaves cargada desde el archivo.
        /// </summary>
        public static List<Aeronave> listaDeAeronaves;

        /// <summary>
        /// Lista de pasajeros cargada desde el archivo.
        /// </summary>
        public static List<Pasajero> listaDePasajeros;

        /// <summary>
        /// Lista de vuelos cargada desde el archivo.
        /// </summary>
        public static List<Vuelo> listaDeViaje;

        /// <summary>
        /// Lista de localidades predefinidas.
        /// </summary>
        public static List<string> localidades;

        /// <summary>
        /// Constructor estático que inicializa las listas y carga los datos desde los archivos.
        /// </summary>
        static Archivos()
        {
            listaDeUsuarios = new List<Usuario>();
            listaDeAeronaves = new List<Aeronave>();
            listaDePasajeros = new List<Pasajero>();
            localidades = new List<string>();
            listaDeViaje = new List<Vuelo>();
            pathAeronaves = "";
            pathUsuarios = "";
            pathPasajeros = "";
            pathVuelo = "";

            CargarUsuarios();
            CargarAeronaves();
            CargarPasajeros();
            CargarViajes();
            CargarLocalidades();
        }

        /// <summary>
        /// Carga los usuarios desde el archivo JSON especificado en la ruta.
        /// </summary>
        private static void CargarUsuarios()
        {
            pathUsuarios = "MOCK_DATA.json";
            listaDeUsuarios = DeserializarListaJson<Usuario>(pathUsuarios);
        }

        /// <summary>
        /// Carga las aeronaves desde el archivo JSON especificado en la ruta.
        /// </summary>
        private static void CargarAeronaves()
        {
            pathAeronaves = "Aeronaves.json";
            listaDeAeronaves = DeserializarListaJson<Aeronave>(pathAeronaves);
        }

        /// <summary>
        /// Carga los pasajeros desde el archivo XML especificado en la ruta.
        /// </summary>
        private static void CargarPasajeros()
        {
            pathPasajeros = "Pasajeros.xml";
            listaDePasajeros = DeserializarListaXml<Pasajero>(pathPasajeros);
        }

        /// <summary>
        /// Carga las localidades predefinidas.
        /// </summary>
        private static void CargarLocalidades()
        {
            localidades = new List<string>()
        {
            "Buenos Aires",
            "Santa Rosa",
            "Bariloche",
            "Corrientes",
            "Córdoba",
            "Jujuy",
            "Mendoza",
            "Neuquén",
            "Posadas",
            "Iguazú",
            "Salta",
            "Santiago del Estero",
            "Trelew",
            "Tucumán",
            "Puerto Madryn",
            "Ushuaia",
            "Recife(Brasil)",
            "Roma(Italia)",
            "Acapulco(México)",
            "Miami(EEUU)"
        };
        }

        /// <summary>
        /// Carga los vuelos desde el archivo XML especificado en la ruta.
        /// </summary>
        private static void CargarViajes()
        {
            pathVuelo = "Viajes.xml";
            listaDeViaje = DeserializarListaXml<Vuelo>(pathVuelo);
        }

        /// <summary>
        /// Deserializa un archivo JSON en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>La lista de objetos deserializados.</returns>
        public static List<T> DeserializarListaJson<T>(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    List<T> lista = JsonConvert.DeserializeObject<List<T>>(json);
                    return lista;
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new List<T>();
                }
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException("Error de deserialización en el archivo '" + path + "': " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo '" + path + "': " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Serializa una lista de objetos en formato JSON y guarda el resultado en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a serializar.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="path">Ruta del archivo JSON.</param>
        public static void SerializarListaJson<T>(List<T> lista, string path)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo '" + path + "': " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Deserializa un archivo XML en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>La lista de objetos deserializados.</returns>
        public static List<T> DeserializarListaXml<T>(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                    using (FileStream fileStream = new FileStream(path, FileMode.Open))
                    {
                        List<T> lista = (List<T>)serializer.Deserialize(fileStream);
                        return lista;
                    }
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo XML '" + path + "': " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Serializa una lista de objetos en formato XML y guarda el resultado en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a serializar.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="path">Ruta del archivo XML.</param>
        public static void SerializarListaXml<T>(List<T> lista, string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, lista);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista en formato XML y guardar en el archivo '" + path + "': " + ex.Message, ex);
            }
        }
    }
}

