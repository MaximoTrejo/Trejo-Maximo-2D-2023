using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades___Parcial_Laboratorio.Serializacion
{
    public class XML
    {
        public static void Serializar<T>(string pathFile, List<T> listaDato)
        {
            
            

            string path = Environment.CurrentDirectory + pathFile;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));
                    ser.Serialize(writer, listaDato);

                    Console.WriteLine("ok al Serializar los Datos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar los Datos");
            }
            
        }

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
