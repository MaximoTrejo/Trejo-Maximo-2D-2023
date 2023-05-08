using System;
using System.Collections.Generic;
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
        public Vendedor(string Email, string Pass) : base(Email, Pass)
        {

        }

        /// <summary>
        ///metodo "validarVendedor" utilizo un modificador "override", para sobrescribir el comportamiento de un método con el mismo nombre y firma en su clase padre. 
        /// </summary>
        /// <returns></returns>
        public override bool validarVendedor () {

            return true;
        }


    }
}
