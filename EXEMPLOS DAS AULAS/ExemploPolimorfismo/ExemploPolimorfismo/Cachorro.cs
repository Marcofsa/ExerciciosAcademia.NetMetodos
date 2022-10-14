using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, string sexo, string raca): base(nome, sexo, raca)
        {

        }
        public override void EmitirSom()
        {
            Console.WriteLine("Latindo o Pé Duro.");
        }
    }
}
