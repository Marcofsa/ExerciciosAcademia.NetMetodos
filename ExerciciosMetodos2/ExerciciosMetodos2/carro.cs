using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMetodos2
{

    public class Carro
    {
        public double velocidadeMax;
        public string modelo;
        public string cor;
        public string placa;
        public string fabricante;
        public bool ligado = false;
        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
    }
}
}
