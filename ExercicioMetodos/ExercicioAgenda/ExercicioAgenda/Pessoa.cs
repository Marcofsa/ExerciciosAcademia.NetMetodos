using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAgenda
{
    internal class Pessoa
    {
        public string nome;
        public float altura;
        public int idade;

        public Pessoa(string nome, float altura, int idade)
        {
            this.nome = nome;
            this.altura = altura;
            this.idade = idade;
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: " + this.nome + " Idade: " + this.idade + " Altura: " + this.altura);
        }
    }
}
