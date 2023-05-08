namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto1 = Console.ReadLine();


            string texto2  = Console.ReadLine();


            if( texto1.ToLower() == texto2.ToLower())
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}