using Entidades___Parcial_Laboratorio;

namespace _1er_ParcialLabo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //se ejecuto una sola ves 
            //empieza con un harcodeo
            HarcodeoDatos datos = new HarcodeoDatos();

            //le paso harcodeo ()
            Application.Run(new Login(datos));
        }
    }
}