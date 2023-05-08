using Entidades___Parcial_Laboratorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ltbProductos.DataSource = datos.MostrarPoducto();
 
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
            string nombreProducto= ltbProductos.Text;
            Producto producto = datos.buscarProductos(nombreProducto);
            tbxnombre.Text = nombreProducto;
            tbxPesoKilo.Text = producto.kilo.ToString();
            txbPrecioKilo.Text = producto.precioKilo.ToString();
            tbtStock.Text = producto.stock.ToString();
        }

        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón "Aceptar".
        /// Su función es simplemente borrar el contenido de los cuadros de texto "tbxnombre", "tbxPesoKilo", "txbPrecioKilo" y "tbtStock"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            tbxnombre.Text = "";
            tbxPesoKilo.Text = "";
            txbPrecioKilo.Text = "";
            tbtStock.Text = "";
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de "Modificar" y que permite modificar los datos de un producto existente en la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string nombrePducto = ltbProductos.Text;
            string nombretxt = tbxnombre.Text;
            double kilo = Double.Parse(tbxPesoKilo.Text);
            double precioKilo = Double.Parse(txbPrecioKilo.Text);
            double stock = Double.Parse(tbtStock.Text);
           

            if (Producto.modificarProductos(datos.buscarProductos(nombrePducto), nombretxt, kilo, precioKilo, stock))
            {
                MessageBox.Show("se modifico");
                ltbProductos.DataSource = datos.MostrarPoducto();//recorro la lista otra ves y se mostraria el dato modificado 
            }
            else
            {
                MessageBox.Show("no se modifico");
            }
        }


        /// <summary>
        /// Maneja el evento click del botón "Aceptar" para agregar un nuevo producto a la lista de productos.
        /// Obtiene los valores de los campos de texto y los agrega como un nuevo producto a través del objeto "datos".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string nombretxt = tbxnombre.Text;
            double kilo = Double.Parse(tbxPesoKilo.Text);
            double precioKilo = Double.Parse(txbPrecioKilo.Text);
            double stock = Double.Parse(tbtStock.Text);

            if (datos.agregarProductos(nombretxt, kilo, precioKilo, stock))
            {
                MessageBox.Show("Se agrego correctamente");
                ltbProductos.DataSource = datos.MostrarPoducto();
            }
            else
            {
                MessageBox.Show("No se agrego correctamente"); 
            }
        }

        /// <summary>
        /// El método "button2_Click" es un controlador de eventos que elimina un producto seleccionado de una lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string nombrePducto;
            nombrePducto = ltbProductos.Text;

            if (datos.eliminarProductos(datos.buscarProductos(nombrePducto)))
            {
                MessageBox.Show("Se elimino correctamente");
                ltbProductos.DataSource = datos.MostrarPoducto();
            }
            else
            {
                MessageBox.Show("No se elimino correctamente");
            }
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


    }
}
