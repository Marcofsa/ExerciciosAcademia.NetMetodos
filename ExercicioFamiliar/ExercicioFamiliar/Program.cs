namespace ExercicioFamiliar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a idade do(a) '{0}': ", nome);
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso do(a) '{0}': ", nome);
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do(a) '{0}': ", nome);
            double altura = double.Parse(Console.ReadLine());

            string sexo;
            do
            {
                Console.Write("Informe o sexo do(a) '{0}'. (m)asculino ou (f)eminino: ", nome);
                sexo = Console.ReadLine();

                if (sexo == "m" || sexo == "M")
                {
                    sexo = "Masculino";
                    break;
                }
                else if (sexo == "f" || sexo == "F")
                {
                    sexo = "Feminino";
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!\nUtilize apenas 'm' ou 'f'");
                }
            } while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F");

            Console.Write("Informe a cor do olhos do(a) '{0}': ", nome);
            string olhos = Console.ReadLine();

            Console.Write("Informe a cor dos cabelos do(a) '{0}': ", nome);
            string cabelo = Console.ReadLine();

            Console.Write("Informe a raça do(a) '{0}': ", nome);
            string raca = Console.ReadLine();

            Console.Write("Informe o nome do pai do(a) '{0}': ", nome);
            string pai = Console.ReadLine();

            Console.Write("Informe o nome da mãe do(a) '{0}': ", nome);
            string mae = Console.ReadLine();

            Familiar familiar = new Familiar(nome, idade, altura, peso, sexo, olhos, cabelo, raca, pai, mae);
            familiar.getFamiliar();
        }
    }
}