using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMercadoEstoque
{
    internal class Comanda
    {
        public int quantPedido;
        public string pagamento;
        public Produto produto;
        public double valorPedido;

        public void calcularPedido()
        {
            valorPedido = produto.valorVenda * quantPedido;
            Console.WriteLine("Custo do pedido --> {0:C}", valorPedido);
        }
    }
}
