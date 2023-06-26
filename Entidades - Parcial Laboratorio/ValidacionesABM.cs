using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio
{
    public class ValidacionesABM
    {
        /// <summary>
        /// Metodo encargada de validar si un string sea un string , 
        /// intenta convertir el valor string(entrada a un int si es verdadedo pasa) lo mismo con el double 
        /// y verifica que no este vacio 
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public static bool ValidarString(string entrada)
        {
            int num;
            double num2;

            if (entrada is string)
            {
                if (!int.TryParse(entrada, out num) && !double.TryParse(entrada, out num2))
                {

                    if (!string.IsNullOrEmpty(entrada))
                    {
                        // La entrada es un valor de tipo string
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // La entrada no es un valor de tipo string
                return false;
            }
        }

        /// <summary>
        /// Valida que una cadena de string se trasnforme en un double ,
        /// primero valida que no este vacia 
        /// y despues intenta convertir el valor de entrada en una variable de tipo double
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public static bool ValidarDouble(string entrada)
        {
            double num;

            if (!string.IsNullOrEmpty(entrada))
            {
                if(double.TryParse(entrada, out num))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Valida que el monto no supere los 100000
        /// </summary>
        /// <param name="monto"></param>
        /// <returns></returns>
        public static bool ValidarMonto(double monto)
        {
            if (monto <= 100000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida que el peso no supere los 100000
        /// </summary>
        /// <param name=peso></param>
        /// <returns></returns>
        public static bool ValidarPeso(double peso)
        {
            if (peso <= 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }



}
