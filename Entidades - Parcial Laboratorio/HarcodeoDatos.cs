using _1er_ParcialLabo.BDD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Entidades___Parcial_Laboratorio
{

    public class HarcodeoDatos
    {
        /// <summary>
        /// El código define una clase que contiene cuatro listas diferentes. 
        /// </summary>

        public static List<Usuario> Usuarios = new List<Usuario>();

        public  List<Producto> Producto = new List<Producto>();

        public  List<Producto> CarritoCompra = new List<Producto>();

        public  static List<Facturacion> encabezadoTicket = new List<Facturacion>();

        public static List<string> strings = new List<string>();

        /// <summary>
        /// Harcodeo de Usuarios y Productos
        /// </summary>
        public HarcodeoDatos()
        {
            
            //Usuario cli1 = new Clientes ("mail1@gmail,com", "11111", 120);
            //Usuario cli2 = new Clientes("mail2@gmail,com", "11111", 520);
            //Usuario cli3 = new Clientes("mail3@gmaill,com", "11111", 20);
            //Usuario cli4 = new Clientes("mail4@gmail,com", "11111", 0);
            //Usuario cli5 = new Clientes("mail5@gmail,com", "11111", 38);
            //Usuario vendedor1 = new Vendedor ( "admin1@gmail,com", "22222" );
            //Usuario vendedor2 = new Vendedor("admin2@gmail,com", "22222");
            //Usuario vendedor3 = new Vendedor("admin3@gmail,com", "22222");
            //Usuario vendedor4 = new Vendedor("admin4@gmail,com", "22222");
            //Usuario vendedor5 = new Vendedor("admin5@gmail,com", "22222");

            //Usuarios.Add(cli1);
            //Usuarios.Add(cli2);
            //Usuarios.Add(cli3);
            //Usuarios.Add(cli4);
            //Usuarios.Add(cli5);

            //Usuarios.Add(vendedor1);
            //Usuarios.Add(vendedor2);
            //Usuarios.Add(vendedor3);
            //Usuarios.Add(vendedor4);
            //Usuarios.Add(vendedor5);

            //Producto.Add(new Producto ("Carne", 5, 100, 5 ));
            //Producto.Add(new Producto ("Pollo", 2,120, 2 ));
            //Producto.Add(new Producto("Vacio", 6, 20, 3));
            //Producto.Add(new Producto("Chorizo", 1, 19, 6));
            //Producto.Add(new Producto("Morcilla", 10, 5, 10));

            cargarProductosList();

        }


        /// <summary>
        /// Harcodeo de facturacion
        /// </summary>
        public static void cargadoTicket()
        {
            List<string> Productos1 = new List<string>() { "Chori", "Matambre" };
            List<string> Productos2 = new List<string>() { "Vacio", "Chinculin" };
            List<string> Productos3 = new List<string>() { "Pollo", "Matambre" };

            List<int> Cantidad1 = new List<int>() { 4, 2 };
            List<int> Cantidad2 = new List<int>() { 1, 10 };
            List<int> Cantidad3 = new List<int>() { 3, 1 };

            List<int> Precio1 = new List<int>() { 30, 20 };
            List<int> Precio2 = new List<int>() { 40, 10 };
            List<int> Precio3 = new List<int>() { 30, 20 };

            encabezadoTicket.Add(new Facturacion("Mail1", 160, Productos1, Cantidad1, Precio1));
            encabezadoTicket.Add(new Facturacion("Mail2", 140, Productos2, Cantidad2, Precio2));
            encabezadoTicket.Add(new Facturacion("Mail3", 110, Productos3, Cantidad3, Precio3));
        }

        /// <summary>
        /// Recoore la lista de Usaurios y compara el mail y pass con los parametros del metodo y retorna un usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Usuario ListaValido(string mail, string pass)
        {
            if (mail is not null && pass is not null)
            {
                foreach (Usuario i in Usuarios)
                {

                    if (i.Email.Equals(mail) && i.Pass.Equals(pass))
                    {
                        return i;
                    }
                }
                

            }
            return null;
        }
       

        /// <summary>
        /// Recorre la lista de productos y guarda el nombre en una lista de tipo string 
        /// </summary>
        /// <returns></returns>
        public List<string> MostrarPoducto()
        {
            List <string> prod = new List<string>();

            foreach (Producto i in Producto)
            {
                if (i is not null)
                {
                    prod.Add(i.nombre);
                }
            }
            return prod;
        }


        /// <summary>
        /// Recorre la lista usuarios y guarda en una lista de tipo string ell mail de los usuarios
        /// </summary>
        /// <returns></returns>
        public List<string> MostrarUsuarios()
        {
            List<string> usu = new List<string>();

            foreach (Usuario i in Usuarios)
            {
                if (i is not null)
                {
                    usu.Add(i.Email);
                }
            }
            return usu;
        }
        

        /// <summary>
        /// Recorre la lista de tipo Productos y valida que el nombre que paso por parametros y el nombre del producto sean iguales y retorno el producto
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Producto buscarProductos(string nombre)
        {
            foreach(Producto i in Producto) { 
                
                if(i.nombre == nombre)
                {
                    return i;
                }
            }
            return null;
        }

        /// <summary>
        /// Recorro la lista de tipo Usuarios y valido que el mail sea igual que al que paso por parametros y devuelvo el usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public Usuario buscarUsuario(string mail)
        {
            foreach (Usuario i in Usuarios)
            {

                if (i.Email == mail)
                {
                    return i;
                }
            }
            return null;
        }

        /// <summary>
        /// Cargo los productos que le paso a por parametros y la cantidad de productos 
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantProd"></param>
        /// <returns></returns>
        public bool cargarProductosAlCarrito(Producto producto, int cantProd)
        {
            bool retorno = false;

            if(producto is not null && cantProd > 0)
            {
                for (int i=0;i < cantProd;i++)
                {
                    CarritoCompra.Add(producto);
                }
                retorno= true;
            }

            return retorno;

        }

        /// <summary>
        /// recorro la lista carrito y sumo los importes de los productos guardados en la lista
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public double sumarImporte(List<Producto> producto)
        {
            double suma =0;


            if (producto is not null)
            {
                foreach (Producto i in CarritoCompra)
                {
                    suma = i.precioKilo + suma;
                    
                }
            }
            return suma;
        }

        /// <summary>
        /// recorro la lista de carrito y guardo los productos en otra lista de tipo inta para saber el precio por unidad
        /// </summary>
        /// <returns></returns>
        public List<int> precioUnidad()
        {
            List<int> prodUni = new List<int>();

            foreach (Producto i in CarritoCompra)
            {
                prodUni.Add(((int)i.precioKilo));

            }
            return prodUni;
        }

        /// <summary>
        /// recorro la lista de carrito y guardo los nombres de los productos en otra lista de tipo string y devuelvo la lista
        /// </summary>
        /// <returns></returns>
        public List<string> obtenerNombresProductos()
        {
            List<string> nombreProd = new List<string>();

            foreach (Producto i in CarritoCompra)
            {
                nombreProd.Add(i.nombre);

            }
            return nombreProd;
        }


       


        /// <summary>
        /// valido que el el usuario quiera pagar con credito y le suma al importe del carrito un 5% de recarga
        /// </summary>
        /// <param name="importeCarrito"></param>
        /// <param name="medioPago"></param>
        /// <returns></returns>
        public double PagoCreditoImporte(double importeCarrito , string medioPago)
        {
            double suma = 0;

            if (importeCarrito > 0 && medioPago != null)
            {
                if (medioPago == "Credito")
                {
                    suma = (5*importeCarrito/100)+importeCarrito;
                }
                else
                {
                    suma = importeCarrito;
                }
            }
            return suma;
        }

        /// <summary>
        /// Agrego un nuevo  productro a la lista de productos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="kilo"></param>
        /// <param name="precioKilo"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public bool agregarProductos(string nombre, double kilo, double precioKilo, double stock)
        {
            bool retorno = false;

            if (nombre != null && kilo > 0 && precioKilo > 0 && stock > 0)
            {

                Producto usuaBuscado = buscarProductos(nombre);

                if (usuaBuscado is null)
                {
                    Producto.Add(new Producto(nombre, kilo, precioKilo, stock));
                    retorno = true;
                }
                else
                {
                    throw new ProductoExistenteException("El producto ya existe");
                    retorno = false;
                }

            }
            return retorno;
        }


        /// <summary>
        /// Elimino el producto que paso por parametro de la lista de productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool eliminarProductos(Producto producto)
        {
            bool retorno = false;

            if (producto is not null)
            {
                Producto.Remove(producto);
                retorno = true;
            }


            return retorno;
        }

        /// <summary>
        /// Carga los clientes en la lista de usuarios
        /// </summary>
        public static void cargarClientesList()
        {
            var listClientes = ClientesBDD.traerCliente();
            
            foreach (var item in listClientes)
            {
                Usuarios.Add(item);
            }


        }

        /// <summary>
        /// Carga los vendedores a la lista de usuarios
        /// </summary>
        public static void cargarVendedoresList()
        {
            var listVendedores = VendedoresDAB.traerVendedor();

            foreach (var item in listVendedores)
            {
                Usuarios.Add(item);
            }


        }

        /// <summary>
        /// Carga los productos a la lista de productos
        /// </summary>
        private void cargarProductosList()
        {
            var listProductos = ProductosDAB.traerProductos();

            foreach (var item in listProductos)
            {
                Producto.Add(item);
            }


        }


        /// <summary>
        /// Crea una lista de productos y te la devuelve con los datos que esta en la lista principal
        /// </summary>
        /// <returns></returns>
        public List<Producto> listaProducto()
        {
            List<Producto> prod = new List<Producto>();

            foreach (Producto i in Producto)
            {
                if (i is not null)
                {
                    prod.Add(i);
                }
            }
            return prod;
        }

        /// <summary>
        /// Carga la lista de productos cargada con el Json
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public List<Producto> CargarlistaProducto(List<Producto> json)
        {
            // Asigna la lista de productos en formato JSON al objeto "Producto"
            Producto = json;
            // Devuelve la lista de productos cargada
            return Producto;
        }



        /// <summary>
        /// Obtiene los datos de facturación de una lista de objetos Facturacion y devuelve una cadena de texto.
        /// </summary>
        /// <param name="listaFacturacion">Lista de objetos Facturacion.</param>
        /// <returns>Representación de cadena de texto de los datos de facturación.</returns>
        public static string  ObtenerDatosFacturacion(List<Facturacion> listaFacturacion)
        {
            List<string> datosFacturacion = new List<string>();

            // Iterar sobre cada objeto Facturacion en la lista
            foreach (Facturacion factura in listaFacturacion)
            {
                string datos = $"Email: {factura.Email}, Precio Total: {factura.PrecioTotal}";

                // Concatenar los datos de cada producto
                for (int i = 0; i < factura.nombreProductos.Count; i++)
                {
                    string producto = factura.nombreProductos[i];
                    int cantidad = factura.Cantidades[i];
                    int precioUnidad = factura.PrecioUnidad[i];

                    string datosProducto = $"\nProducto: {producto}, Cantidad: {cantidad}, Precio Unidad: {precioUnidad}";
                    datos += datosProducto;
                }

                datos += "\n"; // Agregar una línea vacía al final del bloque
                datosFacturacion.Add(datos);
            }
            // retorna todas las representaciones de cadena de texto de los datos de facturación
            return string.Join("\n", datosFacturacion);
        }

        /// <summary>
        /// recorro la lista de usuarios y paso el saldo que tiene el usuario el cual me lo pasan por parametros
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static double buscarImporte(Usuario usuario)
        {

            Clientes clientes;
            foreach (Usuario i in Usuarios)
            {
                if (i == usuario)
                {
                    clientes = (Clientes)i;
                    return clientes.importe;
                }
                    
            }
            return 0;
        }

        /// <summary>
        /// Agrega un vendedor a la lista de usuarios 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pass"></param>
        /// <param name="usuario"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool agregarVendedor(string nombre, string pass, Usuario usuario, string tipo)
        {
            bool retorno = false;

            if (nombre != null && pass != null)
            {
                if (tipo == "Vendedor")
                {
                    Usuarios.Add(new Vendedor(nombre, pass));
                    retorno = true;
                }
            }
            return retorno;
        }

    }



}
