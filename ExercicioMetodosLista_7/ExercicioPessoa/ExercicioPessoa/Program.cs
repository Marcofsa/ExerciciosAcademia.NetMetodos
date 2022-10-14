namespace ExercicioPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("   Informe o nome da pessoa: ");
            Console.WriteLine("|------------------------------|");
            string nome = Console.ReadLine();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("   Informe a idade da pessoa: ", nome);
            Console.WriteLine("|------------------------------|");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("    Informe o peso da pessoa: ", nome);
            Console.WriteLine("|------------------------------|");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("   Informe a altura da pessoa: ", nome);
            Console.WriteLine("|------------------------------|");
            double altura = double.Parse(Console.ReadLine());

            string sexo;
            do
            {
                Console.WriteLine("|----------------------------------------------------------|");
                Console.WriteLine("  Informe o sexo da pessoa: (M)asculino ou (F)eminino:", nome);
                Console.WriteLine("|----------------------------------------------------------|");
                sexo = Console.ReadLine().ToUpper();
                if (sexo == "M")
                {
                    sexo = "Masculino";
                    break;
                }

                else if (sexo == "F")
                {
                    sexo = "Feminino";
                }

                else
                {
                    Console.WriteLine("|----------------------------------------------------------|");
                    Console.WriteLine("Esse sexo não existe!\nUtilize apenas 'M' ou 'F'! ");
                    Console.WriteLine("|----------------------------------------------------------|");
                }


            } while (sexo != "M" && sexo != "F");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("   Informe a cor dos olhos de: ", nome);
            Console.WriteLine("|----------------------------------|");
            string olhos = Console.ReadLine();
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("    Informe a cor dos cabelos de: ", nome);
            Console.WriteLine("|----------------------------------|");
            string cabelos = Console.ReadLine();
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("    Informe a raça de: ", nome);
            Console.WriteLine("|----------------------------------|");
            string raca = Console.ReadLine();

            Pessoa pessoa1 = new Pessoa(nome, idade, peso, altura, sexo, olhos, cabelos, raca);
            pessoa1.getPessoa();




        }
    }
}