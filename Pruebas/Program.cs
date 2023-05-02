﻿
using EntidadesParcial;
using Newtonsoft.Json;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leer el contenido del archivo en una cadena
            string json = File.ReadAllText("MOCK_DATA.json");

            // Deserializar la cadena en una lista de objetos de tipo Usuario
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);

            // Recorrer la lista y mostrar la información de cada objeto
            foreach (var usuario in usuarios)
            {
             
                Console.WriteLine($"Legajo: {usuario.Legajo}");
                Console.WriteLine($"Correo: {usuario.Correo}");
                Console.WriteLine($"Clave: {usuario.Clave}");
                Console.WriteLine($"Perfil: {usuario.Perfil}");
                Console.WriteLine();
            }
        }
    }
}