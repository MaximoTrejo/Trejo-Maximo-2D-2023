using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_ParcialLabo.BDD
{
    public class FacturacionDAB
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        static FacturacionDAB()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            sqlConnection = new SqlConnection(@" Data source = .\UTN;
            DataBase = UTN_PDV; 
            Trusted_Connection = true;"
            );

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        


    }
}
