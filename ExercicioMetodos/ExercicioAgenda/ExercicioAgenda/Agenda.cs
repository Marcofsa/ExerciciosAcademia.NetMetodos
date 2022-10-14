using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAgenda
{
    class Agenda

    {
        public int[] vet = new int[10];

        public List<Pessoa> pessoa = new List<Pessoa>();
        public String nome;

        public Agenda(string nome)
        {
            this.nome = nome;
        }

        public void ArmazenaPessoa(String nome, int idade, float altura)
        {
            Pessoa p = new Pessoa(nome, altura, idade);
            pessoa.Add(p);
        }
        public Pessoa BuscaPessoa(String nome)
        {
            Pessoa n = null;
            foreach (Pessoa p in pessoa)
            {
                if (p.nome.Equals(nome))
                {
                    n = p;
                }
            }
            return n;
        }
         
        public void MostraPessoa()
        {

            foreach(Pessoa p in pessoa)
            {
                Console.WriteLine("Pessoa: " + p.nome + " Idade: " + p.idade + " Altura: " + p.altura);
            }
            

        }
        public void RemovePessoa(String nome)
        {
            foreach (Pessoa p in pessoa)
            {
                if (p.nome.Equals(nome))
                {

                }
            }
        }

    }
}
