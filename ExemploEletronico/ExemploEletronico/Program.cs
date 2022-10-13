namespace ExemploEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Televisao t = new Televisao();

            Console.WriteLine("Olá, Boa tarde!\nDeseja ligar o equipamento?");
            Console.WriteLine("Digite 1 para ligar\nDigite 2 para desligar\n Digite 3 para verificar se está ligado\nDigite 4 para sair.");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                if (t.VerificaLigado())
                {
                    Console.WriteLine("Já está Ligado!");
                }
                else
                {
                    t.Ligar();
                }

            }
            else if (option == 2)
            {
                if (!t.VerificaLigado())
                {
                    Console.WriteLine("Já está desligado!");
                }
                else
                {
                    t.Desligar();
                }

            }
            else if (option == 3)
            {
                if (t.VerificaLigado())
                {
                    Console.WriteLine("Está ligado!");

                }
                else
                {
                    Console.WriteLine("Está Desligado!");
                }           
           
          
            }

            if (option == 4)
            {
                break;
            }
        }
    }
}