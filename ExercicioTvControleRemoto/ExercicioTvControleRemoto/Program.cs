namespace ExercicioTvControleRemoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto c1 = new ControleRemoto();
            int opc = 8;
            do
            {
                Console.WriteLine("1 - Aumentar o Volume");
                Console.WriteLine("2 - Diminuir o Volume");
                Console.WriteLine("3 - Avançar Canal");
                Console.WriteLine("4 - Retroceder Canal");
                Console.WriteLine("5 - Escolher Canal");
                Console.WriteLine("6 - Informações");
                Console.WriteLine("7 - Sair");
                Console.Write("\nEscolha sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        c1.tv.aumentaVolume();
                        break;
                    case 2:
                        c1.tv.diminuiVolume();
                        break;
                    case 3:
                        c1.tv.avancaCanal();
                        break;
                    case 4:
                        c1.tv.voltaCanal();
                        break;
                    case 5:
                        c1.tv.trocaCanal();
                        break;
                    case 6:
                        c1.tv.volCanInfo();
                        break;
                }
            } while (opc != 7); ;
        }
    }
}