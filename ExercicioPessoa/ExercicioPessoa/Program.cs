namespace ExercicioPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade da pessoa: ", nome);
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa: ", nome);
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da pessoa: ", nome);
            double altura = double.Parse(Console.ReadLine());

            string sexo;
            do
            {
                Console.WriteLine("Informe o sexo da pessoa: (M)asculino ou (F)eminino:", nome);
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

                    Console.WriteLine("Esse sexo não existe!\nUtilize apenas 'M' ou 'F'! ");

                }


            } while (sexo != "M" && sexo != "F");

            Console.WriteLine("Informe a cor dos olhos de: ", nome);
            string olhos = Console.ReadLine();

            Console.WriteLine("Informe a cor dos cabelos de: ", nome);
            string cabelos = Console.ReadLine();

            Console.WriteLine("Informe a raça de: ", nome);
            string raca = Console.ReadLine();

            Pessoa pessoa1 = new Pessoa(nome, idade, peso, altura, sexo, olhos, cabelos, raca);
            pessoa1.getPessoa();




        }
    }
}