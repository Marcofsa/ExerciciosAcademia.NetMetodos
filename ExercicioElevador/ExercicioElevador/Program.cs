namespace ExercicioElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            int opc = 5;

            elevador.inicializa(10, 10);

            do
            {
                Console.WriteLine("1 - Sube");
                Console.WriteLine("2 - Desce");
                Console.WriteLine("3 - Chamar");
                Console.WriteLine("4 - Retira");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha sua opção acima para continuar: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        elevador.subir();
                        break;
                    case 2:
                        Console.Clear();
                        elevador.descer();
                        break;
                    case 3:
                        Console.Clear();
                        elevador.entra();
                        break;
                    case 4:
                        Console.Clear();
                        elevador.sai();
                        break;
                }
            }
            while (opc != 0);
        }
    }
}