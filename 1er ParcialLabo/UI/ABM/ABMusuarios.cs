using _1er_ParcialLabo.BDD;
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
    public partial class ABMusuarios : Form
    {
        /// <summary>
        /// El propósito de esta clase es la gestión de usuarios en una aplicación.
        /// </summary>
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        public ABMusuarios(HarcodeoDatos datos, Usuario usuario)
        {
            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
        }

        /// <summary>
        /// Si el usuario seleccionado es un cliente, 
        /// se habilita el campo de importe y se muestra el importe del cliente. 
        /// En caso contrario, se deshabilita el campo de importe. 
        /// Finalmente, se deshabilita la lista desplegable de tipos de usuario (cbxCategoria) para evitar que el usuario cambie su propio tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usuario = ltbUsuarios.Text;
            Usuario usu = datos.buscarUsuario(usuario);
            string tipo = cbxCategoria.Text;

            tbxnombre.Text = usuario;
            tbxPass.Text = usu.Pass.ToString();
            if (!(usu.validarVendedor()))
            {
                Clientes clientes;
                clientes = (Clientes)usu;
                txbImporte.Enabled = true;
                txbImporte.Text = clientes.importe.ToString();
                cbxCategoria.Text = Usuario.categoriaUsuarios(usu);
            }
            else
            {
                txbImporte.Enabled = false;
                cbxCategoria.Text = Usuario.categoriaUsuarios(usu);
            }
            cbxCategoria.Enabled = false;
        }

        /// <summary>
        /// Si el nombre de usuario es válido, la contraseña no está vacía y el tipo de usuario es "Vendedor", se agrega un nuevo vendedor a la fuente de datos.
        /// Si se agrega correctamente, se muestra un mensaje de confirmación. En caso contrario, se muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombretxt = tbxnombre.Text;
            string Pass = tbxPass.Text;
            double importe;
            string tipo = cbxCategoria.Text;

            tipo = string.IsNullOrEmpty(tipo) ? null : tipo;

            if (ValidacionesABM.ValidarString(nombretxt)) {

                if (!string.IsNullOrEmpty(Pass)) { 

                     if (tipo == "Vendedor")
                     {

                        try
                        {
                            if (Vendedor.agregarVendedor(nombretxt, Pass, usuarioLogeado, tipo))
                            {
                                MessageBox.Show("Se agrego correctamente");
                                VendedoresDAB.AddVendedores(nombretxt, Pass);

                            }
                        }
                        catch (ProductoExistenteException ex)
                        {
                            MessageBox.Show("No se agrego correctamente,el Usuario ya existe");
                        }

                     }
                     else
                     {
                         txbImporte.Enabled = true;
                                
                        if (ValidacionesABM.ValidarDouble(txbImporte.Text))
                        {
                            importe = Double.Parse(txbImporte.Text);

                            if (ValidacionesABM.ValidarMonto(importe))
                            {
                                try
                                {
                                    if (Clientes.agregarClientes(nombretxt, Pass, usuarioLogeado, importe))
                                    {
                                        MessageBox.Show("Se agrego correctamente");
                                        ClientesBDD.AddClientes(nombretxt, Pass, importe);

                                    }
                                }
                                catch (ProductoExistenteException ex)
                                {
                                    MessageBox.Show("No se agrego correctamente,el Usuario ya existe");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("El importe debe ser menor a 100.000", "Aviso");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No completo el importe", "Aviso");
                        }
                                            
                     }
                }
                else
                {
                    MessageBox.Show("No completo la Contraseña", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("No completo el nombre","Aviso");
            }
        }

        /// <summary>
        /// El método comienza asignando valores vacíos a los campos de nombre de usuario, contraseña e importe. Luego, deshabilita el campo de selección de categoría.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbxnombre.Text = "";
            tbxPass.Text = "";
            txbImporte.Text = "";
            cbxCategoria.Enabled = false;
        }


        /// <summary>
        /// Obtiene los datos ingresados por el usuario en los campos de texto y el valor seleccionado en el cuadro de lista de usuarios. 
        /// Luego, valida los datos y realiza la modificación del usuario en la lista de datos utilizando los métodos correspondientes de la clase Datos.
        /// Si la modificación es exitosa, se actualiza el cuadro de lista de usuarios para mostrar el cambio. Si no, se muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = ltbUsuarios.Text;
            string nombretxt = tbxnombre.Text;
            string Pass = tbxPass.Text;
            double importe;

            string tipo = cbxCategoria.Text;
            tipo = string.IsNullOrEmpty(tipo) ? null : tipo;

            Usuario usu = datos.buscarUsuario(nombreUsuario);

            if (ValidacionesABM.ValidarString(nombretxt))
            {
                if (!string.IsNullOrEmpty(Pass))
                {
                    if (tipo == "Vendedor")
                    {
                        if (Vendedor.modificarVendedor(nombretxt, Pass, datos.buscarUsuario(nombreUsuario)))
                        {
                            VendedoresDAB.ModVendedores(nombretxt, Pass);
                            ltbUsuarios.DataSource = Vendedor.MostrarVendedores();
                        }
                        else
                        {
                            MessageBox.Show("No se modifico", "Error");
                        }
                    }
                    else
                    {
                        txbImporte.Enabled = true;

                        if (ValidacionesABM.ValidarDouble(txbImporte.Text))
                        {
                            importe = Double.Parse(txbImporte.Text);

                            if (ValidacionesABM.ValidarMonto(importe))
                            {
                                Usuario usuarioBuscado = datos.buscarUsuario(nombreUsuario);

                                if (Clientes.modificarClientes(nombretxt, Pass, usuarioBuscado, importe))
                                {
                                    
                                    ClientesBDD.ModUsuarios(nombretxt, Pass, importe, usuarioBuscado);
                                    MessageBox.Show("Se modifico", "Confirmacion");
                                    ltbUsuarios.DataSource = Clientes.MostrarClientes();//recorro la lista otra ves y se mostraria el dato modificado 
                                }
                                else
                                {
                                    MessageBox.Show("No se modifico", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El importe debe ser menor a 100.000", "Aviso");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No completo el importe", "Aviso");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No completo la Contraseña", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("No completo el nombre", "Aviso");
            }
        }


        /// <summary>
        /// este método se encarga de eliminar un usuario seleccionado de la lista de usuarios y actualizar la interfaz de usuario correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario;
            nombreUsuario = ltbUsuarios.Text;
            Usuario usu = datos.buscarUsuario(nombreUsuario);

            if (Clientes.eliminarCliente(datos.buscarUsuario(nombreUsuario)))
            {
                MessageBox.Show("Se elimino correctamente");
                if (usu.validarVendedor())
                {
                    VendedoresDAB.EliminarVendedores(nombreUsuario);
                    ltbUsuarios.DataSource = Vendedor.MostrarVendedores();
                }
                else
                {
                    ClientesBDD.EliminarCliente(nombreUsuario);
                    ltbUsuarios.DataSource = Clientes.MostrarClientes();
                }
            }
            else
            {
                MessageBox.Show("No se elimino correctamente");
            }
        }


        /// <summary>
        /// El método ABMusuarios_Load es un evento que se dispara al cargar el formulario ABMusuarios.
        /// En este caso, agrega dos elementos al combobox cbxCategoria, que corresponden a las categorías de usuarios Cliente y Vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ABMusuarios_Load(object sender, EventArgs e)
        {  
            cbxCategoria.Items.Add(CategoriaUsuarios.Cliente);
            cbxCategoria.Items.Add(CategoriaUsuarios.Vendedor);

        }

        /// <summary>
        /// Este método se encarga de mostrar en un ListBox todos los usuarios de tipo vendedor que existen en la lista de usuarios que maneja la aplicación. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            ltbUsuarios.DataSource = Vendedor.MostrarVendedores();
        }

        /// <summary>
        /// Su función es mostrar en la lista de usuarios todos los clientes registrados en el sistema utilizando el método "MostrarClientes()" de la clase "DatosUsuarios"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {

            ltbUsuarios.DataSource = Clientes.MostrarClientes();
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
        /// Este método abre la ventana "Heladera" y oculta la ventana actual, pasando la lista de usuarios y el usuario logueado como parámetros.
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
