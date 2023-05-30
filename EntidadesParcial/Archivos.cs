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
        public static List<Usuario> listaDeUsuarios;
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
            listaDeUsuarios = new List<Usuario>();
            listaDeUsuarios = DeserializarListaJson<Usuario>(pathUsuarios);

        }
        private static void CargarAeronaves() 
        {

            pathAeronaves = "Aeronaves.json";
            listaDeAeronaves= new List<Aeronave>();
            if (File.Exists(pathAeronaves))
            {
                listaDeAeronaves = DeserializarListaJson<Aeronave>(pathAeronaves);
            }
            else
            {
                listaDeAeronaves = GenerarListaAeronavesAleatorias(30);
                SerializarListaJson<Aeronave>(listaDeAeronaves, pathAeronaves);
            }
        }
        private static void CargarPasajeros() 
        {
            pathPasajeros = "Pasajeros.xml";
            listaDePasajeros = new List<Pasajero>();

            if (File.Exists(pathPasajeros))
            {
                listaDePasajeros = DeserializarListaXml<Pasajero>(pathPasajeros);
            }
            else
            {
                listaDePasajeros = GenerarListaPasajerosAleatorios(150);
                SerializarListaXml<Pasajero>(listaDePasajeros, pathPasajeros);
            }
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
        private static List<Aeronave> GenerarListaAeronavesAleatorias(int cantidadAeronaves)
        {
            List<Aeronave> listaAeronaves = new List<Aeronave>();

            for (int i = 0; i < cantidadAeronaves; i++)
            {
                Aeronave aeronave = CrearAeronaveAleatoria();
                listaAeronaves.Add(aeronave);
            }

            return listaAeronaves;
        }

        private static Aeronave CrearAeronaveAleatoria()
        {
            Random random = new Random();

            string matricula = GenerarMatriculaAleatoria();
            int cantidadAsientosTotales = random.Next(1, 1201); // Rango de 1 a 1200
            int cantidadBanios = random.Next(1, 13); // Rango de 1 a 12
            double capacidadBodega = random.Next(2000, 15001); // Rango de 2000 a 15000

            Aeronave aeronave = new Aeronave(matricula, cantidadAsientosTotales, cantidadBanios, capacidadBodega);

            return aeronave;
        }

        private static string GenerarMatriculaAleatoria()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] matricula = new char[8];

            for (int i = 0; i < 8; i++)
            {
                matricula[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(matricula);
        }
        private static List<Pasajero> GenerarListaPasajerosAleatorios(int cantidadPasajeros)
        {
            List<Pasajero> listaPasajeros = new List<Pasajero>();

            for (int i = 0; i < cantidadPasajeros; i++)
            {
                Pasajero pasajero = CrearPasajeroAleatorio();
                listaPasajeros.Add(pasajero);
            }

            return listaPasajeros;
        }

        private static Pasajero CrearPasajeroAleatorio()
        {
            Random random = new Random();
            string nombre = GenerarNombreAleatorio();
            string apellido = GenerarApellidoAleatorio();
            int edad = random.Next(1, 101); // Rango de 1 a 100
            int dni = random.Next(1000000, 100000000); // Rango de 1000000 a 99999999

            Pasajero pasajero = new Pasajero(nombre, apellido, edad, dni);

            return pasajero;
        }

        private static string GenerarNombreAleatorio()
        {
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Diego", "Carolina", "Miguel", "Valentina", "José", "Sofía", "Casandra", "Megan", "Adolf", "Cleopatra","Luffy","Zoro","Naruto", "Chavo","Goku","Kirito","Segundina","Jessica","Erza","Sasuke"}; 
            Random random = new Random();
            return nombres[random.Next(nombres.Length)];
        }

        private static string GenerarApellidoAleatorio()
        {
            string[] apellidos = { "Gómez", "Pérez", "López", "Rodríguez", "González", "Martínez", "Fernández", "Giménez", "Silva", "Torres", "Hernández", "García","Hitler","Macri","Messi","Davis","Jordan","Sapito","Uzumaki","Hatake", "Uchiha", "Tsukiyama", "Senju", "Yukimura" };
            Random random = new Random();
            return apellidos[random.Next(apellidos.Length)];
        }
        

    }
}

