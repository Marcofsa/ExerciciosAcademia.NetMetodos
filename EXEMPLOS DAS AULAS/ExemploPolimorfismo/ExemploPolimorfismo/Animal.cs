using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    internal class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;
        public Animal (string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        public void EmitirSom()
        {
            Console.WriteLine("Som do animal.");
        }

        public void Dormir()
        {
            Console.WriteLine("O animal está dormindo.");
        }

        public void Caminhar()
        {
            Console.WriteLine("O animal está caminhando.");
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: " + nome + " Sexo: " + sexo + " Raça: " + raca);
        }
    }
}
