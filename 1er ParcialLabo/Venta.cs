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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace _1er_ParcialLabo
{
    /// <summary>
    /// La clase "Venta" tiene dos constructores sobrecargados que inicializan las variables "datos" y "usuarioLogeado".
    /// El primer constructor también inicializa la variable "importe".
    /// </summary>
    public partial class Venta : Form
    {
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        double importe;

        public Venta(HarcodeoDatos datos, Usuario usuario, double importe)
        {
            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
            this.importe = importe;
        }
        public Venta(HarcodeoDatos datos, Usuario usuario)
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
        /// El método "button1_Click" es un controlador de eventos que se ejecuta cuando se hace clic en el botón "button1".
        /// El método verifica si el usuario logeado es un vendedor mediante el método "validarVendedor()" de la clase "Usuario".
        /// Si el usuario es un vendedor, se muestra el formulario "menuVendedor" y se oculta el formulario actual.
        /// Si no es un vendedor, el botón "btnVolver" se deshabilita.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (usuarioLogeado.validarVendedor())
            {
                menuVendedor menuVendedor = new menuVendedor(datos, usuarioLogeado);
                menuVendedor.Show(this);
                this.Hide();
            }
            else
            {
                btnVolver.Enabled = false;
            }
        }

        /// <summary>
        /// El método Venta_Load es un evento que se ejecuta cuando se carga el formulario Venta. 
        /// Este método configura la visibilidad de algunos elementos del formulario según el tipo de usuario logeado 
        /// y muestra información sobre el usuario y la venta en curso. 
        /// Además, agrega columnas al DataGridView dgvProductosVenta y agrega opciones de pago al ComboBox cbxMediosPago.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Venta_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;


            if (this.usuarioLogeado.validarVendedor())//usuarioLogeado sabe que tipo es , por eso va a ir al metodo de vendedor si no lo encuentra va al padre 
            {
                groupBox1.Visible = true;
                lblImporte.Visible = false;
            }

            lblUsuario.Text = this.usuarioLogeado.Email;
            lblImporte.Text = this.importe.ToString();
            lblCategoria.Text = Usuario.categoriaUsuarios(usuarioLogeado);

            dgvProductosVenta.Columns.Add("nombre", "Nombre");
            dgvProductosVenta.Columns.Add("Kilo", "Kilo");
            dgvProductosVenta.Columns.Add("Precio", "Precio");

            cbxMediosPago.Items.Add(MediosPago.Efectivo);
            cbxMediosPago.Items.Add(MediosPago.Credito);

        }

        /// <summary>
        /// Este método es un controlador de eventos para el botón "btnBuscar" en la ventana de "Venta".
        /// Se encarga de buscar un usuario por su nombre de usuario ingresado en el cuadro de texto "txbBuscarCliente". 
        /// Si el usuario es encontrado y no es un vendedor, actualiza la información de la venta en la ventana. 
        /// Si el usuario es un vendedor, muestra un mensaje de error y 
        /// si el usuario no es encontrado, también muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string clienteBuscado;
            clienteBuscado = txbBuscarCliente.Text;

            Usuario usuario = datos.buscarUsuario(clienteBuscado);

            if (usuario != null)
            {
                if (!(usuario.validarVendedor()))
                {
                    MessageBox.Show("Se encontro el usuario correctamente", "Confirmacion");
                    lblUsuario.Text = usuario.Email;
                    lblImporte.Visible = true;
                    importe = Usuario.buscarImporte(usuario);
                    lblImporte.Text = importe.ToString();
                    lblCategoria.Text = Usuario.categoriaUsuarios(usuario);
                    usuarioLogeado = usuario;
                }
                else
                {
                    MessageBox.Show("El usuario tiene categoria vendedor ,solo puede vender un cliente ,Porfavor busque un cliente", "Error");
                }

            }
            else
            {
                MessageBox.Show("El usuario no existe", "Error");
            }
        }


        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Buscar" para buscar un producto y agregarlo al carrito de compras.
        /// Busca el producto en la lista de productos del sistema, verifica que la cantidad ingresada sea mayor a 0 y que se haya seleccionado un método de pago.
        /// Si se cumplen estas condiciones, muestra una ventana con los detalles del producto y, si el usuario confirma la compra, verifica que haya suficiente stock disponible 
        /// y lo agrega al carrito de compras y a la tabla de productos vendidos.
        /// Si el usuario logueado es de tipo vendedor, muestra un mensaje de error indicando que debe buscar un usuario para poder vender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            string productoBuscado = txbProducto.Text;
            string medioPago = cbxMediosPago.Text;
            medioPago = string.IsNullOrEmpty(medioPago) ? null : medioPago;
            int cantProducto = (int)nudStock.Value;
            Producto producto;


            if (!(usuarioLogeado.validarVendedor()))
            {
                producto = datos.buscarProductos(productoBuscado);

                if (producto is not null)
                {

                    if (cantProducto > 0)
                    {
                        if (medioPago != null)
                        {
                            MessageBox.Show(medioPago);

                            if (MessageBox.Show(producto.Mostrar(), "Confirme el producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {

                                if (Producto.hayStock(datos.Producto, productoBuscado, cantProducto))
                                {
                                    if (datos.cargarProductosAlCarrito(producto, cantProducto))
                                    {
                                        for (int i = 0; i < cantProducto; i++)
                                        {
                                            dgvProductosVenta.Rows.Add(producto.nombre, producto.kilo, producto.precioKilo);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al cargar el producto", "Error");
                                    }
                                }
                                else
                                {
                                    
                                    MessageBox.Show("Superaste el stock ", "Error");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un metodo de pago ", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad mayor a 0 ", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("El producto buscado no existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("El usuario logeado es del tipo vendedor ,Porfavor busque un usuario para poder vender");
            }
        }


        /// <summary>
        /// Realiza la compra de los productos agregados al carrito de compra, 
        /// verifica que el usuario logeado no sea un vendedor y que se haya seleccionado un método de pago válido
        /// Calcula el importe total de la compra y genera un ticket de facturación. 
        /// Verifica si el usuario tiene saldo suficiente para realizar la compra
        /// reduce el stock de los productos comprados 
        /// y muestra un mensaje de confirmación en caso de que la compra se haya realizado con éxito.
        /// Finalmente, limpia el carrito de compra y la tabla de productos del data Grid View. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {

            string medioPago = cbxMediosPago.Text;
            medioPago = string.IsNullOrEmpty(medioPago) ? null : medioPago;

            double SumaCarrito;
            SumaCarrito = datos.sumarImporte(datos.CarritoCompra);
            SumaCarrito = datos.PagoCreditoImporte(SumaCarrito, medioPago);

            List<string> nombre = datos.obtenerNombresProductos();
            List<int> cantidad = contar();
            List<int> precioUnidad = datos.precioUnidad();

            Facturacion ticket = new Facturacion(lblUsuario.Text, SumaCarrito, nombre, cantidad, precioUnidad);


            if (Clientes.compararImportes(importe, SumaCarrito))
            {

                if (Producto.reducirStock(datos.Producto, datos.CarritoCompra))
                {
                 
                    if (MessageBox.Show(ticket.MostrarFacturacion(), "Confirme el producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Ticket Facturado", "Confirmacion");
                        datos.CarritoCompra.Clear();
                        HarcodeoDatos.encabezadoTicket.Add(ticket);
                        dgvProductosVenta.Rows.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("No tiene el saldo suficiente para realizar la compra", "Error");
                datos.CarritoCompra.Clear();
                dgvProductosVenta.Rows.Clear();
            }

        }







        /// <summary>
        ///La función contar devuelve una lista de enteros que representan la cantidad de veces que aparece cada producto en el carrito de compras. 
        ///El propósito de esta función es obtener la cantidad de cada producto que se va a comprar, para utilizarla en la generación del ticket de facturación.
        /// Nota
        /// La razón para usar un diccionario es que permite contar la cantidad de ocurrencias de cada producto de manera más eficiente que utilizar una lista 
        /// y recorrerla buscando el producto cada vez que se quiere contar.
        /// </summary>
        /// <returns></returns>
        private List<int> contar()
        {
            Dictionary<string, int> cantidad = new Dictionary<string, int>();
            string valor;

            foreach (DataGridViewRow fila in dgvProductosVenta.Rows)
            {
                valor = fila.Cells[0].ToString();

                if (cantidad.Count == 0)//diccionario vacio \lista vacia
                {

                    cantidad.Add(valor, 1); //se agrega con cantidad 1.

                }
                else
                {
                    if (cantidad.ContainsKey(valor))//si el producto ya existe 
                    {
                        cantidad[valor]++;//se imcrementa su cantidad
                    }
                    else
                    {
                        cantidad.Add(valor, 1);// se agrega con cantidad 1.
                    }
                }
            }
            return cantidad.Values.ToList();//devuelvo una lista de enteros que contiene los valores del diccionario
        }
    }
}


