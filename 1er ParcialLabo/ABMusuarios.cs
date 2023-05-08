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
            //Clientes clientes;

            tbxnombre.Text = usuario;
            tbxPass.Text = usu.Pass.ToString();
            if (!(usu.validarVendedor()))
            {
                Clientes clientes;
                clientes = (Clientes)usu;
                txbImporte.Enabled = true;
                txbImporte.Text = clientes.importe.ToString();

            }
            else
            {
                txbImporte.Enabled = false;
            }

            // tbtStock.Text = producto.stock.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombretxt = tbxnombre.Text;
            string Pass = tbxPass.Text;
            double importe = Double.Parse(txbImporte.Text);
            string tipo = cbxCategoria.Text;
            tipo = string.IsNullOrEmpty(tipo) ? null : tipo;
            

            if (datos.agregarUsuarios(nombretxt, Pass, usuarioLogeado, importe,tipo))
            {
                MessageBox.Show("Se agrego correctamente");
                ltbUsuarios.DataSource = datos.MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("No se agrego correctamente");
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


            if (datos.modificarUsuarios(nombretxt, Pass, datos.buscarUsuario(nombreUsuario), importe))
            {
                MessageBox.Show("se modifico");
                ltbUsuarios.DataSource = datos.MostrarUsuarios();//recorro la lista otra ves y se mostraria el dato modificado 
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

            if (datos.eliminarUsuario(datos.buscarUsuario(nombreUsuario)))
            {
                MessageBox.Show("Se elimino correctamente");
                ltbUsuarios.DataSource = datos.MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("No se elimino correctamente");
            }
        }

        private void ABMusuarios_Load(object sender, EventArgs e)
        {
            ltbUsuarios.DataSource = datos.MostrarUsuarios();
            cbxCategoria.Items.Add(CategoriaUsuarios.Cliente);
            cbxCategoria.Items.Add(CategoriaUsuarios.Vendedor);
        }
    }
}
