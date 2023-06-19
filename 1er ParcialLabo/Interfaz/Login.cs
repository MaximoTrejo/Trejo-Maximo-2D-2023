using Entidades___Parcial_Laboratorio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1er_ParcialLabo
{
    public partial class Login : Form
    {
        /// <summary>
        /// Prodiedad \ entidad de tipo HardodeoDatos 
        /// </summary>
        HarcodeoDatos datos;

        /// <summary>
        /// Clase que representa una ventana de inicio de sesión.
        /// </summary>
        /// <param name="datos">Objeto que contiene datos predefinidos para realizar el inicio de sesión.</param>
        public Login(HarcodeoDatos datos)
        {
            InitializeComponent();
            this.datos = datos;


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
        /// Función que se ejecuta cuando se hace clic en el botón "brnVendedor". Establece valores predefinidos para los cuadros de texto "txtPass" y "txtMail".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnVendedor_Click(object sender, EventArgs e)
        {
            txtPass.Text = "22222";
            txtMail.Text = "admin1@gmail,com";
        }
        /// <summary>
        /// Función que se ejecuta cuando se hace clic en el botón "btnCliente_Click". Establece valores predefinidos para los cuadros de texto "txtPass" y "txtMail".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            txtPass.Text = "11111";
            txtMail.Text = "mail1@gmail,com";
        }

        /// <summary>
        ///  Función que se ejecuta cuando se hace clic en el botón "btnInicio". 
        ///  Obtiene el correo electrónico y la contraseña ingresados por el usuario,
        ///  valida que el usuario se encuentre en la lista que se encuentra en el objeto "datos" 
        ///  y muestra una ventana correspondiente según el tipo de usuario (vendedor o cliente).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnInicio_Click(object sender, EventArgs e)
        {

            string mail;
            string pass;

            mail = this.txtMail.Text;
            pass = this.txtPass.Text;

            Usuario logeado = datos.ListaValido(mail, pass);


            if (logeado == null)
            {
                //no encontro el usuario
                MessageBox.Show("El usuario no existe", "Error");

            }
            else if (logeado.validarVendedor())
            {

                menuVendedor elegirRuta = new menuVendedor(datos, logeado);
                elegirRuta.Show();
                this.Hide();
            }
            else
            {
                //cliente
                saldoCliente cargarImporte = new saldoCliente(datos, logeado);
                cargarImporte.Show();
                this.Hide();
            }

        }

    }
}