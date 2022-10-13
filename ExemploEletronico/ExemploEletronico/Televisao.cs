using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEletronico
{
    internal class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando a TV.");
            ligado = true;
        }
    }
}
