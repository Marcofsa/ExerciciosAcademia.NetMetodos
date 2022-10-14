using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluguelCarro
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string email;

        public void setNome (string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public void setEmail()
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }



    }
}
