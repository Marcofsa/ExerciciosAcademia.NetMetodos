namespace ExercicioLivro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o título do livro:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe o nome de autoria do livro '{0}':", titulo);
            string autor = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de páginas do livro '{0}':", titulo);
            int paginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo da capa do livro {0}");
            string capa = Console.ReadLine();

            Livro livro = new Livro(titulo, autor, paginas, capa);

            livro.getLivro();


        }
    }
}