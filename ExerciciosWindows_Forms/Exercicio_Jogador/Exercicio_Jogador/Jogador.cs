using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Jogador
{
    internal class Jogador
    {
        string nome;
        string email;

        public Jogador(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }

        public static bool jaCadastrado(string nome, List<Jogador> lista)
        {
            foreach (Jogador i in lista)
            {
                if (nome.Equals(i.Nome))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
