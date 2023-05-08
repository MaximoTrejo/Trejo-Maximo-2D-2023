using Entidades___Parcial_Laboratorio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1er_ParcialLabo
{
    public partial class listadoFacturacion : Form
    {
        /// <summary>
        /// La clase "listadoFacturacion" tiene como objetivo mostrar una lista de las facturaciones realizadas por el usuario logueado.
        /// se utiliza una lista de objetos "Facturacion" y se guardan los datos de la lista de facturaciones obtenida a través del objeto "datos". 
        /// Además, se guarda la posición actual en la lista de facturaciones
        /// </summary>
        int posicion = 0;
        List<Facturacion> facturaciones;
        HarcodeoDatos datos;
        Usuario usuarioLogeado;

        public listadoFacturacion(HarcodeoDatos datos, Usuario usuario)
        {
            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
        }

        /// <summary>
        /// Es un controlador de eventos que se ejecuta cuando se carga el formulario listadoFacturacion.
        /// En este método, se inicializa la lista facturaciones y se carga con los datos de los tickets de ventas almacenados en datos.traerTicket().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoFacturacion_Load(object sender, EventArgs e)
        {
            facturaciones = new List<Facturacion>();
            facturaciones = Facturacion.traerTicket();
            //creo las columnas del dataGridView
            dgvFacturacion.Columns.Add("nombre", "Nombre");
            dgvFacturacion.Columns.Add("cantidad", "cantidad");
            dgvFacturacion.Columns.Add("PrecioUnidad", "PrecioUnidad");
            dgvFacturacion.Columns.Add("Preciototal", "PrecioTotal");
            //actualizo el formulario
            actualizarForm();
        }

        /// <summary>
        /// Este método se ejecuta al hacer clic en el botón "Siguiente" y permite navegar a la siguiente factura en la lista de facturaciones. 
        /// Si la posición actual ya es la última factura, se muestra un mensaje de error.
        /// En caso contrario, la posición se incrementa y se actualiza la vista del formulario con los datos de la siguiente factura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion == facturaciones.Count - 1)//ejemplo 1 2 3  ==  0 1 2 (usando índices)
            {
                MessageBox.Show("No hay mas facturas", "Error");
            }
            else
            {
                posicion++;
                actualizarForm();
            }


        }

        /// <summary>
        /// Este método se ejecuta cuando se presiona el botón "Anterior" en el formulario de listado de facturaciones. 
        /// Si la posición actual de la factura no es la primera de la lista, se disminuye en uno la posición y se llama al método actualizarForm() para mostrar la factura 
        /// De lo contrario, se muestra un mensaje de error indicando que no hay más facturas anteriores para mostrar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnterior_Click(object sender, EventArgs e)
        {

            if (posicion != 0)
            {
                posicion--;
                actualizarForm();
            }
            else
            {
                MessageBox.Show("No hay mas facturas","Error");
            }

        }

        /// <summary>
        /// Este método se encarga de actualizar la información que se muestra en el formulario de la lista de facturaciones.
        /// Primero, se limpia el contenido de la tabla donde se muestran los detalles de la factura y se comprueba que la cantidad de nombres de productos, cantidades, precios unitarios y precios totales de la factura actual sean iguales. 
        /// Luego, se agrega cada detalle de producto a la tabla. 
        /// Además, se actualizan dos etiquetas de texto que muestran el correo electrónico del cliente y el precio total de la factura actual.
        /// </summary>
        private void actualizarForm()
        {
            dgvFacturacion.Rows.Clear();

            if (facturaciones[posicion].nombreProductos.Count == facturaciones[posicion].Cantidades.Count
                && facturaciones[posicion].nombreProductos.Count == facturaciones[posicion].PrecioUnidad.Count
                && facturaciones[posicion].Cantidades.Count == facturaciones[posicion].Cantidades.Count)
            {
                for (int i = 0; i < facturaciones[posicion].nombreProductos.Count; i++)
                {
                    dgvFacturacion.Rows.Add(facturaciones[posicion].nombreProductos[i], facturaciones[posicion].Cantidades[i], facturaciones[posicion].PrecioUnidad[i], facturaciones[posicion].Cantidades[i] * facturaciones[posicion].PrecioUnidad[i]);
                }
            }
            lblMail.Text = facturaciones[posicion].Email;
            lblTotal.Text = facturaciones[posicion].PrecioTotal.ToString();
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
        /// El método "btnVolver_Click" se activa cuando se hace clic en el botón "Volver".
        /// Crea una nueva instancia de la clase "Heladera" y la muestra en pantalla y Oculta la ventana actual
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
