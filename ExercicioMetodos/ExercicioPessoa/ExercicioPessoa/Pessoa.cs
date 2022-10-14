using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoa
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double peso;
        private double altura;
        private string sexo;
        private string olhos;
        private string cabelos;
        private string raca;

        public Pessoa(string nome, int idade, double peso, double altura, string sexo, string olhos, string cabelos, string raca)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
            this.sexo = sexo;
            this.olhos = olhos;
            this.cabelos = cabelos;
            this.raca = raca;
        }

        public void getPessoa()
        {
            Console.Clear();
            Console.WriteLine("{0} Cadastrado com sucesso!", nome);
            Console.WriteLine("{0} anos, {1}m de altura e {2}kg", idade, altura, peso);
            Console.WriteLine("Sexo {0}, olhos {1}, cabelos {2}, e raca {3}", sexo, olhos, cabelos, raca);
        }

    }
}
