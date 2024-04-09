using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class SerializadorArchivos<T>
    {
        /// <summary>
        /// Método encargado de serializar en un archivo json un dato genérico.
        /// </summary>
        /// <param name="datos">dato a serializar.</param>
        /// <param name="rutaArchivo">ruta en la que se almacenará el json.</param>
        public void Serializar(T datos, string rutaArchivo)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    string datosJson = JsonSerializer.Serialize(datos, options);
                    sw.Write(datosJson);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al serializar: {ex.Message}");
            }
        }
        public T Deserializar(string rutaArchivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string jsonString = sr.ReadToEnd();
                    var datos = JsonSerializer.Deserialize<T>(jsonString);
                    return datos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar", ex);
            }
        }
    }
}
