using Entidades___Parcial_Laboratorio;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1er_ParcialLabo.BDD
{
    public class ProductosDAB
    {

        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        static ProductosDAB()
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

        public static List<Producto> traerProductos()
        {
            List<Producto> list = new List<Producto>();
            try
            {
                sqlCommand.CommandText = " select prod_nombre,prod_kilo,prod_precio,prod_stock from productos ";

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = (Producto)reader;

                    list.Add(producto);
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

        public static int ModProducto(string nombre, double kilo, double precio, double stock, Producto producto)
        {
            int filas = 0;

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update Productos set prod_nombre=@nombre ,prod_kilo=@kilo,prod_precio=@precio ,prod_stock= @stock where prod_nombre = @nombreBuscado";
                sqlCommand.Parameters.AddWithValue("@nombreBuscado", producto.nombre);
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                sqlCommand.Parameters.AddWithValue("@kilo", kilo);
                sqlCommand.Parameters.AddWithValue("@precio", precio);
                sqlCommand.Parameters.AddWithValue("@stock",stock);


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

        public static int ModStockProducto(double stock, Producto producto)
        {
            int filas = 0;

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update Productos set prod_stock= @stock where prod_nombre = @nombreBuscado";
                sqlCommand.Parameters.AddWithValue("@nombreBuscado", producto.nombre);
                sqlCommand.Parameters.AddWithValue("@stock", stock);


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

        public static int EliminarProducto(string nombre)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "delete Productos where prod_nombre=@nombre ";
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);


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

        public static int AddProducto(string nombre, double kilo, double precio, double stock)
        {
            int filas = 0;
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into Productos values(@nombre,@kilo,@precio,@stock)";
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                sqlCommand.Parameters.AddWithValue("@kilo", kilo);
                sqlCommand.Parameters.AddWithValue("@precio", precio);
                sqlCommand.Parameters.AddWithValue("@stock", stock);

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
    }


}
