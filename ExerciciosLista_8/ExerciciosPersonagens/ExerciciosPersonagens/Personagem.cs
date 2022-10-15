using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPersonagens
{
    internal class Personagem
    {
        private string _nome { get; set; }
        private int _poder { get; set; }

        public Personagem() { }
        public Personagem(string nome, int poder)
        {
            this.Nome = nome;
            this.Poder = poder;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Poder { get => _poder; set => _poder = value; }
        public void ExibirDados()
        {
            Console.WriteLine("\nPersonagem: {0}    Poder: {1}", Nome, Poder);
        }

        public static void MaisPoderoso(List<Personagem> p)
        {
            Personagem maisP = p[0];
            foreach (Personagem mais in p)
            {
                if (mais.Poder > maisP.Poder)
                {
                    maisP = mais;
                }
            }
            Console.WriteLine("\nPersonagem mais poderoso:");
            maisP.ExibirDados();
        }

    }
}
