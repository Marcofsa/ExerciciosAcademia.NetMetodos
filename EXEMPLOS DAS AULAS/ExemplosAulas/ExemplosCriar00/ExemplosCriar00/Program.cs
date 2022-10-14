namespace ExemplosCriar00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransacaoBancaria conta = new TransacaoBancaria();
            conta.conta = "123456-7";
            conta.agencia = "012 - 3";
            conta.valor = 1000.33;
            conta.tipo = "1";


            Console.WriteLine("");
        }
    }
}