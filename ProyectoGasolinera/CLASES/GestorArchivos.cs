using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class GestorArchivos
    {
        public class RegistroAbastecimiento
        {
            public DateTime Fecha { get; set; }
            public string Cliente { get; set; }
            public string NIT { get; set; }
            public double Monto { get; set; }
            public double Litros { get; set; }
            public string Bomba { get; set; }
            public string TipoServicio { get; set; } 
        }

        public static class GestorArchivos
        {
            private static string archivo = "abastecimientos.json";

            // Guardar un registro en el archivo JSON
            public static void GuardarRegistro(RegistroAbastecimiento registro)
            {
                List<RegistroAbastecimiento> registros = new List<RegistroAbastecimiento>();

                if (File.Exists(archivo))
                {
                    string contenido = File.ReadAllText(archivo);
                    registros = JsonSerializer.Deserialize<List<RegistroAbastecimiento>>(contenido);
                }

                registros.Add(registro);

                string json = JsonSerializer.Serialize(registros, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(archivo, json);
            }

            // Leer todos los registros desde el archivo JSON
            public static List<RegistroAbastecimiento> LeerRegistros()
            {
                if (!File.Exists(archivo))
                    return new List<RegistroAbastecimiento>();

                string contenido = File.ReadAllText(archivo);
                return JsonSerializer.Deserialize<List<RegistroAbastecimiento>>(contenido);
            }
        }
    }
}
