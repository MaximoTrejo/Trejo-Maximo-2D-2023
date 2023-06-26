using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Entidades___Parcial_Laboratorio.Interfaz;

namespace Entidades___Parcial_Laboratorio.Serializacion
{
    public class XML : IArchivo
    {



        /// <summary>
        /// Serializa una lista de objetos genéricos y los guarda en un archivo XML en la ruta especificada.
        /// </summary>
        /// <typeparam name="T">El tipo de objetos en la lista.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="pathFile">La ruta del archivo donde se guardará la lista serializada.</param>
        public void Serializar<T>(List<T> lista,string pathFile)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + pathFile ;//Environment.CurrentDirectory + pathFile;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                    ser.Serialize(writer, lista);

                    Console.WriteLine("ok al Serializar los Datos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar los Datos");
            }
            
        }


        /// <summary>
        /// Deserializa un archivo XML en la ubicación especificada y devuelve una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">El tipo de objeto que se va a deserializar.</typeparam>
        /// <param name="pathFile">La ruta del archivo XML a deserializar.</param>
        /// <returns>Una lista de objetos del tipo especificado.</returns>
        public static List<T> Deserializar<T>(string pathFile)
        {
            string path = Environment.CurrentDirectory + pathFile;
            List<T> lista = new List<T>();

            if (File.Exists(path))
            {
                try
                {
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                        lista = (List<T>)ser.Deserialize(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al deserializar el archivo XML: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe: " + path);
            }

            return lista;
        }

    }
}
