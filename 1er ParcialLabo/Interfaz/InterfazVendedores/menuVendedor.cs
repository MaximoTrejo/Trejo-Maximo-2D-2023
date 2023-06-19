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
    public partial class menuVendedor : Form
    {
        /// <summary>
        ///  Clase que representa la ventana principal del menú para un usuario vendedor. 
        ///  Recibe un objeto "datos" de tipo "HarcodeoDatos" que contiene la información harcodeada 
        ///  y un objeto "usuario" de tipo "Usuario" que representa al usuario que ha iniciado sesión
        ///  . Estos objetos se asignan a las variables de instancia "datos" y "usuarioLogeado"
        ///  Notas:
        ///  Al asignar estos valores a las variables de instancia, estamos permitiendo que la clase "menuVendedor" 
        ///  tenga acceso a esta información durante todo el tiempo que esté en ejecución, 
        /// </summary>
        HarcodeoDatos datos;
        Usuario usuarioLogeado;
        public menuVendedor(HarcodeoDatos datos, Usuario usuario)
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
        /// Este método es el manejador de eventos que se ejecuta cuando se hace clic en el botón "btnHeladera". 
        /// Lo que hace es crear un nuevo objeto de la clase "Heladera" 
        /// Luego, muestra la ventana "Heladera" y oculta la ventana actual ("menuVendedor").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHeladera_Click(object sender, EventArgs e)
        {
            Heladera heladera = new Heladera(datos,usuarioLogeado);
            heladera.Show();
            this.Hide();
        }
        /// <summary>
        /// Este método es el manejador de eventos que se ejecuta cuando se hace clic en el botón "btnVenta".
        /// Lo que hace es crear un nuevo objeto de la clase "Venta" 
        /// Luego, muestra la ventana "Venta" y oculta la ventana actual ("menuVendedor").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(datos, usuarioLogeado);
            venta.Show();
            this.Hide();
        }


    }
}
