namespace ExemplosAulasOBJ
{
    //ORIENTAÇÃO A OBJETO.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APRESENTADO, CLASSES, OBJETOS, MÉTODOS E ORIENTAÇÃO A OBJETOS BÁSICA.");
            lampada l1;
            l1 = new lampada();
            l1.ligar();
            Console.WriteLine("STATUS DA LÂMPADA: " + l1.estaLigada());
            l1.desligar();
            Console.WriteLine("STATUS DA LÂMPADA: " + l1.estaLigada());

        }
    }
}