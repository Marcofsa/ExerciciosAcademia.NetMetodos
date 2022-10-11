namespace ExemploPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leão?)");
            Animal a;
            a = new Leao("Rei Leão", "Masculino", "Leãozão");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();

            Console.WriteLine("Cachorro?");
            a = new Cachorro("Caramelo", "masculino", "SRD");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();
        
        }
    }
}