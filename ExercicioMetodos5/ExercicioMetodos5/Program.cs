using System.Drawing;

namespace ExercicioMetodos5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente c = new cliente("Marcos ", 3200, " Corrente");
            while (true)
            {
                Console.WriteLine("Digite:\n 1 - para sacar\n 2 - Para depositar\n 3 - Para consultar saldo\n 0 - Para sair");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("Digite o calor do saque: ");
                        c.debitar(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do depósito: ");
                        c.depositar(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("O seu saldo é: " + c.getSaldo());

                        break;
                    default:
                        Console.WriteLine("O cliente " + c.cliente.nome + " possui saldo de " + c.getSaldo());
                        return;

                }

            }

        }
    }
}