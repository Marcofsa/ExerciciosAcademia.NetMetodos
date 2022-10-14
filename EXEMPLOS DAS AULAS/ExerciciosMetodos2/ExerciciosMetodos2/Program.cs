namespace ExerciciosMetodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.ligado = true;
            if (carro.ligado)
            {
                Console.WriteLine("O carro esta ligado");
            }
            else
            {
                Console.WriteLine("O carro esta desligado");
            }
        }
    }
}