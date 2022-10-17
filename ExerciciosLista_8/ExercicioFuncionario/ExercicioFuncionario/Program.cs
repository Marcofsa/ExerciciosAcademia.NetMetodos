namespace ExercicioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> livros = new Dictionary<string, int>();
            int opc;

            do
            {
                Console.WriteLine(" === Bem-vindo ao sistema de Livros === \n");
                Console.WriteLine("1 - Registrar um novo livro");
                Console.WriteLine("2 - Exibir todos os livros");
                Console.WriteLine("3 - Pesquisar um livro");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Informe o nome do livro: ");
                        string livro = Console.ReadLine();
                        Console.Write($"Informe a quantidade de páginas do livro {livro}: ");
                        int paginas = int.Parse(Console.ReadLine());

                        livros.Add(livro, paginas);
                        break;
                    case 2:
                        Console.Clear();
                        foreach (var l in livros)
                        {
                            Console.WriteLine($"Titulo: {l.Key}  |  Páginas: {l.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Informe o título do livro a ser localizado: ");
                        string titulo = Console.ReadLine();
                        break;
                }
            } while (opc != 4);
        }
    }
}