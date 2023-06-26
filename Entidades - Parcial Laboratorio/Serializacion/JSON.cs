using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Collections;
using Entidades___Parcial_Laboratorio.Interfaz;

namespace Entidades___Parcial_Laboratorio.Serializacion
{
    public class JSON<T> :IArchivo
    {
        private static StreamReader? reader;


        /// <summary>
        /// Deserializa un archivo JSON en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">El tipo de objetos a deserializar.</typeparam>
        /// <param name="pathFile">La ruta relativa o absoluta del archivo JSON.</param>
        /// <returns>Una lista de objetos del tipo especificado, obtenida a partir del archivo JSON.</returns>
        /// <remarks>
        /// El método lee el contenido del archivo JSON en la ruta especificada y lo deserializa en una lista de objetos del tipo especificado.
        /// Si el archivo no existe, se muestra un mensaje de error.
        /// Si ocurre algún error durante la deserialización, se muestra un mensaje de error con la descripción del problema.
        /// </remarks>


        public static List<T> Deserializar(string pathFile)
        {
            string path = Environment.CurrentDirectory + pathFile;
            List<T> lista = new List<T>();

            if (File.Exists(path))
            {
                try
                {
                    using (JSON<T>.reader = new StreamReader(path))
                    {
                        string jsonString = File.ReadAllText(path);
                        lista = JsonConvert.DeserializeObject<List<T>>(jsonString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al deserializar el JSON: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe: " + path);
            }

            return lista;
        }


        /// <summary>
        /// Serializa una lista de objetos en formato JSON y guarda el resultado en un archivo en la ruta especificada.
        /// </summary>
        /// <typeparam name="T1">El tipo de objetos contenidos en la lista.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="pathFile">La ruta relativa o absoluta del archivo donde se guardará la información serializada.</param>
        /// <remarks>
        /// El método utiliza la biblioteca Newtonsoft.Json para serializar la lista en formato JSON con formato legible.
        /// Si la lista no se puede convertir al tipo especificado, se muestra un mensaje de error.
        /// Si ocurre algún error durante la serialización, se muestra un mensaje de error con la descripción del problema.
        /// </remarks>
        public void Serializar<T1>(List<T1> lista, string pathFile)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + pathFile;

            try
            {
                List<T1> listaCasteada = lista as List<T1>;

                if (listaCasteada != null)
                {
                    string jsonString = JsonConvert.SerializeObject(listaCasteada, Formatting.Indented);
                    File.WriteAllText(path, jsonString);
                }
                else
                {
                    Console.WriteLine("Error al realizar el cast de la lista");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar la lista: " + ex.Message);
            }
        }
    }
}
