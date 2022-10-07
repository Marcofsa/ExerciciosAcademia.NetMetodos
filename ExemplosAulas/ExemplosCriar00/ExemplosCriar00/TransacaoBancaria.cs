using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosCriar00
{
    internal class TransacaoBancaria
    {
        public string agencia;
        public string  tipo;
        public double valor;
        public string conta;
        public TransacaoBancaria()
        {

        }

        public void sacar()
        {
            valor = valor - 100;
            Console.WriteLine("O valor será sacado em breve.");

        }
        public void depositar()
        {
            valor = valor + 100;
            Console.WriteLine("O valor será depositado, aguarde o comprovante.");

        }
        public void consultarSaldo()
        {
            Console.WriteLine("Seu saldo é: "+valor);
            
        }
        public void dadosCliente()
        {
            Console.WriteLine($"Agência: {agencia}\nTipo de conta: {tipo}\nNúmero da conta: {conta}\nValor disponível na conta: {valor}" );
        }

    }
}
