using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimais
{
    abstract class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;
        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        // +emitirSom():int

        public abstract void EmitirSom();

        public void Dormir()
        {
            Console.WriteLine("Ta a mimir");
        }

        public void Caminhar()
        {
            Console.WriteLine("Está a andar");
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome: "+nome+" Sexo "+sexo+" Raça: "+raca);
        }

    }
}
