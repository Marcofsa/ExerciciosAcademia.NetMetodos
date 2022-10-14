using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMercadoEstoque
{
    internal class Produto
    {
        public string nome;
        public int quantidadeEstoque;
        public double valorUnit;
        public double valorVenda;

        public int vender(int quantidade)
        {
            if (quantidadeEstoque > quantidade)
            {
                Console.WriteLine("Autorizado!");
                quantidadeEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Estoque insuficiente!\nVenda não autorizada, devido a falta de estoque!");
            }
            return quantidadeEstoque;
        }

        public int repor(int quantidade)
        {
            quantidadeEstoque += quantidade;
            return quantidadeEstoque;
        }
    }
}
