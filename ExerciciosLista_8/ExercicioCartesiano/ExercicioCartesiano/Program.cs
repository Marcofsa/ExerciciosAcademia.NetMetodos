namespace ExercicioCartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cartesiano> cart = new List<Cartesiano>();
            int opc;
            int quant = 0;

            do
            {
                Console.WriteLine(" Plano Cartesiano \n");
                Console.WriteLine("1 - Registrar um novo plano");
                Console.WriteLine("2 - Exibir dados de um plano");
                Console.WriteLine("3 - Exibir lista de planos");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o valor de X: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Informe o valor de Y: ");
                        double y = double.Parse(Console.ReadLine());

                        cart.Add(new Cartesiano(x, y));
                        quant++;
                        Console.WriteLine($"Valor registrado no índice {quant}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Qual índice gostaria de consultar? ");
                        int indice = int.Parse(Console.ReadLine());
                        indice--;
                        Cartesiano.getXY(cart, indice);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Planos Cartesianos:\n");
                        foreach (var c in cart)
                        {
                            Console.WriteLine($"X: {c.X}  |  Y: {c.Y}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }
            } while (opc != 4);
        }
    }
}