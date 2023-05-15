using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Archivos
    {

        public List<T> DeserializarLista<T>(string path)
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
                    throw new FileNotFoundException("El archivo no existe.", path);
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
        public void SerializarLista<T>(List<T> lista, string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path)) { }
                }

                string json = JsonConvert.SerializeObject(lista);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista: " + ex.Message, ex);
            }
        }
    }
}

