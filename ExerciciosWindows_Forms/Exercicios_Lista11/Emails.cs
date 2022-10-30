using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista11
{
    class Emails
    {
        private string _nome { get; set; }
        private string _email { get; set; }

        public Emails (string nome, string email)
        {
            _nome = nome;
            _email = email;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
