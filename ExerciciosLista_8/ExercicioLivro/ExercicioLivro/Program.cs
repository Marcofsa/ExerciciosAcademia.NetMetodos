namespace ExercicioLivro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> livros = new Dictionary<string, int>();
            int option;

            do
            {
                Console.WriteLine(" >>>> SISTEMA DE REGISTRO DE LIVROS <<<< \n");
                Console.WriteLine("1 - Registrar um livro");
                Console.WriteLine("2 - Listar os livros");
                Console.WriteLine("3 - Procurar um livro");
                Console.WriteLine("4 - Sair do programa");
                Console.Write("\nSelecione uma opção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o nome do livro: ");
                        string livro = Console.ReadLine();
                        Console.Write($"Quantas páginas tem o livro '{livro}': ");
                        int paginas = int.Parse(Console.ReadLine());

                        livros.Add(livro, paginas);
                        Console.WriteLine($"'{livro}' cadastrado com sucesso!\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*** Livros cadastrados ***");
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

                        var contem = livros.FirstOrDefault((livros) => (livros.Key.Equals(titulo)));

                        if (contem.Key != null)
                        {
                            Console.WriteLine($"Titulo: {contem.Key}   |   Páginas: {contem.Value}");
                        }
                        else
                        {
                            Console.WriteLine("\nTítulo não encontrado. Verifique a ortografia e tente novamente.\nObs.: Maiúsculos e minúsculos são diferentes.\n");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Essa opção não é válida!\n");
                        break;
                }
            } while (option != 4);
        }
    }
}