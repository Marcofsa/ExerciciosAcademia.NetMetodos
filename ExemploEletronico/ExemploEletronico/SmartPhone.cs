using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEletronico
{
    internal class SmartPhone : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Android iniciando");
            //_ligado = true;
            this.Ligado = true;
        }

    }
}
