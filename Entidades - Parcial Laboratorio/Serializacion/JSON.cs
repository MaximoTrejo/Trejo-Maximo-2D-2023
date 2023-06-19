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

namespace Entidades___Parcial_Laboratorio.Serializacion
{
    public class JSON<T>
    {
        private static StreamReader? reader;

        
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



        public static void Serializar(List<T> lista, string pathFile)
        {
            string path = Environment.CurrentDirectory + pathFile;

                try
                {
                    List<T> listaCasteada = lista as List<T>;
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
