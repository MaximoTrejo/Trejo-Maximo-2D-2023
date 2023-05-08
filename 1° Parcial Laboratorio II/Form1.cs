using Login_Parcial_Labo;

namespace _1__Parcial_Laboratorio_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}