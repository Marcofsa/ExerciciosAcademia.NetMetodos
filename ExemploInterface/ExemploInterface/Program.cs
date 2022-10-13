namespace ExemploInterface
{
    internal class Program
    {
       static void Main(string[] args)
            {
                int op;
                TV t = new TV ();
                while (true)
                {
                    Console.WriteLine("Olá, boa tarde\nDeseja ligar o equipamento?");
                    Console.WriteLine("Digite 1 para ligar\nDigite 2 para desligar\nDigite 3 para verificar se está ligado\nDigite 4 para sair");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        if (t.Ligado)
                        {
                            Console.WriteLine("Já está ligado!");
                        }
                        else
                        {
                            t.Ligar();
                        }

                    }
                    else if (op == 2)
                    {
                        if (!t.Ligado)
                        {
                            Console.WriteLine("Já está desligado!");

                        }
                        else
                        {
                            t.Desligar();
                        }
                    }
                    else if (op == 3)
                    {
                        if (t.Ligado)
                        {
                            Console.WriteLine("Está ligado!");
                        }
                        else
                        {
                            Console.WriteLine("Está desligado!");
                        }
                    }
                    else if (op == 4)
                    {
                        break;
                    }
                }
            }
        }
}