using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEletronico
{
    internal class Eletronico
    {
        public int volts;
        public int potencia;
        public string ligado;

        public abstract void Ligar();
        public void Desligar()
        {
            ligado = false;
            Console.WriteLine("Desligando o equipamento.");
        }
        public void VerificaLigado()
        {
            return ligado;
        }

    }


}
