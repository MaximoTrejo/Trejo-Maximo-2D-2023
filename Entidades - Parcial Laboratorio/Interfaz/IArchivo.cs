using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Parcial_Laboratorio.Interfaz
{
    public interface IArchivo 
    {
        public void Serializar<T>(List<T> lista, string pathFile);
    }
}
