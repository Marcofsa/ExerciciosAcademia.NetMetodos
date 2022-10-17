namespace ExemploReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo: ");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe o E-Mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Informe o telefone: ");
            float fone = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Estado Civil: ");
            string estado = Console.ReadLine();

            Console.WriteLine(nome + " tem casa própria? (1 - SIM || 2 - NÃO) ");
            int casa = int.Parse(Console.ReadLine());

            double aluguel = 0;

            if (casa == 2)
            {
                Console.WriteLine("Informe o valor do aluguel: ");
            }

            StreamWriter writer = new StreamWriter(@"C:\GIT New ACADEMIA\ExerciciosAcademia.NetMetodos\ExercicioArquivos(Questão1)\Questao1.txt");

            writer.Write(nome);
            writer.Write(";");
            writer.Write(idade);
            writer.Write(";");
            writer.Write(sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel + Environment.NewLine);
            writer.Close();


            StreamReader reader = new StreamReader(@"C:\GIT New ACADEMIA\ExerciciosAcademia.NetMetodos\ExercicioArquivos(Questão1)\Questao1.txt");

            string linha = "";

            Console.WriteLine("--------------------------------------");
            linha = reader.ReadLine();

            while (linha != null)
            {
                Console.WriteLine(linha);

                linha = reader.ReadLine();
            }

            Console.WriteLine("----------------------------------------");
            reader.Close();

        }
    }
}