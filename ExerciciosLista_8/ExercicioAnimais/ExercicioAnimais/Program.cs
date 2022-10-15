namespace ExercicioAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, tipo;
            int quant = 0, tp;

            List<Animais> animal = new List<Animais>();

            while (quant < 5)
            {
                Console.Clear();
                Console.Write("Informe o nome do animal: ");
                nome = Console.ReadLine();
                do
                {
                    Console.WriteLine("Informe o tipo do animal: ");
                    Console.WriteLine("1 - Cachorro");
                    Console.WriteLine("2 - Gato");
                    Console.WriteLine("3 - Peixe");
                    Console.Write("\nSua escolha: ");
                    tp = int.Parse(Console.ReadLine());

                    switch (tp)
                    {
                        case 1:
                            tipo = "Cachorro";
                            break;
                        case 2:
                            tipo = "Gato";
                            break;
                        case 3:
                            tipo = "Peixe";
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            tipo = "inválido";
                            break;
                    }
                } while (tipo != "Cachorro" && tipo != "Gato" && tipo != "Peixe");
                animal.Add(new Animais(nome, tipo));
                quant++;
            }
            Console.Clear();
            Animais.ExibeAnimais(animal);

        }
    }
}