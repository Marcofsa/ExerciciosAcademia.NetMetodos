namespace ExercicioMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int paginas;
            string tipo;
            string cor;

            Console.WriteLine("Digite o nome do Livro: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a cor do Livro: ");
            cor = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de páginas do Livro: ");
            paginas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite em qual categoria o Livro se encaixa: ");
            tipo = Console.ReadLine();

            livro nome = new livro();
            nome.();




        }
    }
}