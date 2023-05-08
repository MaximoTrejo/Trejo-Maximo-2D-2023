using System;
using System.Collections.Generic;
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
        public static bool compararImportes(double saldoCliente, double importeTotal)
        {

            if (saldoCliente > 0 && importeTotal > 0)
            {
                if (saldoCliente >= importeTotal)
                {
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


    }
}
