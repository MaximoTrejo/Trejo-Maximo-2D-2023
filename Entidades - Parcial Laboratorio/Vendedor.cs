using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class Vendedor  : Usuario
    {
        /// <summary>
        /// clase llamada "Vendedor" que hereda los parametros de otra clase. La clase "Vendedor" tiene un constructor que acepta dos parámetros de tipo cadena: "Email" y "Pass".
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Pass"></param>
        public Vendedor(string Email, string Pass) : base(Email, Pass){}

        /// <summary>
        ///metodo "validarVendedor" utilizo un modificador "override", para sobrescribir el comportamiento de un método con el mismo nombre y firma en su clase padre. 
        /// </summary>
        /// <returns></returns>
        public override bool validarVendedor () {

            return true;
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

                    HarcodeoDatos datos = new HarcodeoDatos();

                    Usuario usuaBuscado = datos.buscarUsuario(nombre);

                    if (usuaBuscado is null)
                    {
                        HarcodeoDatos.Usuarios.Add(new Vendedor(nombre, pass));
                        retorno = true;
                    }
                    else
                    {
                        throw new ProductoExistenteException("El Usuario ya existe");
                        retorno = false;
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// Modifica el vendedor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pass"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool modificarVendedor(string nombre, string pass, Usuario usuario)
        {
            bool retorno = false;

            if (usuario is not null)
            {
                usuario.Email = nombre;
                usuario.Pass = pass;
                retorno = true;

            }

            return retorno;
        }

        /// <summary>
        /// Muestra solo una lista de los vendedores
        /// </summary>
        /// <returns></returns>
        public static List<string> MostrarVendedores()
        {
            List<string> vend = new List<string>();

            foreach (Usuario i in HarcodeoDatos.Usuarios)
            {

                if (i is not null)
                {
                    if (i.validarVendedor())
                    {
                        vend.Add(i.Email);
                    }

                }
            }
            return vend;
        }

        /// <summary>
        /// Convierte un objeto SqlDataReader en un objeto Vendedor
        /// </summary>
        /// <param name="v">Objeto SqlDataReader a convertir.</param>
        /// <returns>Objeto Clientes convertido.</returns>
        public static explicit operator Vendedor(SqlDataReader v)
        {

            Vendedor u = new(v["vend_mail"].ToString(), v["vend_clave"].ToString());
            return u;
        }
    }
}








