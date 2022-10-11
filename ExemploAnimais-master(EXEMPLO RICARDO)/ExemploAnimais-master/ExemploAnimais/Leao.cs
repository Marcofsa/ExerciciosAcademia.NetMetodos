using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimais
{
    //public class Leao extends Animal
    internal class Leao : Animal
    {
        public Leao(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Leão dando uns grito");
        }
    }
}
