using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateOnly data_Nascimento { get; set; }

        public Pessoa(string nome, string cpf, DateOnly data_Nascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.data_Nascimento = data_Nascimento;
        }

        public override string ToString()
        {
            return "Nome: " + nome + "Cpf: " + cpf + "Data de Nascimento: " + data_Nascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa &&
                cpf == pessoa.cpf;
        }

        public int CompareTo(object? obj)
            Pessoa p 
        {

        }

    }
}
