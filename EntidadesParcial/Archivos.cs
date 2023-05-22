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
        private static string pathUsuarios;
        public static List<Usuario> usuarios;
        public static List<Aeronave> listaDeAeronaves;

        static Archivos() 
        {
            CargarUsuarios();
            CargarAeronaves();

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
        public static List<Aeronave> DevolverListaAeronave() 
        {        
            return listaDeAeronaves;
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

