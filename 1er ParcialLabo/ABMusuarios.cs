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
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        public ABMusuarios(HarcodeoDatos datos, Usuario usuario)
        {

            InitializeComponent();
            this.datos = datos;
            this.usuarioLogeado = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ltbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            string usuario = ltbUsuarios.Text;
            Usuario usu = datos.buscarUsuario(usuario);
            string tipo = cbxCategoria.Text;

            //Clientes clientes;

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

            // tbtStock.Text = producto.stock.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombretxt = tbxnombre.Text;
            string Pass = tbxPass.Text;
            double importe;
            string tipo = cbxCategoria.Text;
            tipo = string.IsNullOrEmpty(tipo) ? null : tipo;

            //Usuario usu = datos.buscarUsuario(nombretxt);

            if (tipo == "Vendedor")
            {

                //double importe = Double.Parse(txbImporte.Text);

                if (datos.agregarVendedor(nombretxt, Pass, usuarioLogeado, tipo))
                {
                    MessageBox.Show("Se agrego correctamente");

                }
                else
                {
                    MessageBox.Show("No se agrego correctamente");
                }

            }
            else
            {
                importe = Double.Parse(txbImporte.Text);
                if (datos.agregarUsuarios(nombretxt, Pass, usuarioLogeado, importe, tipo))
                {
                    MessageBox.Show("Se agrego correctamente");

                }
                else
                {
                    MessageBox.Show("No se agrego correctamente");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbxnombre.Text = "";
            tbxPass.Text = "";
            txbImporte.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = ltbUsuarios.Text;
            string nombretxt = tbxnombre.Text;
            string Pass = tbxPass.Text;
            double importe = Double.Parse(txbImporte.Text);
            Usuario usu = datos.buscarUsuario(nombreUsuario);


            if (datos.modificarUsuarios(nombretxt, Pass, datos.buscarUsuario(nombreUsuario), importe))
            {
                MessageBox.Show("se modifico");
                if (usu.validarVendedor())
                {
                    ltbUsuarios.DataSource = datos.MostrarVendedores();
                }
                else
                {
                    ltbUsuarios.DataSource = datos.MostrarClientes();
                }//recorro la lista otra ves y se mostraria el dato modificado 
            }
            else
            {
                MessageBox.Show("no se modifico");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario;
            nombreUsuario = ltbUsuarios.Text;
            Usuario usu = datos.buscarUsuario(nombreUsuario);

            if (datos.eliminarUsuario(datos.buscarUsuario(nombreUsuario)))
            {
                MessageBox.Show("Se elimino correctamente");
                if (usu.validarVendedor())
                {
                    ltbUsuarios.DataSource = datos.MostrarVendedores();
                }
                else
                {
                    ltbUsuarios.DataSource = datos.MostrarClientes();
                }
                //ltbUsuarios.DataSource = datos.MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("No se elimino correctamente");
            }
        }

        private void ABMusuarios_Load(object sender, EventArgs e)
        {
            //ltbUsuarios.DataSource = datos.MostrarUsuarios();
            cbxCategoria.Items.Add(CategoriaUsuarios.Cliente);
            cbxCategoria.Items.Add(CategoriaUsuarios.Vendedor);
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            ltbUsuarios.DataSource = datos.MostrarVendedores();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ltbUsuarios.DataSource = datos.MostrarClientes();

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Heladera heladera = new Heladera(datos, usuarioLogeado);
            heladera.Show();
            this.Hide();
        }
    }
}
