
using EntidadesParcial;
using Newtonsoft.Json;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string json = File.ReadAllText("MOCK_DATA.json");


            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);

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