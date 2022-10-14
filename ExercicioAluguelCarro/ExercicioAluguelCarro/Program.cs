namespace ExercicioAluguelCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.setPlaca("PJ7LM8");
            carro.setModelo("Chevrolet S10");
            carro.setColor("Prata");

            Cliente cliente = new Cliente();
            cliente.setNome("Shrek do Pântano");
            cliente.setCpf("123.456.789-10");
            cliente.setTelefone("(00)98765-4321");
            cliente.setEmail("shrek@gmail.com");

            Aluguel aluguel = new Aluguel();
            aluguel.alugar(DateTime.Parse("14/10/2022 11:35:00 AM"), DateTime.Parse("17/10/2022 11:35:00"), 80);
            aluguel.carro = carro;
            aluguel.cliente = cliente;
            Console.WriteLine("Aluguel bem sucedido! Valor total a pagar é de {0:C}.", aluguel.valorAluguel());



        }
    }
}