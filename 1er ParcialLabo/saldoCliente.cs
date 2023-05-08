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

namespace _1er_ParcialLabo
{
    public partial class saldoCliente : Form
    {
        /// <summary>
        /// Este es el constructor de la clase "saldoCliente". 
        /// Toma como parámetros un objeto "datos" de la clase "HarcodeoDatos" y un objeto "usuario" de la clase "Usuario"
        /// La finalidad de este constructor es inicializar la instancia de la clase "saldoCliente".
        /// </summary>
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        public saldoCliente(HarcodeoDatos datos, Usuario usuario)
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
        /// Este método es el evento "Click" del botón "btnConfimporte".
        /// Obtiene el importe ingresado por el usuario en el cuadro de texto "tbxImporteCliente"
        /// Luego, verifica si el método "cargarImporte" del objeto "datos" pudo cargar el importe para el "usuarioLogeado"
        /// . Si se carga correctamente, crea una instancia de la clase "Venta" y la muestra.
        /// De lo contrario, muestra un mensaje de error mediante la clase "MessageBox".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfimporte_Click(object sender, EventArgs e)
        {
            double importeCliente;

            importeCliente = double.Parse(tbxImporteCliente.Text);

            if (Clientes.cargarImporte(usuarioLogeado, importeCliente))
            {

                Venta venta = new Venta(datos, usuarioLogeado, importeCliente);
                venta.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        /// <summary>
        /// Este es un método que maneja el evento "KeyPress" del cuadro de texto "txtDni".
        /// Su propósito es validar que sólo se ingresen caracteres numéricos en el cuadro de texto, y bloquear cualquier otro tipo de carácter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }
    }
}
