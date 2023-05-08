using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class Usuario
    {
        /// <summary>
        /// Clase llamada "Usuario" que tiene dos campos de datos públicos llamados "Email" y "Pass" que representan el correo electrónico y la contraseña de un usuario.
        /// </summary>
        public string Email;
        public string Pass;
        public Usuario(string Email, string Pass)
        {
            this.Email = Email;
            this.Pass = Pass;
        }

        /// <summary>
        /// funcion que valida que un vendedor sea del tipo vendedor
        /// </summary>
        /// <returns></returns>
        public virtual bool validarVendedor()
        {
            return false;
        }

        /// <summary>
        /// recorro la lista de usuarios y paso el saldo que tiene el usuario el cual me lo pasan por parametros
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static double buscarImporte(Usuario usuario)
        {

            Clientes clientes;
            foreach (Usuario i in HarcodeoDatos.Usuarios)
            {
                clientes = (Clientes)i;
                return clientes.importe;
            }
            return 0;
        }


        /// <summary>
        /// le paso un usuario por parametros y devuelvo el nombre del tipo(vendedor , cliente)
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static string categoriaUsuarios(Usuario usuario)
        {
            Type type = usuario.GetType();
            return type.Name;
        }

        

    }
}
