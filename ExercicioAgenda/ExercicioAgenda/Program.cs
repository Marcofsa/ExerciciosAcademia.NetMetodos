namespace ExercicioAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Agenda A = new Agenda("Agendamento de Pessoas.");
            string nome;
            float altura;
            int idade;
            Pessoa consulta = null;
            while (true)
            {
                Console.WriteLine("Digite 1 Para adicionar pessoas a agenda: \nDigite 2 Para buscar as informações:\nDigite 3 Para apagar a pessoa da agenda\nDigite 4 Para sair:\n");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Digite o nome do agendado: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade do agendado: ");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura do agendado");
                    altura = float.Parse (Console.ReadLine());
                    A.ArmazenaPessoa(nome, idade, altura);
                    Console.Clear();
                    A.MostraPessoa();
                }

                if (option == 2)
                {
                    Console.WriteLine("Digite o nome do agendado: ");
                    nome = Console.ReadLine();
                    consulta = A.BuscaPessoa(nome);
                    if(consulta != null)
                    {
                        Console.WriteLine("Pessoa encontrada! NOME: " + consulta.nome + "Idade: " + consulta.idade);
                    }
                    else
                    {
                        Console.WriteLine("PESSOA NÃO ENCONTRADA!!");
                    }

                    if (option == 3)
                    {
                        Console.WriteLine("Digite o nome da pessoa que sairá do agendamento: ");
                        nome= Console.ReadLine();

                    }

                    if (option == 4)
                    {
                        break;
                    }
                }


            }
        }
    }
}