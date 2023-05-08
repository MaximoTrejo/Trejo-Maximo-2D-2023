using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class Producto
    {
        /// <summary>
        /// El constructor Producto se utiliza para inicializar las propiedades de un objeto Producto con los valores proporcionados.
        /// </summary>
        public string nombre { get; set; }
        public double kilo { get; set; }
        public double precioKilo { get; set; }
        public double stock { get; set; }

        public Producto(string nombre, double kilo, double precioKilo, double stock)
        {
            this.nombre = nombre;
            this.kilo = kilo;
            this.precioKilo = precioKilo;
            this.stock = stock;
        }

        /// <summary>
        /// Este método llamado "Mostrar" devuelve una cadena de texto que representa una descripción del objeto de la clase "Producto".
        /// La descripción incluye el nombre y el precio por kilo del producto. 
        /// Se utiliza un objeto StringBuilder para construir la cadena de texto y luego se devuelve como un string.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            string mensaje;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} \nPrecio: {this.precioKilo} ");
            mensaje = sb.ToString();
            return mensaje;
        }


        /// <summary>
        /// develve una lista de productos con el producto que pasan por parametros 
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public  static List<Producto> detallaProductos(Producto producto)
        {
            HarcodeoDatos datos = new HarcodeoDatos();

            List<Producto> productoEspecifico = new List<Producto>();

            if (producto is not null)
            {
                productoEspecifico.Add(producto);
            }


            return productoEspecifico;
        }

        /// <summary>
        /// recorre la lista de productos y valida que el stock que tenga el producto sea menor que la cantidad que paso por parametros 
        /// </summary>
        /// <param name="listaProducto"></param>
        /// <param name="producto"></param>
        /// <param name="cantProd"></param>
        /// <returns></returns>
        public static bool hayStock(List<Producto> listaProducto, string producto, int cantProd)
        {
            if (listaProducto is not null)
            {
                foreach (Producto i in listaProducto)
                {
                    if (i.stock >= cantProd && i.nombre == producto)
                    {
                        return true;
                    }

                }
            }
            return false;

        }

        /// <summary>
        /// recorro la lista de productos y la lista de carritos y si estos son iguales redusco el stock que hay que mi lista de prodcutos 
        /// </summary>
        /// <param name="listaProducto"></param>
        /// <param name="listaCarrito"></param>
        /// <returns></returns>
        public static bool reducirStock(List<Producto> listaProducto, List<Producto> listaCarrito)
        {

            bool retorno = false;

            if (listaProducto is not null && listaCarrito is not null)
            {
                foreach (Producto j in listaCarrito)
                {
                    foreach (Producto i in listaProducto)
                    {
                        if (i == j)
                        {
                            i.stock = i.stock - 1;

                        }
                    }
                }
                retorno = true;
            }
            return retorno;

        }

        /// <summary>
        /// modifico los datos les producto dependiendo de lo que mandan por parametros
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="nombre"></param>
        /// <param name="kilo"></param>
        /// <param name="precioKilo"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static bool modificarProductos(Producto Producto, string nombre, double kilo, double precioKilo, double stock)
        {
            bool retorno = false;

            if (Producto is not null)
            {
                Producto.nombre = nombre;
                Producto.kilo = kilo;
                Producto.precioKilo = precioKilo;
                Producto.stock = stock;
                retorno = true;

            }

            return retorno;
        }











        /// <summary>
        /// El método sobrecargado "==" compara si dos objetos de tipo Producto tienen el mismo nombre, 
        /// mientras que el método sobrecargado "!=" compara si dos objetos de tipo Producto no tienen el mismo nombre.
        /// Ambos métodos devuelven un valor booleano indicando si se cumple la condición o no.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Producto p1 , Producto p2)
        {
            return p1.nombre == p2.nombre;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.nombre == p2.nombre);
        }

    }
}

