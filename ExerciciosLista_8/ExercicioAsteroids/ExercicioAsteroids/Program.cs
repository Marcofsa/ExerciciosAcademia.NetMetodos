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
                asteroide.posX = random.Next(0, 100);
                asteroide.posY = random.Next(0, 100);
                asteroide.tamanho = random.Next(1, 10);
                asteroide.velocidade = random.Next(1, 5);
                asteroide.energia = random.Next(1, 5);
                lista_asteroide.Add(asteroide);
            }




            foreach (Asteroides i in lista_asteroide)
            {
                Console.WriteLine("Asteroide");
                Console.WriteLine(i.posX + " " + i.posY + " " + i.tamanho + " " + i.velocidade + " " + i.energia);



            }

        }
    }
}