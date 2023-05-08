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

        public static List<Facturacion> encabezadoTicket ;


        /// <summary>
        /// Harcodeo de Usuarios y Productos
        /// </summary>
        public HarcodeoDatos()
        {
            encabezadoTicket= new List<Facturacion>();

            cargadoTicket();

            Usuario cli1 = new Clientes ("mail1@gmail,com", "11111", 120);
            Usuario cli2 = new Clientes("mail2@gmail,com", "11111", 520);
            Usuario cli3 = new Clientes("mail3@gmaill,com", "11111", 20);
            Usuario cli4 = new Clientes("mail4@gmail,com", "11111", 0);
            Usuario cli5 = new Clientes("mail5@gmail,com", "11111", 38);
            Usuario vendedor1 = new Vendedor ( "admin1@gmail,com", "22222" );
            Usuario vendedor2 = new Vendedor("admin2@gmail,com", "22222");
            Usuario vendedor3 = new Vendedor("admin3@gmail,com", "22222");
            Usuario vendedor4 = new Vendedor("admin4@gmail,com", "22222");
            Usuario vendedor5 = new Vendedor("admin5@gmail,com", "22222");

            Usuarios.Add(cli1);
            Usuarios.Add(cli2);
            Usuarios.Add(cli3);
            Usuarios.Add(cli4);
            Usuarios.Add(cli5);

            Usuarios.Add(vendedor1);
            Usuarios.Add(vendedor2);
            Usuarios.Add(vendedor3);
            Usuarios.Add(vendedor4);
            Usuarios.Add(vendedor5);

            Producto.Add(new Producto ("Carne", 5, 100, 5 ));
            Producto.Add(new Producto ("Pollo", 2,120, 2 ));
            Producto.Add(new Producto("Vacio", 6, 20, 3));
            Producto.Add(new Producto("Chorizo", 1, 19, 6));
            Producto.Add(new Producto("Morcilla", 10, 5, 10));

        }
        /// <summary>
        /// Harcodeo de facturacion
        /// </summary>
        public void cargadoTicket()
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
            
            foreach (Usuario i in Usuarios)
            {
                
                if (i.Email.Equals(mail) && i.Pass.Equals(pass))
                {
                    return i;
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
                Producto.Add(new Producto(nombre, kilo, precioKilo, stock));
                retorno = true;
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

      

























        //---------------------------------------Terminar de codear AMB usuarios------------------------------------------------------------

        public bool agregarUsuarios(string nombre, string pass, Usuario usuario, double importe, string tipo)
        {
            bool retorno = false;

            if (nombre != null && pass != null)
            {
                if (tipo == "Vendedor")
                {
                    Usuarios.Add(new Vendedor(nombre, pass));
                    retorno = true;
                }
                else
                {
                    Usuarios.Add(new Clientes(nombre, pass, importe)); ;
                    retorno = true;
                }

            }
            return retorno;
        }

        public bool eliminarUsuario(Usuario usu)
        {
            bool retorno = false;

            if (Usuarios is not null)
            {
                Usuarios.Remove(usu);
                retorno = true;
            }
            return retorno;
        }


        public bool modificarUsuarios(string nombre, string pass, Usuario usuario, double importe)
        {
            bool retorno = false;

            Clientes clientes;

            if (usuario is not null)
            {
                if (usuario.validarVendedor())
                {
                    usuario.Email = nombre;
                    usuario.Pass = pass;
                    retorno = true;
                }
                else
                {
                    clientes = (Clientes)usuario;
                    clientes.Email = nombre;
                    clientes.Pass = pass;
                    clientes.importe = importe;
                    retorno = true;
                }

            }

            return retorno;
        }

        //---------------------------------------Terminar de codear AMB usuarios------------------------------------------------------------

    }



}
