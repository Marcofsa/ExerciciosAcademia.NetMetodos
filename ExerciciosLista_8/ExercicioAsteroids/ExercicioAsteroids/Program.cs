namespace ExercicioAsteroids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Asteroides> lista_asteroide = new List<Asteroides>();
            Random random = new Random();
        
            for (int i = 0; i < 50; i++)
            {
                Asteroides asteroide = new Asteroides();
                asteroide.Posicao_x = random.Next(0, 100);
                asteroide.Posicao_y = random.Next(0, 100);
                asteroide.Tamanho = random.Next(1, 10);
                asteroide.Velocidade = random.Next(1, 5);
                asteroide.Energia = random.Next(1, 5);
                lista_asteroide.Add(asteroide);
            }




            foreach (Asteroides i in lista_asteroide)
            {
                Console.WriteLine("Asteroide");
                Console.WriteLine(i.Posicao_x + " " + i.Posicao_y + " " + i.Tamanho + " " + i.Velocidade + " " + i.Energia);



            }

        }
    }
}