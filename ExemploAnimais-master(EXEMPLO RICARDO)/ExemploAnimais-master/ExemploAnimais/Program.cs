namespace ExemploAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao exemplo dos animais!!");
            Animal a; //aqui eu não sei o que ele vai decidir ser
            Console.WriteLine("Hummm Leão?");
                
            a = new Leao("Rei leão", "masculino", "leãozão");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();


            Console.WriteLine("Cusco?");
            a = new Cachorro("Caramelo", "masculino", "SRD");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();
        }
    }
}