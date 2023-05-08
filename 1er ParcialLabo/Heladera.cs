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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _1er_ParcialLabo
{
    public partial class Heladera : Form
    {
        /// <summary>
        /// La clase "Heladera" tiene un constructor que inicializa los campos de clase "datos" y "usuarioLogeado" con los valores pasados como parámetros, 
        /// que representan los datos y el usuario al ejecutar la aplicación.
        /// </summary>
        HarcodeoDatos datos;
        Usuario usuarioLogeado;

        public Heladera(HarcodeoDatos datos, Usuario usuario)
        {
            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
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
        /// El método "btnVolver_Click" es un controlador de eventos que oculta el formulario actual y 
        /// muestra un nuevo formulario de "menuVendedor" con los datos y el usuario pasados como parámetros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuVendedor menuVendedor = new menuVendedor(datos, usuarioLogeado);
            menuVendedor.Show(this);
            this.Hide();
        }

        /// <summary>
        /// El método "btnDetalle_Click" es un controlador de eventos que muestra detalles del producto seleccionado en la lista "ltbProductos" en el control DataGridView "dgvProductos".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            string nombrePducto = ltbProductos.Text;

            datos.buscarProductos(nombrePducto);

            dgvProductos.DataSource = Producto.detallaProductos(datos.buscarProductos(nombrePducto));

        }

        /// <summary>
        /// El método "Heladera_Load" es un controlador de eventos que establece el origen de datos de la lista de productos "ltbProductos" en el formulario "Heladera" 
        /// utilizando los datos obtenidos a través del método "MostrarPoducto" de la clase "datos".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Heladera_Load(object sender, EventArgs e)
        {
            ltbProductos.DataSource = datos.MostrarPoducto();
        }

        /// <summary>
        /// El método "btnModificar_Click" es un controlador de eventos que muestra un formulario de "ABMproductos" con los datos y el usuario pasados como parámetros y oculta el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {

            ABMproductos aBMproductos = new ABMproductos(datos, usuarioLogeado);
            aBMproductos.Show();
            this.Hide();

        }

        /// <summary>
        /// El método "btnListaF_Click" es un controlador de eventos que muestra un formulario de "listadoFacturacion" con los datos y el usuario pasados como parámetros y oculta el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaF_Click(object sender, EventArgs e)
        {
            listadoFacturacion fact = new listadoFacturacion(datos, usuarioLogeado);
            fact.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABMusuarios aBMusuarios = new ABMusuarios(datos, usuarioLogeado);
            aBMusuarios.Show();
            this.Hide();
        }
    }
}
