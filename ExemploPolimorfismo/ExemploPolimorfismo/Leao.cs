using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    internal class Leao : Animal
    {
        public int peso;
     

        public Leao (string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("LEÃO RUGINDO.");
        }

    }
}
