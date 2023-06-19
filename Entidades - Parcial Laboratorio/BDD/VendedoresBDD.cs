using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_ParcialLabo.BDD
{
    public class VendedoresBDD
    {


        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        static VendedoresBDD()
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; otra forma de hacerlo
            sqlConnection = new SqlConnection(@" Data source = .\UTN;
            DataBase = UTN_PDV; 
            Trusted_Connection = true;");

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<Vendedor> traerVendedor()
        {
            List<Vendedor> list = new List<Vendedor>();
            try
            {
                sqlCommand.CommandText = " select vend_mail,vend_clave from Vendedores ";

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Vendedor vendedor = (Vendedor)reader;

                    list.Add(vendedor);
                }

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
            return list;
        }

        public static int AddVendedores(string mail, string clave)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into VENDEDORES values(@mail,@clave)";
                sqlCommand.Parameters.AddWithValue("@mail", mail);
                sqlCommand.Parameters.AddWithValue("@clave", clave);

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

        public static int ModVendedores(string mail, string clave)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update VENDEDORES set vend_mail=@mail ,vend_clave=@clave where vend_mail=@mail";
                sqlCommand.Parameters.AddWithValue("@mail", mail);
                sqlCommand.Parameters.AddWithValue("@clave", clave);

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

        public static int EliminarVendedores(string mail)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "delete VENDEDORES where vend_mail=@mail ";
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
