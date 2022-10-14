using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterface
{
    internal class Smartphone : InterfaceEletronico
    {
        private int _volts;
        private int _potencia;
        private bool _ligado;


        public bool Ligado
        {
            get => _ligado;
            set => _ligado = value;
        }
        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o equipamento");
        }

        public void Ligar()
        {
            Console.WriteLine("Android iniciando");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
}
