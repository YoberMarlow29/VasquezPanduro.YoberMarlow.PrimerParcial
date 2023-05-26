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
    public static class Archivos
    {
        public static string pathAeronaves;
        public static string pathUsuarios;
        public static string pathPasajeros;
        public static string pathVuelo;
        public static List<Usuario> usuarios;
        public static List<Aeronave> listaDeAeronaves;
        public static List<Pasajero> listaDePasajeros;
        public static List<Vuelo> listaDeViaje;
        public static List<string> localidades;
        static Archivos() 
        {
            CargarUsuarios();
            CargarAeronaves();
            CargarPasajeros();
            CargarViajes();
            CargarLocalidades();

        }
        private static void CargarUsuarios()   
        {
            pathUsuarios = "MOCK_DATA.json";
            usuarios = new List<Usuario>();
            usuarios=DeserializarListaJson<Usuario>(pathUsuarios);

        }
        private static void CargarAeronaves() 
        {
            pathAeronaves = "Aeronaves.json";
            listaDeAeronaves = new List<Aeronave>();
            listaDeAeronaves = DeserializarListaJson<Aeronave>(pathAeronaves);
        }
        private static void CargarPasajeros() 
        {
            pathPasajeros = "Pasajeros.xml";
            listaDePasajeros = new List<Pasajero>();         
            listaDePasajeros = DeserializarListaXml<Pasajero>(pathPasajeros);
        }
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
        private static void CargarViajes()
        {

            pathVuelo = "Viajes.xml";
            listaDeViaje = new List<Vuelo>();
            listaDeViaje = DeserializarListaXml<Vuelo>(pathVuelo);
        }

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
        public static void SerializarListaJson<T>(List<T> lista,string path)
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

