using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEletronico
{
    internal class Xbox : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando o Xbox!");
            //_ligado = true;
            this.Ligado = true;
        }


    }
}
