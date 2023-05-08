using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class Facturacion
    {
        /// <summary>
        ///La clase Facturacion representa un ticket de compra generado por el sistema, 
        ///incluyendo información del usuario que realiza la compra, 
        ///el total a pagar y los detalles de los productos comprados
        ///El constructor de la clase permite inicializar estos datos para generar el ticket correspondiente. 
        /// </summary>
        public string Email;
        public List<string> nombreProductos;
        public List<int> Cantidades;// = new List<Producto>();
        public List<int> PrecioUnidad;
        public double PrecioTotal;


        public Facturacion(string Email, double PrecioTotal ,List<string> Producto, List<int> Cantidades, List<int> PrecioUnidad)
        {
            this.Email = Email;
            this.nombreProductos = Producto;
            this.Cantidades = Cantidades;
            this.PrecioTotal = PrecioTotal;
            this.PrecioUnidad = PrecioUnidad;     
        }

        /// <summary>
        /// La función MostrarFacturacion retorna una cadena de texto con la información de la facturación
        /// </summary>
        /// <returns></returns>
        public string MostrarFacturacion()
        {
            string resultado = $"Email: {Email}\n";
            resultado += $"Productos:\n";
            for (int i = 0; i < nombreProductos.Count; i++)//recorro la lista de los nombres de los productos y con el indice me voy moviendo 
            {
                resultado += $"\t{nombreProductos[i]} - {Cantidades[i]} x ${PrecioUnidad[i]} = ${Cantidades[i] * PrecioUnidad[i]}\n";
            }
            resultado += $"Precio Total: ${PrecioTotal}\n";
            return resultado;
        }

        /// <summary>
        /// trae el la lista de facturacion 
        /// </summary>
        /// <returns></returns>
        public static List<Facturacion> traerTicket()
        {

            return HarcodeoDatos.encabezadoTicket;
        }
    }
}