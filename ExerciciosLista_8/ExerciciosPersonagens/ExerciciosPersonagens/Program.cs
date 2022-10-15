namespace ExerciciosPersonagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = 0, opc = 0;

            List<Personagem> personagem = new List<Personagem>();

            while (persons < 3)
            {
                Console.WriteLine("\n//////////// Bem vindo ao torneio de personangens!////////////");
                Console.WriteLine("1 - Digite um personagem fictício (anime, cartoon, etc.)");
                Console.WriteLine("2 - Lista dos combatentes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("\nInforme o nome do personagem: ");
                        string nome = Console.ReadLine();
                        int poder;
                        do
                        {
                            Console.Write("Informe o poder do personagem '{0}': ", nome);
                            poder = int.Parse(Console.ReadLine());
                            if (poder < 0)
                            {
                                Console.WriteLine("Poder inválido. Valor mínimo: 0\n");
                            }
                            else if (poder > 999)
                            {
                                Console.WriteLine("Poder inválido. Valor máximo: 10\n");
                            }
                        } while (poder < 0 && poder > 999);

                        personagem.Add(new Personagem(nome, poder));
                        persons++;
                        break;
                    case 2:
                        Personagem.MaisPoderoso(personagem);
                        break;
                    case 3:
                        persons = 3;
                        break;
                }
            }
            Personagem.MaisPoderoso(personagem);

        }
    }
}