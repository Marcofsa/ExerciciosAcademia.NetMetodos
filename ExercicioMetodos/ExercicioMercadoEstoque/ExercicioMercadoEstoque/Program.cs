namespace ExercicioMercadoEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();
            prod1.nome = "Arroz 5kg";
            prod1.quantidadeEstoque = 150;
            prod1.valorUnit = 9.79;
            prod1.valorVenda = 16;

            Comanda comanda1 = new Comanda();
            comanda1.quantPedido = 2;
            comanda1.pagamento = "Vale-Alimentação";
            comanda1.produto = prod1;
            comanda1.calcularPedido();
        }
    }
}