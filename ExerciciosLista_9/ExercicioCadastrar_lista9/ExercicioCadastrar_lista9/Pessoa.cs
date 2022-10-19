using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCadastrar_lista9
{
    internal class Pessoa
    {
        protected string Nome { get; set; }

        protected string Email { get; set; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
           
        }



    }
}
