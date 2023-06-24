using Entidades___Parcial_Laboratorio;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBuscarUsuario()
        {

            HarcodeoDatos harcodeo = new HarcodeoDatos();   

            Usuario usuario =  new Usuario("usuario1@example.com" ,"12334");

            HarcodeoDatos.Usuarios.Add(usuario);

            Usuario buscoU = harcodeo.buscarUsuario(usuario.Email);

            Assert.AreEqual(usuario,buscoU);
            
        }

      

        [TestMethod]
        public void TestListaValido()
        {
            HarcodeoDatos harcodeo = new HarcodeoDatos();

            Usuario usuario = new Usuario("usuario2@example.com", "12334");

            HarcodeoDatos.Usuarios.Add(usuario);

            Usuario buscoU = harcodeo.ListaValido(usuario.Email, usuario.Pass);

            Assert.AreEqual(usuario, buscoU);

        }



        [TestMethod]
        public void TestPagoCreditoImporte()
        {
            double importeP = 12.6;

            HarcodeoDatos harcodeo = new HarcodeoDatos();

            double cuenta = harcodeo.PagoCreditoImporte(12,"Credito");

            Assert.AreEqual(importeP, cuenta);

        }

    }
}