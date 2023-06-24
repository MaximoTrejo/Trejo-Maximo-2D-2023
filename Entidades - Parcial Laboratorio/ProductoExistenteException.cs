using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class ProductoExistenteException : Exception
    {
        public ProductoExistenteException(string mensaje) : base(mensaje)
        {
        }
    }
}
