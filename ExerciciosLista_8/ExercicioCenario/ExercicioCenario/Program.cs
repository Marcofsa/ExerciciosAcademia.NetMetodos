using System.Globalization;

namespace ExercicioCenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cena> cena = new List<Cena>();
            int opc;

            do
            {
                Console.WriteLine(" >>>>>>>>CENÁRIOS<<<<< \n");
                Console.WriteLine("Digite uma das opções abaixo para prosseguir:");
                Console.WriteLine("1 - Registrar um novo cenário");
                Console.WriteLine("2 - Exibir dados de um cenário");
                Console.WriteLine("3 - Exibir tempo de criação do cenário");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Informe a descrição do cenário: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Informa a data (01/01/2022 00:00:00) \nou deixe vazio para usar a data e hora atual: ");
                        var data = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(data))
                        {
                            data = DateTime.Now.ToString();
                        }

                        DateTime dataValidada;
                        DateTime.TryParse(data, CultureInfo.CurrentCulture, DateTimeStyles.None, out dataValidada);

                        Console.Write("Informe a altura do cenário: ");
                        float altura = float.Parse(Console.ReadLine());

                        cena.Add(new Cena(descricao, dataValidada, altura));

                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Qual cenário deseja exibir (informe o índice)? ");
                        int index = int.Parse(Console.ReadLine());
                        index--;
                        Console.WriteLine("\nCenários:");
                        Cena.DetalhesCena(cena, index);
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Qual cenário deseja exibir o tempo de criação (informe o índice)? ");
                        index = int.Parse(Console.ReadLine());
                        index--;
                        Cena.TempoItem(cena, index);
                        break;
                    case 4: break;
                }
            } while (opc != 4);
        }
    }
}