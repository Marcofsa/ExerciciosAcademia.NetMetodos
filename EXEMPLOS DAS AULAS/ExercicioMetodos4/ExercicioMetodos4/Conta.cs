using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodos4
{
    public class Conta
    {
        public string conta;
        private double saldo = 0;
        public string tipo = "corrente";
        public Conta(string cliente, double saldo, string tipo)
        {
            this.conta = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }
        public void depositar (double valor)
        {
            saldo += valor;
            Console.WriteLine("O valor creditado foi: " + valor);
        }
        public void debitar (double valor)
        {
            saldo -= valor;
            Console.WriteLine("O valor debitado foi: " + valor);
        }
        public double getSaldo()
        {
            return saldo;
        }
        



    }
}
