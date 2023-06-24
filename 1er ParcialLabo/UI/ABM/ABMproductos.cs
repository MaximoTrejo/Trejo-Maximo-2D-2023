using _1er_ParcialLabo.BDD;
using Entidades___Parcial_Laboratorio;
using Entidades___Parcial_Laboratorio.Serializacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1er_ParcialLabo
{
    public partial class ABMproductos : Form
    {
        /// <summary>
        /// El constructor de la clase ABMproductos recibe como parámetros una instancia de la clase HarcodeoDatos y un objeto Usuario. 
        /// Estos parámetros son asignados a las propiedades correspondientes de la clase para poder ser utilizados en otros métodos
        /// </summary>
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        public ABMproductos(HarcodeoDatos datos, Usuario usuario)
        {
            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
        }

        /// <summary>
        /// El método ABMproductos_Load se ejecuta cuando se carga el formulario ABMproductos. 
        /// Este método establece el origen de datos de un ListBox llamado ltbProductos con la lista de productos obtenida 
        /// mediante el método MostrarProducto() de la instancia de HarcodeoDatos almacenada en la variable datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ABMproductos_Load(object sender, EventArgs e)
        {


            //string pathFile = @"\datos\serializado.json"; // Ruta del archivo donde deseas guardar el JSON serializado
            //JSON<Producto>.Serializar(datos.listaProducto(), pathFile);
            //datos.CargarlistaProducto(JSON<Producto>.Deserializar(pathFile));

            //string pathFile = @"\datos\serializadoxml.xml"; // Ruta del archivo XML a deserializar
            //List<Producto> listaProducto = XML.Deserializar<Producto>(pathFile);

            //datos.CargarlistaProducto(listaProducto);

            ltbProductos.DataSource = datos.MostrarPoducto();

            //MessageBox.Show(datos.CargarlistaProducto(JSON<Producto>.Deserializar(pathFile)));


        }


        /// <summary>
        /// El método ltbProductos_SelectedIndexChanged se ejecuta cuando se selecciona un elemento de la lista de productos (ltbProductos). 
        /// Este método busca el producto seleccionado en la lista de productos mediante el nombre del producto y muestra la información 
        /// correspondiente del producto en los campos de texto (tbxnombre, tbxPesoKilo, txbPrecioKilo y tbtStock).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProducto = ltbProductos.Text;
            Producto producto = datos.buscarProductos(nombreProducto);
            tbxnombre.Text = nombreProducto;
            tbxPesoKilo.Text = producto.kilo.ToString();
            txbPrecioKilo.Text = producto.precioKilo.ToString();
            tbtStock.Text = producto.stock.ToString();
        }


        /// <summary>
        /// El método "btnVolver_Click" es un controlador de eventos que oculta el formulario actual y muestra un nuevo formulario de "Heladera" con los datos y el usuario pasados como parámetros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Heladera heladera = new Heladera(datos, usuarioLogeado);
            heladera.Show();
            this.Hide();
        }
        //----------------------------------------------------------------------------------------
        /// <summary>
        /// Funciones para permitir la interacción con los elementos visuales de la ventana.
        /// </summary>

        public int m;
        public int mx;
        public int my;
        private void pnlBordeSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pnlBordeSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlBordeSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------------------------


        /// <summary>
        /// El método "button2_Click" es un controlador de eventos que elimina un producto seleccionado de una lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombrePducto;
            nombrePducto = ltbProductos.Text;

            if (datos.eliminarProductos(datos.buscarProductos(nombrePducto)))
            {
                MessageBox.Show("Se elimino correctamente");
                ProductosDAB.EliminarProducto(nombrePducto);
                ltbProductos.DataSource = datos.MostrarPoducto();


                //string pathFile = @"\datos\serializado.json"; // Ruta del archivo donde deseas guardar el JSON serializado
                //JSON<Producto>.Serializar(datos.listaProducto(), pathFile);



                //////////////////////////////////////////////////////////////////////

                //List<Producto> listaProducto = datos.listaProducto(); // Obtener la lista de pasajeros que deseas serializar

                //string pathFilexml = @"\datos\serializadoxml.xml";

                //XML.Serializar<Producto>(pathFilexml, listaProducto);
            }
            else
            {
                MessageBox.Show("No se elimino correctamente");
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de "Modificar" y que permite modificar los datos de un producto existente en la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombrePducto = ltbProductos.Text;
            string nombretxt = tbxnombre.Text;
            double kilo;
            double precioKilo;
            double stock;
            //!string.IsNullOrEmpty(nombretxt) &&

            if (ValidacionesABM.ValidarString(nombretxt))
            {

                if (ValidacionesABM.ValidarDouble(tbxPesoKilo.Text))
                {

                    kilo = Double.Parse(tbxPesoKilo.Text);


                    if (ValidacionesABM.ValidarPeso(kilo))
                    {
                        if (ValidacionesABM.ValidarDouble(txbPrecioKilo.Text))
                        {
                            precioKilo = Double.Parse(txbPrecioKilo.Text);

                            if (ValidacionesABM.ValidarMonto(precioKilo))
                            {
                                if (ValidacionesABM.ValidarDouble(tbtStock.Text))
                                {
                                    stock = Double.Parse(tbtStock.Text);

                                    Producto ProductoBuscado = datos.buscarProductos(nombrePducto);

                                    if (Producto.modificarProductos(ProductoBuscado, nombretxt, kilo, precioKilo, stock))
                                    {
                                        MessageBox.Show("Se modifico", "Confimacion");
                                        ProductosDAB.ModProducto(nombretxt, kilo, precioKilo, stock, ProductoBuscado);
                                        //string pathFile = @"\datos\serializado.json"; // Ruta del archivo donde deseas guardar el JSON serializado
                                        //JSON<Producto>.Serializar(datos.listaProducto(), pathFile);
                                        ltbProductos.DataSource = datos.MostrarPoducto();//recorro la lista otra ves y se mostraria el dato modificado 
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se modifico", "Aviso");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se ingreso el stock", "Aviso");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Precio x Kilo maximo es de 100.000 ", "Aviso");
                            }




                        }
                        else
                        {
                            MessageBox.Show("No se ingreso el Precio x Kilo ", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Peso x Kilo maximo es de 10.000 ", "Aviso");
                    }



                }
                else
                {
                    MessageBox.Show("No se ingreso el Kilo", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("No se ingreso el nombre", "Aviso");
            }
        }

        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón "Aceptar".
        /// Su función es simplemente borrar el contenido de los cuadros de texto "tbxnombre", "tbxPesoKilo", "txbPrecioKilo" y "tbtStock"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbxnombre.Text = "";
            tbxPesoKilo.Text = "";
            txbPrecioKilo.Text = "";
            tbtStock.Text = "";
        }

        /// <summary>
        /// Maneja el evento click del botón "Aceptar" para agregar un nuevo producto a la lista de productos.
        /// Obtiene los valores de los campos de texto y los agrega como un nuevo producto a través del objeto "datos".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombretxt = tbxnombre.Text;
            double kilo;
            double precioKilo;
            double stock;

            if (ValidacionesABM.ValidarString(nombretxt))
            {

                if (ValidacionesABM.ValidarDouble(tbxPesoKilo.Text))
                {

                    kilo = Double.Parse(tbxPesoKilo.Text);

                    if (ValidacionesABM.ValidarPeso(kilo))
                    {
                        if (ValidacionesABM.ValidarDouble(txbPrecioKilo.Text))
                        {
                            precioKilo = Double.Parse(txbPrecioKilo.Text);

                            if (ValidacionesABM.ValidarMonto(precioKilo))
                            {
                                if (ValidacionesABM.ValidarDouble(tbtStock.Text))
                                {
                                    stock = Double.Parse(tbtStock.Text);


                                    try {

                                        if (datos.agregarProductos(nombretxt, kilo, precioKilo, stock))
                                        {
                                            MessageBox.Show("Se agrego correctamente");
                                            ProductosDAB.AddProducto(nombretxt, kilo, precioKilo, stock);
                                            //string pathFile = @"\datos\serializado.json"; // Ruta del archivo donde deseas guardar el JSON serializado
                                            //JSON<Producto>.Serializar(datos.listaProducto(), pathFile);
                                            ltbProductos.DataSource = datos.MostrarPoducto();
                                        }
                                    }
                                    catch (ProductoExistenteException ex)
                                    {
                                        MessageBox.Show("No se agrego correctamente,el Producto ya existe");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("No se ingreso el stock", "Aviso");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Precio x Kilo maximo es de 100.000 ", "Aviso");
                            }




                        }
                        else
                        {
                            MessageBox.Show("No se ingreso el Precio x Kilo ", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Peso x Kilo maximo es de 10.000 ", "Aviso");
                    }


                }
                else
                {
                    MessageBox.Show("No se ingreso el Kilo", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("No se ingreso el nombre", "Aviso");
            }
        }

        private void btnExportarProductos_Click(object sender, EventArgs e)
        {
            
       
            if (rBtnJSON.Checked == true)
            {
                string pathFile = @"\Productos.json";
                JSON<Producto> jSON = new JSON<Producto>();
                jSON.Serializar(datos.listaProducto(), pathFile);
      
            }
            else if (rBtnXML.Checked == true)
            {
                string pathFile = @"\Productos.xml";
                List<Producto> listaProducto = datos.listaProducto();
                XML xML = new XML();
                xML.Serializar<Producto>(listaProducto,pathFile);
   
            }

            
            
        }
    }
}
