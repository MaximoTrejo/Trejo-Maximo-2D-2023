using _1er_ParcialLabo.BDD;
using Entidades___Parcial_Laboratorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class Clientes : Usuario 
    {


        /// <summary>
        /// Clase llamada "Clientes" que tiene un campo "importe" y un constructor que acepta tres parámetros: "Email", "Pass" e "importe"
        /// </summary>
        public double importe;//propiedades ,atributos

        //metodo contructor
        public Clientes(string Email, string Pass,double importe) : base(Email, Pass)
        {
            this.importe = importe;
        }

        /// <summary>
        /// valida que el importe del cliente sea mayor al importe del ticket y si esto es verdadero le resta el importe del ticket al importe del cliente
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="importeTotal"></param>
        /// <returns></returns>
        public static bool reducirImporte(Usuario usuario, double importeTotal)
        {
            
            Clientes clientes;
            double importeCliente;

            clientes = (Clientes)usuario;
            importeCliente = clientes.importe;


            if (clientes.importe > importeTotal)
            {
                clientes.importe = clientes.importe - importeTotal;
                return true;
            }
            return false;
        }

        /// <summary>
        /// compara el saldo del cliente con el saldo del ticket (funcion resumida de Reducir Importe)
        /// </summary>
        /// <param name="saldoCliente"></param>
        /// <param name="importeTotal"></param>
        /// <returns></returns>
        public static bool compararImportes(double saldoCliente, double importeTotal,string cliente)
        {
            HarcodeoDatos datos = new HarcodeoDatos();
            double cuenta;

            if (saldoCliente > 0 && importeTotal > 0)
            {
                if (saldoCliente >= importeTotal)
                {
                    cuenta = saldoCliente - importeTotal;
                    
                    Usuario cliBuscado = datos.buscarUsuario(cliente);

                    reducirImporte(cliBuscado, importeTotal);

                    ClientesBDD.ModImporteCliente(cuenta, cliBuscado);

                    return true;
                }
            }

            return false;

        }


        /// <summary>
        /// Valida que el usuario sea del tipo clientes y guarda el importe 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="importe"></param>
        /// <returns></returns>
        public static bool cargarImporte(Usuario usuario, double importe)
        {
            bool retorno = false;

            Clientes clientes;

            if (usuario is not null)
            {
                if (!(usuario.validarVendedor()))
                {
                    clientes = (Clientes)usuario;
                    clientes.importe = importe;
                    retorno = true;

                }

            }

            return retorno;
        }

        /// <summary>
        /// Muestra solo una lista de clientes
        /// </summary>
        /// <returns></returns>
        public static List<string> MostrarClientes()
        {
            List<string> cli = new List<string>();

            foreach (Usuario i in HarcodeoDatos.Usuarios)
            {

                if (i is not null)
                {
                    if (!(i.validarVendedor()))
                    {
                        cli.Add(i.Email);
                    }

                }
            }
            return cli;
        }

        /// <summary>
        /// Modifica los clientes 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pass"></param>
        /// <param name="usuario"></param>
        /// <param name="importe"></param>
        /// <returns></returns>
        public static bool modificarClientes(string nombre, string pass, Usuario usuario, double importe)
        {
            bool retorno = false;

            Clientes clientes;

            if (usuario is not null)
            {
                clientes = (Clientes)usuario;
                clientes.Email = nombre;
                clientes.Pass = pass;
                clientes.importe = importe;
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// elimina clientes de la lista usuarios
        /// </summary>
        /// <param name="usu"></param>
        /// <returns></returns>
        public static bool eliminarCliente(Usuario usu)
        {
            bool retorno = false;

            if (usu is not null)
            {
                HarcodeoDatos.Usuarios.Remove(usu);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// agrega clientes a la lista de usuarios
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pass"></param>
        /// <param name="usuario"></param>
        /// <param name="importe"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool agregarClientes(string nombre, string pass, Usuario usuario, double importe)
        {
            bool retorno = false;

            if (nombre != null && pass != null)
            {
                HarcodeoDatos datos = new HarcodeoDatos();

                Usuario usuaBuscado = datos.buscarUsuario(nombre);

                if (usuaBuscado is null)
                {
                    HarcodeoDatos.Usuarios.Add(new Clientes(nombre, pass, importe)); ;
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
        /// Convierte un objeto SqlDataReader en un objeto Clientes.
        /// </summary>
        /// <param name="v">Objeto SqlDataReader a convertir.</param>
        /// <returns>Objeto Clientes convertido.</returns>
        public static explicit operator Clientes(SqlDataReader v)
        {

            Clientes u = new(v["cli_mail"].ToString(), v["cli_clave"].ToString(), Convert.ToInt32(v["cli_importe"]));
            return u;
        }
    }
}
