namespace ExercicioAsteroids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asteroides ast = new Asteroides();
            List<Asteroides> ast2 = new List<Asteroides>();
            int option = 0;

            do
            {
                Console.WriteLine(">>>>>>>> Jogo dos Asteroides <<<<<<<<\n");
                Console.WriteLine("1 - Registrar um novo asteróide");
                Console.WriteLine("2 - Exibir todos os asteróides");
                Console.WriteLine("3 - Encerrar");
                Console.Write("\nOpção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                }
            } while (option != 3);

            Console.Clear();
            ast.getAsteroides();

        }
    }
}