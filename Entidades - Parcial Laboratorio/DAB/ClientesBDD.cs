using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_ParcialLabo.BDD
{
    public class ClientesBDD
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        static ClientesBDD()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            sqlConnection = new SqlConnection(@" Data source = .\UTN;
            DataBase = UTN_PDV; 
            Trusted_Connection = true;");

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<Clientes> traerCliente()
        {
            List<Clientes> list = new List<Clientes>();
            try
            {
                sqlCommand.CommandText = " select cli_mail,cli_clave,cli_importe from clientes ";

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Clientes cliente = (Clientes)reader;

                    list.Add(cliente);
                }

            }
            catch (Exception)
            {
                

            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return list;
        }


        public static int AddClientes(string mail, string clave ,double importe)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into CLIENTES values(@mail,@clave,@Importe)";
                sqlCommand.Parameters.AddWithValue("@mail",mail);
                sqlCommand.Parameters.AddWithValue("@clave", clave);
                sqlCommand.Parameters.AddWithValue("@Importe", importe);

                filas = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return filas;
        }


        public static int ModUsuarios(string mail, string clave, double importe , Usuario usuario)
        {
            int filas = 0;


            Clientes cli;
            cli = (Clientes)usuario;

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update CLIENTES set cli_mail=@mail ,cli_clave=@clave,cli_importe=@Importe where cli_mail=@mailBuscado ";
                sqlCommand.Parameters.AddWithValue("@mailBuscado", cli.Email);
                sqlCommand.Parameters.AddWithValue("@mail", mail);
                sqlCommand.Parameters.AddWithValue("@clave", clave);
                sqlCommand.Parameters.AddWithValue("@Importe", importe);
               

                filas = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return filas;
        }
        public static int EliminarCliente(string mail)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "delete CLIENTES where cli_mail=@mail ";
                sqlCommand.Parameters.AddWithValue("@mail", mail);


                filas = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return filas;
        }
    }
}
